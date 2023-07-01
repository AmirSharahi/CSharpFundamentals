using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_project
{
    public partial class Form1 : Form
    {
        static DateTime jesus_BirthDay = new DateTime();
        private DateTime inSaat = DateTime.Now;
        private DateTime inSaa = DateTime.Today;
        private DateTime inSa = DateTime.UtcNow;
        DateTime tenYearsLater = jesus_BirthDay.AddYears(10);
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(myAge.DayOfWeek.ToString(), "ya ali" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            //MessageBox.Show(inSaat.ToString());
            //MessageBox.Show(inSaa.ToString());
            //MessageBox.Show(inSa.ToString());
            //MessageBox.Show(DateTime.Now.ToString());
            //MessageBox.Show("now time :" + DateTime.Now);
            MessageBox.Show(tenYearsLater.ToString());
        }

    }
}
