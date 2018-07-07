using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.UI;

namespace Calendar
{
    public partial class UICalendar : Form
    {
        public UICalendar()
        {
            InitializeComponent();
            MyCalendar calendar = new MyCalendar();
            calendar.Location = new Point(0, 0);
            Controls.Add(calendar);
        }
    }
}
