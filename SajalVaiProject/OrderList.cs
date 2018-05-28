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
            sql.con.Open();

            //sql.cmd.Connection = sql.con;
            sql.cmd.CommandText = "Select o_id as 'Order Id', o_c_phone as 'Client Phone', o_title as 'Title',o_type as 'Type',o_about as 'Description',o_date as 'Order Date',o_delivery as 'Delivery Date',o_price as 'Price',o_advance as 'Advance Paid' from Order_info";
            sql.reader = sql.cmd.ExecuteReader();

            DataTable dtable = new DataTable();
            dtable.Load(sql.reader);

            int n = 0;
            while (dtable.Rows.Count != n)
            {
                paths.Add(dtable.Rows[n][4].ToString());
                dtable.Rows[n][4] = "Read/Write";
                dgv_order_list.Rows.Add(dtable.Rows[n].ItemArray);
                n++;
            }
            
            sql.con.Close();
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

    }
}
