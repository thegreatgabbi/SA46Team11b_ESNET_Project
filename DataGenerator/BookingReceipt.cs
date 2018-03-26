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
    public partial class BookingReceipt : Form
    {
        public BookingReceipt()
        {
            InitializeComponent();
        }

        private void BookingReceipt_Load(object sender, EventArgs e)
        {
            SembawangSportEntities context = new SembawangSportEntities();
            //if making datasets
            //string conS = "Data Source = (local); Initial Catalog = SembawangSport; Integrated Security = SSPI";
            //SqlConnection cn = new SqlConnection(conS);
            //SqlCommand cm = new SqlCommand();
            //cm.Connection = cn;
            //DataSet ds = new DataSet();
            //cn.Open();
            //SqlDataAdapter da = new SqlDataAdapter(cm);

            int bookingID=15; //dummy value that is to be retrieved from other form
            List<Booking> list = context.Bookings.Where(x => x.BookingID == bookingID).ToList();
            //Facility facility = context.Facilities.Where(y => y.FacilityID == booking.FacilitiesID).First();
            crReceipt cr = new crReceipt();
            cr.SetDataSource(list);
            crReceiptViewer.ReportSource = cr;

            
        }
    }
}
