using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SajalVaiProject
{
    public partial class Description : Form
    {
        public Description()
        {
            InitializeComponent();
        }

        private void Description_Load(object sender, EventArgs e)
        {
            read_and_show_txt();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            tb_dcption.ReadOnly = false;
            btn_Edit.Enabled = false;
            btn_Save.Enabled = true;
        }

        public string filepath;

        private void btn_Save_Click(object sender, EventArgs e)
        {

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filepath))
            {
                sw.WriteAsync(tb_dcption.Text);
                tb_dcption.ReadOnly = true;
                btn_Edit.Enabled = true;
                btn_Save.Enabled = false;
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            if (btn_Edit.Enabled == true)
                Dispose();
            else
            {
                MessageBox.Show("Current document is not save","Save Document");
            }
        }

        void read_and_show_txt()
        {
            if (!System.IO.File.Exists(filepath))
            {
                MessageBox.Show("Could not find file in this path "+filepath,"File does not exist");
                return;
            }

            using (System.IO.StreamReader sr = new System.IO.StreamReader(filepath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    tb_dcption.Text += line;
                    tb_dcption.Text += Environment.NewLine;
                }
            }
        }

        
    }
}
