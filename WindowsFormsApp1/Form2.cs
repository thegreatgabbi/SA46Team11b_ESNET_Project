using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH:00";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.MinDate = Convert.ToDateTime("1/1/2018 7:00AM");
            dateTimePicker1.MaxDate = Convert.ToDateTime("1/1/2018 9:00PM");

        }
    }
}
