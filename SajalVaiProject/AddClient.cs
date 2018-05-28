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
    public partial class AddClient : UserControl
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private static AddClient obj;

        public static AddClient get_obj
        {
            get
            {
                if(obj == null)
                {
                    obj = new AddClient();
                }

                return obj;
            }
        }

        //Validation check
        private void btn_c_save_Click(object sender, EventArgs e)
        {
            bool allOk;

            if(tb_c_name.Text != "" && tb_c_phone.Text != "" )
            {
                allOk = true;
            }
            else
            {
                allOk = false;
                MessageBox.Show("star(*) fields are required");
            }

            if (Validator.EmailIsValid(tb_c_email.Text))
            {
                allOk = true;
            }
            else
            {
                allOk = false;
                MessageBox.Show("Email is not in Correct format");
            }

            if (allOk)
            {
                add_client();
                ClientList.get_obj = null;
                AddOrder.get_addOrder = null;
            }
        }

        //Number Validation
        private void tb_c_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tb_c_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //...............operations............
        //---------------add client---------
        private void add_client()
        {
            sql.con.Open();

            
            sql.cmd.CommandText = "Insert into Client_info(c_name,c_phone,c_email,c_company,c_address,c_tel) values('"+tb_c_name.Text+"','"+tb_c_phone.Text+"','"+tb_c_email.Text+"','"+tb_c_company.Text+"','"+tb_c_address.Text+"','"+tb_c_tel.Text+"')";
            sql.cmd.ExecuteNonQuery();

            sql.con.Close();

            MessageBox.Show("Client Added");

            tb_c_name.Text = tb_c_phone.Text = tb_c_email.Text = tb_c_company.Text = tb_c_address.Text = tb_c_tel.Text = "";
        }

        
    }
}
