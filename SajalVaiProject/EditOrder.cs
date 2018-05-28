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
    }

}
