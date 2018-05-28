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
    public partial class ClientList : UserControl
    {
        
        public ClientList()
        {
            InitializeComponent();

            //DataGridView set up 
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dgv_client_list.DefaultCellStyle = dataGridViewCellStyle3;
            
            btn_client_delete.Enabled = btn_client_edit.Enabled = false;
            
            //load operations
            show_client_list();

            
        }

        private static ClientList obj;

        public static ClientList get_obj
        {
            get
            {
                if(obj==null)
                    obj = new ClientList();
                return obj;
            }
            set
            {
                obj = value;
            }
        }
        //show list method
        private void show_client_list()
        {
            sql.con.Open();
            string command = "Select c_name as 'Client Name',c_phone as 'Phone No',c_email as 'Email'," + 
                "c_company as 'Company Name',c_address as 'Company Address'," +
                "c_tel as 'Telephone' from Client_info";

            
            sql.cmd.CommandText = command;
            sql.reader = sql.cmd.ExecuteReader();

            DataTable dtable = new DataTable();
            dtable.Load(sql.reader);

            dgv_client_list.DataSource = dtable;

            sql.con.Close();
        }
        //
        private void dgv_client_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btn_client_delete.Font = btn_client_edit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_client_delete.Enabled = btn_client_edit.Enabled = true;
        }

        private void btn_client_edit_Click(object sender, EventArgs e)
        {
            try
            {
                EditClient.get_uc_EditClient.tb_c_name.Text = dgv_client_list.SelectedRows[0].Cells[0].Value.ToString();
                EditClient.get_uc_EditClient.tb_c_phone.Text = dgv_client_list.SelectedRows[0].Cells[1].Value.ToString();
                EditClient.get_uc_EditClient.tb_c_email.Text = dgv_client_list.SelectedRows[0].Cells[2].Value.ToString();
                EditClient.get_uc_EditClient.tb_c_company.Text = dgv_client_list.SelectedRows[0].Cells[3].Value.ToString();
                EditClient.get_uc_EditClient.tb_c_address.Text = dgv_client_list.SelectedRows[0].Cells[4].Value.ToString();
                EditClient.get_uc_EditClient.tb_c_tel.Text = dgv_client_list.SelectedRows[0].Cells[5].Value.ToString();

                Home.pnl_display.Controls.Clear();
                Home.pnl_display.Controls.Add(EditClient.get_uc_EditClient);
                EditClient.get_uc_EditClient.Dock = DockStyle.Fill;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "please Select a Row of values");
            }
        }

        private void btn_client_delete_Click(object sender, EventArgs e)
        {
            //DialogResult desition;
            //desition = MessageBox.Show("Do you want to delete client \"" + dgv_client_list.SelectedRows[0].Cells[0].Value.ToString()+"\"","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            //if(desition==DialogResult.Yes)
            //{
            //    sql.con.Open();

                
            //    sql.cmd.CommandText = "Delete from Client_info where c_phone='" + dgv_client_list.SelectedRows[0].Cells[1].Value.ToString() + "'";

            //    int a = sql.cmd.ExecuteNonQuery();
            //    sql.con.Close();
            //    if (a != 0)
            //    {
            //        MessageBox.Show("Client delete");

            //        Home.pnl_display.Controls.Clear();
            //        Home.pnl_display.Controls.Add(ClientList.get_obj);
            //        ClientList.get_obj.Dock = DockStyle.Fill;
            //    }
            //    else
            //        MessageBox.Show("Something wrong");
            //}
        }
    }
}
