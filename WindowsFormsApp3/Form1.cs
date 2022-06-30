using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int mount, year;
        public static int static_mount, static_years;

        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();


            mount++;
            DateTime startofygemoung = new DateTime(year, mount, 1);
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mount);
            label8.Text = monthname + " " + year;

            int days = DateTime.DaysInMonth(year, mount);
            int dayoftheweek = Convert.ToInt32(startofygemoung.DayOfWeek.ToString("d"));


            static_mount = mount;
            static_years = year;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaDay();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();


            mount--;
            DateTime startofygemoung = new DateTime(year, mount, 1);
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mount);
            label8.Text = monthname + " " + year;

            int days = DateTime.DaysInMonth(year, mount);
            int dayoftheweek = Convert.ToInt32(startofygemoung.DayOfWeek.ToString("d"));

            static_mount = mount;
            static_years = year;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void displaDay()
        {
            DateTime now = DateTime.Now;

            mount = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(mount);
            label8.Text = monthname + " " + year;

            DateTime startofygemoung = new DateTime(year, mount, 1);
            int days = DateTime.DaysInMonth(year, mount);
            int dayoftheweek = Convert.ToInt32(startofygemoung.DayOfWeek.ToString("d"));

            static_mount = mount;
            static_years = year;
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
