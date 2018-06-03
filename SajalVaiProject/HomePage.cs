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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private static HomePage obj;
        public static HomePage get_object
        {
            get
            {
                if (obj == null)
                    obj = new HomePage();
                return obj;
            }
            set
            {
                obj = value;
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        void load_()
        {
            sqlite.con.Open();



            sqlite.con.Close();
        }
    }
}
