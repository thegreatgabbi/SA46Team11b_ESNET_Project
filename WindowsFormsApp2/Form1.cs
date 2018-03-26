using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var f2 = new child1();
            
            f2.TopLevel = false;
            f2.Location = new Point(5, 5);
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Visible = true;
            this.tabPage1.Controls.Add(f2);
        }
    }
}
