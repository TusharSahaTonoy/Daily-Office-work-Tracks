using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data.SQLite;

namespace SajalVaiProject
{

    public partial class Home : Form
    {

        public static Panel pnl_display;

        public Home()
        {
            InitializeComponent();
            

            //----------pnl_display configuration -------
            pnl_display = new Panel();
            

            pnl_display.Location = new System.Drawing.Point(216, 58);
            pnl_display.Size = new System.Drawing.Size(791, 483);

            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Controls.Add(pnl_display);

            startup_operations();

            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(HomePage.get_object);
        }
        private static void startup_operations()
        {
            //get ready Database 
            //try
            //{
            //    sql.con.Open();

            //    sql.cmd.Connection = sql.con;
            //    //sql.cmd.CommandText = "Select * from Client_info";
            //    //sql.cmd.ExecuteNonQuery();

            //    sql.con.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            try
            {
                sqlite.con.Open();
                
                sqlite.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            btn_select.Top = btn_home.Top;
            btn_select.Height = btn_home.Height;

            pnl_display.Controls.Clear();
        }

        private void btn_addClient_Click(object sender, EventArgs e)
        {
            btn_select.Top = btn_addClient.Top;
            btn_select.Height = btn_addClient.Height;

            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(AddClient.get_obj);
            AddClient.get_obj.Dock = DockStyle.Fill;
        }

        private void btn_clientList_Click(object sender, EventArgs e)
        {
            btn_select.Top = btn_clientList.Top;
            btn_select.Height = btn_clientList.Height;

            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(ClientList.get_obj);
            ClientList.get_obj.Dock = DockStyle.Fill;
        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            btn_select.Top = btn_addOrder.Top;
            btn_select.Height = btn_addOrder.Height;

            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(AddOrder.get_addOrder);
            AddOrder.get_addOrder.Dock = DockStyle.Fill;
        }

        private void btn_order_list_Click(object sender, EventArgs e)
        {
            btn_select.Top = btn_order_list.Top;
            btn_select.Height = btn_order_list.Height;

            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(OrderList.get_order_list);
            OrderList.get_order_list.Dock = DockStyle.Fill;
        }

        private void btn_visit_Click(object sender, EventArgs e)
        {
            btn_select.Top = btn_visit.Top;
            btn_select.Height = btn_visit.Height;

            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(VisitList.get_v_list);
        }

        //panal winbar window move with mouse
        int mouse_x;
        int mouse_y;
        bool mousedown;
        private void pnl_winBar_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void pnl_winBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown)
            {
                mouse_x = MousePosition.X - 395- 217;
                mouse_y = MousePosition.Y - 40;
                SetDesktopLocation(mouse_x, mouse_y);
            }
        }

        private void pnl_winBar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        
    }

    //public static class sql
    //{
    //    static string con_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ Application.StartupPath+@"\SoftITDB.mdf;Integrated Security=True";

    //    public static SqlConnection con = new SqlConnection(con_string);
    //    public static SqlCommand cmd = new SqlCommand();
    //    public static SqlDataReader reader;

    //}

    public static class sqlite
    {
        static string con_string = "Data Source = SoftIt.db; Version=3;New=False;Compress=True;";
        public static SQLiteConnection con= new SQLiteConnection(con_string);
        public static SQLiteCommand cmd = con.CreateCommand();
        public static SQLiteDataReader reader;
        public static SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        public static DataSet dset = new DataSet();
        public static DataTable dtable = new DataTable();

    }
    

    public static class Validator
    {

        static Regex ValidEmailRegex = CreateValidEmailRegex();

        /// <summary>
        /// Taken from http://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx
        /// </summary>
        /// <returns></returns>
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        internal static bool EmailIsValid(string emailAddress)
        {
           return ValidEmailRegex.IsMatch(emailAddress);
        }
    }


}
