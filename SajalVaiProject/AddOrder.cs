using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SajalVaiProject
{
    public partial class AddOrder : UserControl
    {
        public AddOrder()
        {
            InitializeComponent();
            generate_c_phone();
            generate_orderid();
        }

        static AddOrder a_o_i;
        public static AddOrder get_addOrder
        {
            get
            {
                if (a_o_i == null)
                    a_o_i = new AddOrder();
                return a_o_i;
            }
            set
            {
                a_o_i = value;
            }
        }

        private void generate_c_phone()
        {
            sql.con.Open();

            //sql.cmd.Connection = sql.con;
            sql.cmd.CommandText = "select c_name,c_phone from Client_info";
            sql.reader = sql.cmd.ExecuteReader();

            while (sql.reader.Read())
            {
                cb_c_name.Items.Add(sql.reader.GetString(0));
                cb_c_phone.Items.Add(sql.reader.GetString(1));
            }

            sql.con.Close();
        }

        private void generate_orderid()
        {
            sql.con.Open();

            //sql.cmd.Connection = sql.con;
            sql.cmd.CommandText = "Select count(o_id) from Order_info";

            int count = Convert.ToInt32(sql.cmd.ExecuteScalar()) + 1;
            lbl_o_id.Text = "o_" + count.ToString();

            sql.con.Close();
        }


        private void cb_c_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_c_phone.SelectedIndex = cb_c_name.SelectedIndex;
        }

        private void cb_c_phone_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_c_name.SelectedIndex = cb_c_phone.SelectedIndex;
        }

        //Save order description
        public static string save_description_txt(string order_id, string description)
        {
            string filePath = System.Windows.Forms.Application.StartupPath + "\\Order description";
            if (!System.IO.Directory.Exists(filePath))
                System.IO.Directory.CreateDirectory(filePath);

            string fileName = filePath + "\\" + order_id + ".txt";

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName))
            {
                sw.WriteAsync(description);
            }
            return fileName;
        }

        //add Order
        int add_order()
        {
            string filePath = save_description_txt(lbl_o_id.Text, tb_o_about.Text);

            sql.con.Open();

            //sql.cmd.Connection = sql.con;
            sql.cmd.CommandText = "Insert into Order_info values ('" + lbl_o_id.Text + "','" + cb_c_phone.Text + "','" + tb_o_title.Text + "','" + tb_o_type.Text + "','" + filePath + "','" + dtp_o_date.Text + "','" + dtp_o_delivery.Text + "','" + tb_price.Text + "','" + tb_advance.Text + "')";

            int n = sql.cmd.ExecuteNonQuery();

            sql.con.Close();

            return n;
        }

        //Validation Check
        private void btn_o_save_Click(object sender, EventArgs e)
        {
            bool allOk = false;

            if (tb_o_title.Text == "")
            {
                allOk = false;
                MessageBox.Show("Title is required");
            }
            else
                allOk = true;

            if (cb_c_phone.SelectedIndex == -1)
            {
                allOk = false;
                MessageBox.Show("Please select Client name or phone");
            }
            else
                allOk = true;

            if (tb_price.Text == "")
                tb_price.Text = "0";
            if (tb_advance.Text == "")
                tb_advance.Text = "0";

            if (allOk)
            {
                if (add_order() != 0)
                {
                    MessageBox.Show("Order Saved");
                    //Reset All controls
                    generate_orderid();
                    OrderList.get_order_list = null;

                    tb_o_title.Text = tb_o_type.Text = tb_o_about.Text = tb_price.Text = tb_advance.Text = "";
                    cb_c_phone.SelectedIndex = cb_c_name.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("Somethig wrong, Try again");


            }

        }



        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_advance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
