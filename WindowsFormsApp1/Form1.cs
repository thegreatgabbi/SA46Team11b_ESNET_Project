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
        child1 f1 = new child1();
        child2 f2 = new child2();

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void bookFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Hide();
            f1.Show();
            f1.MdiParent = this;
            
        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.Hide();
            f2.MdiParent = this;
            f2.Show();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
