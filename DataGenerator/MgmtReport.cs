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
            SembawangSportEntities context = new SembawangSportEntities();
            string conS = "Data source = (local); Initial Catalog = SembawangSport; Integrated Security = SSPI";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "select FacilityType, COUNT(BookingID) from Facilities, Bookings where Facilities.FacilityID = Bookings.FacilitiesID group by Facilities.FacilityType";
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();
            cn.Open();
            da.Fill(ds);
            cn.Close();
            CRMgmt cr = new CRMgmt();
            cr.SetDataSource(ds);
            CRMgmtView.ReportSource = cr;
        }
    }
}
