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
    public partial class VisitList : UserControl
    {
        public VisitList()
        {
            InitializeComponent();
            load_dgv_v_list();
        }

        private static VisitList v_list;
        public static VisitList get_v_list
        {
            get
            {
                if(v_list ==null)
                    v_list = new VisitList();
                return v_list;
            }
            set
            {
                v_list = value;
            }
        }

        List<string> paths = new List<string>();

        //load dgv with visit list
        void load_dgv_v_list()
        {
            sql.con.Open();

            //sql.cmd.Connection = sql.con;
            sql.cmd.CommandText = "select * from Visit_info";
            sql.reader= sql.cmd.ExecuteReader();

            

            DataTable table = new DataTable();
            table.Load(sql.reader);
            sql.con.Close();

            int n = 0;
            while(table.Rows.Count!=n)
            {
                paths.Add(table.Rows[n][7].ToString());
                table.Rows[n][7] = "Read/Write";
                dgv_v_list.Rows.Add(table.Rows[n].ItemArray);
                n++;
            }
            
            
        }

        private void btn_new_visit_Click(object sender, EventArgs e)
        {
            Home.pnl_display.Controls.Clear();
            Home.pnl_display.Controls.Add(AddVisit.get_visit);
        }

        private void dgv_v_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==7)
            {
                Description obj = new Description();
                obj.filepath = paths[e.RowIndex];
                obj.ShowDialog();
            }
        }
    }
}
