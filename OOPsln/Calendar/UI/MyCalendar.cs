using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar.UI
{
    public partial class MyCalendar : UserControl
    {
        const int Y_BEGIN = 105;
        const int X_BEGIN = 10;
        const int DISTANCE = 60;
        int YCurent = Y_BEGIN;
        public MyCalendar()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            
            //Lay Date hien tai
            DateTime now = DateTime.Now;
            // Hien thi thang
            lblMonth.Text = now.Month.ToString();
            int dayInMonth = DateTime.DaysInMonth(now.Year, now.Month);
            for (int i = 1; i <= dayInMonth; i++)
            {
                // Tao doi tuong Calendar
                Calendar calendar = new Calendar();
                calendar.Day = i;
                calendar.Month = now.Month;
                calendar.Year = now.Year;
                // Hien thi item
                CalendarItem calendarItem = new CalendarItem();
                calendarItem.Location = new Point(X_BEGIN + (calendar.GetDateOfWeek() - 1) * DISTANCE, YCurent);
                calendarItem.Day = i.ToString();
                if(i == now.Day)
                {
                    calendarItem.BackColor = Color.Orchid;
                }
                // cuoi tuan
                if (calendar.GetDateOfWeek() == 7)
                {
                    YCurent += DISTANCE;
                }
                this.Controls.Add(calendarItem);
            }

        }
    }
}
