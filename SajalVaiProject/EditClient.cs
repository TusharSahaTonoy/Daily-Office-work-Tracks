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
    public partial class EditClient : UserControl
    {
        public EditClient()
        {
            InitializeComponent();
        }

        private static EditClient uc_client_edit;

        public static EditClient get_uc_EditClient
        {
            get
            {
                if(uc_client_edit==null)
                    uc_client_edit = new EditClient();

                return uc_client_edit;
            }
        }

        private void btn_c_save_Click(object sender, EventArgs e)
        {
            sqlite.con.Open();

            //
            sqlite.cmd.CommandText = "update Client_info "+
                "set c_name='" + tb_c_name.Text + "',c_email='" + tb_c_email.Text+"',"+
                "c_company='" + tb_c_company.Text + "',c_address='" + tb_c_address.Text + "',"+
                "c_tel='" + tb_c_tel.Text +"' where c_phone='"+tb_c_phone.Text+"'";

            int a=sqlite.cmd.ExecuteNonQuery();

            sqlite.con.Close();
            if(a!=0)
            {
                MessageBox.Show("Client edited");
                ClientList.get_obj = null;
            }

            else
                MessageBox.Show("Something wrong");
        }

        private void btn_edit_cancel_Click(object sender, EventArgs e)
        {
            Home.pnl_display.Controls.Clear();
            Home.pnl_display.Controls.Add(ClientList.get_obj);
        }
    }
}
