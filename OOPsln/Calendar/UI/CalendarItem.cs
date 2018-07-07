using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.UI
{
    public partial class CalendarItem : UserControl
    {
        public string Day
        {
            set
            {
                lblDay.Text = value.ToString();
                lblDay.Location = new Point((Width - lblDay.Width) / 2, lblDay.Location.Y);
            }
        }

        public CalendarItem()
        {
            InitializeComponent();
        }

    }
}
