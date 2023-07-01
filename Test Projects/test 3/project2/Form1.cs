using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersianCalendar PC = new PersianCalendar();
            DateTime Miladi = new DateTime(2003 , 08 , 17);
            int year = PC.GetYear(Miladi);
            int month = PC.GetMonth(Miladi);
            int day = PC.GetDayOfMonth(Miladi);
            string BDShamsi = year + "/" + month + "/" + day;
            MessageBox.Show(BDShamsi);
        }
    }
}
