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
    public partial class WelcomeForm : Form
    {
       

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void bookFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            var f2 = new child1();
            f2.TopLevel = false;
            f2.Location = new Point(0, 0);
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Visible = true;
            this.tabPage1.Controls.Add(f2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}
