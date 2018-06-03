using System;
using System.Windows.Forms;

namespace SajalVaiProject
{
    public partial class EditOrder : UserControl
    {
        public EditOrder()
        {
            InitializeComponent();
        }

        private static EditOrder edit_order;

        public static EditOrder get_detail_order
        {
            get
            {
                if(edit_order == null)
                    edit_order = new EditOrder();

                return edit_order;
            }
        }

        private void btn_o_save_Click(object sender, EventArgs e)
        {
            //validation check
            
            if (tb_o_price.Text == "")
                tb_o_price.Text = "0";
            if (tb_o_advance.Text == "")
                tb_o_advance.Text = "0";

            //Edit opration ---------------
            if (tb_o_title.Text != "")
            {
                string filepath = AddOrder.save_description_txt(lbl_o_id.Text, tb_o_about.Text);
                sqlite.con.Open();

                //sql.cmd.Connection = sql.con;
                sqlite.cmd.CommandText = "Update Order_info set o_title='" + tb_o_title.Text + "',o_type='" + tb_o_type.Text + "',o_about='" + filepath + "',o_date='" + dtp_o_date.Text + "',o_delivery='" + dtp_o_delivery.Text + "',o_price='" + tb_o_price.Text + "',o_advance='" + tb_o_advance.Text + "' where o_id='" + lbl_o_id.Text + "'";

                int n = sqlite.cmd.ExecuteNonQuery();

                sqlite.con.Close();

                if (n != 0)
                {
                    MessageBox.Show("Order edited");
                    OrderList.get_order_list = null;
                }
                else
                {
                    MessageBox.Show("Something wrong,Try again");
                }
            }
            else
                MessageBox.Show("Title is required");
        }
    }

}
