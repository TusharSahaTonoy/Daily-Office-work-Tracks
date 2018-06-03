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
    public partial class OrderList : UserControl
    {
        public OrderList()
        {
            InitializeComponent();

            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dgv_order_list.DefaultCellStyle = dataGridViewCellStyle3;

            get_list_order();
        }

        private static OrderList order_list;

        public static OrderList get_order_list
        {
            get
            {
                if(order_list ==null)
                    order_list = new OrderList();
                return order_list;
            }
            set
            {
                order_list = value;
            }
        }

        List<string> paths = new List<string>();
        void get_list_order()
        {
            sqlite.con.Open();

            //sqlite.cmd.Connection = sqlite.con;
            sqlite.cmd.CommandText = "Select o_id as 'Order Id', o_c_phone as 'Client Phone', o_title as 'Title',o_type as 'Type',o_about as 'Description',o_date as 'Order Date',o_delivery as 'Delivery Date',o_price as 'Price',o_advance as 'Advance Paid' from Order_info";
            sqlite.reader = sqlite.cmd.ExecuteReader();

            DataTable dtable = new DataTable();
            dtable.Load(sqlite.reader);

            int n = 0;
            while (dtable.Rows.Count != n)
            {
                paths.Add(dtable.Rows[n][4].ToString());
                dtable.Rows[n][4] = "Read/Write";
                dgv_order_list.Rows.Add(dtable.Rows[n].ItemArray);
                n++;
            }
            
            sqlite.con.Close();
        }

        private void dgv_order_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Description frm = new Description();
                frm.filepath = paths[e.RowIndex];
                frm.ShowDialog();
            }


        }

        //-------------------passing value to user control edit Order ----------------
        //--------------------start---------------

        string filepath;
        private void dgv_order_list_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            filepath= paths[e.RowIndex];

            btn_o_edit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btn_o_edit.Enabled = true;
        }
        
        void description_load()
        {

            if (!System.IO.File.Exists(filepath))
            {
                MessageBox.Show("Could not find file in this path " + filepath, "File does not exist");
                return;
            }

            using (System.IO.StreamReader sr = new System.IO.StreamReader(filepath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    EditOrder.get_detail_order.tb_o_about.Text += line;
                    EditOrder.get_detail_order.tb_o_about.Text += Environment.NewLine;
                }
            }
        }

        private void btn_o_edit_Click(object sender, EventArgs e)
        {
            EditOrder obj = EditOrder.get_detail_order;

            obj.lbl_o_id.Text = dgv_order_list.SelectedRows[0].Cells[0].Value.ToString();
            obj.lbl_o_c_phone.Text = dgv_order_list.SelectedRows[0].Cells[1].Value.ToString();
            obj.tb_o_title.Text = dgv_order_list.SelectedRows[0].Cells[2].Value.ToString();
            obj.tb_o_type.Text = dgv_order_list.SelectedRows[0].Cells[3].Value.ToString();

            description_load();

            obj.dtp_o_date.Text = dgv_order_list.SelectedRows[0].Cells[5].Value.ToString(); 
            obj.dtp_o_delivery.Text = dgv_order_list.SelectedRows[0].Cells[6].Value.ToString();
            obj.tb_o_price.Text= dgv_order_list.SelectedRows[0].Cells[7].Value.ToString();
            obj.tb_o_advance.Text = dgv_order_list.SelectedRows[0].Cells[8].Value.ToString();

            Home.pnl_display.Controls.Clear();
            Home.pnl_display.Controls.Add(obj);

        }
        //--------------------end---------------

    }
}
