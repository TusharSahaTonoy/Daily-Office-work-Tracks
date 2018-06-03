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
            sqlite.con.Open();

            //sql.cmd.Connection = sql.con;
            sqlite.cmd.CommandText = "Select count(v_id) from Visit_info";
            lbl_v_id.Text = Convert.ToString(Convert.ToInt32(sqlite.cmd.ExecuteScalar()) + 1);

            sqlite.con.Close();
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

        int save_visit_record()
        {
            string rspnsFP = save_response(lbl_v_id.Text, tb_v_response.Text);
            int n = 0;

            sqlite.con.Open();

            sqlite.cmd.CommandText = "Insert into Visit_info values('" + lbl_v_id.Text + "','" + tb_v_company.Text + "','" + tb_v_address.Text + "','" + tb_v_phone.Text + "','" + dtp_v_date.Text + "','" + tb_v_type.Text + "','" + tb_v_visitor.Text + "','" + rspnsFP + "')";

            n = sqlite.cmd.ExecuteNonQuery();

            sqlite.con.Close();

            return n;

        }
        //
        private void btn_v_save_Click(object sender, EventArgs e)
        {
            int n = 0;

            if(tb_v_company.Text!="")
            {
                n = save_visit_record();

                if (n != 0)
                {
                    MessageBox.Show("Visit record save");
                    tb_v_company.Text = tb_v_address.Text = tb_v_phone.Text = tb_v_type.Text = tb_v_visitor.Text = tb_v_response.Text = "";

                    generate_count();
                    VisitList.get_v_list = null;
                }
                else
                    MessageBox.Show("Somethig wrong");
            }
            else
                MessageBox.Show("Star(*) field is required");

            
        }

        private void btn_v_cancel_Click(object sender, EventArgs e)
        {
            Home.pnl_display.Controls.Clear();
            Home.pnl_display.Controls.Add(VisitList.get_v_list);
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
