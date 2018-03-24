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
    
    public partial class ModifyForm : Form
    {   
        SembawangSportEntities ctx = new SembawangSportEntities();
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

        }

        private void MakeBookinglbl_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBookingbtn_Click(object sender, EventArgs e)
        {
            //var q=from x in ctx.Members where (x.MemberID==
        }
    }
}
