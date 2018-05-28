using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SajalVaiProject
{
    public partial class AddVisit : UserControl
    {
        public AddVisit()
        {
            InitializeComponent();
            generate_count();
        }

        private static AddVisit visit_form;
        public static AddVisit get_visit
        {
            get
            {
                if (visit_form == null)
                    visit_form = new AddVisit();
                return visit_form;
            }
        }

        //generate visit count
        private void generate_count()
        {
            sql.con.Open();

            //sql.cmd.Connection = sql.con;
            sql.cmd.CommandText = "Select count(v_id) from Visit_info";
            lbl_v_id.Text= Convert.ToString(Convert.ToInt32(sql.cmd.ExecuteScalar())+1);

            sql.con.Close();
        }

        //Record Visite Rsponse
        string save_response(string id, string response)
        {
            string filepath;

            filepath = Application.StartupPath + "\\Visit Response";
            if (!System.IO.Directory.Exists(filepath))
                System.IO.Directory.CreateDirectory(filepath);

            filepath = filepath + "\\" + id + ".txt";

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filepath))
            {
                sw.WriteAsync(response);
            }

            return filepath;
        }

        //
        private void btn_v_save_Click(object sender, EventArgs e)
        {
            string rspnsFP = save_response(lbl_v_id.Text,tb_v_response.Text);

            sql.con.Open();

            sql.cmd.CommandText = "Insert into Visit_info values('"+lbl_v_id.Text+"','"+tb_v_company.Text+"','"+tb_v_address.Text+"','"+tb_v_phone.Text+"','"+dtp_v_date.Text+"','"+tb_v_type.Text+"','"+tb_v_visitor.Text+"','"+ rspnsFP + "')";

            int n =sql.cmd.ExecuteNonQuery();

            sql.con.Close();

            if (n != 0)
                MessageBox.Show("Visit record save");
            else
                MessageBox.Show("Something Wrong");

            tb_v_company.Text = tb_v_address.Text= tb_v_phone.Text = tb_v_type.Text = tb_v_visitor.Text = tb_v_response.Text = "";

            generate_count();
            VisitList.get_v_list = null;
            
        }

        private void tb_v_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
