using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGenerator
{
    public partial class MgmtReport : Form
    {
        public MgmtReport()
        {
            InitializeComponent();
        }

        private void MgmtReport_Load(object sender, EventArgs e)
        {
           
            CRMgmt cr = new CRMgmt();
            
            CRMgmtView.ReportSource = cr;
            
        }
    }
}
