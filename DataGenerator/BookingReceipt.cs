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
            SembawangSportEntities1 context = new SembawangSportEntities1();
            

            int bookingID=16; //dummy value that is to be retrieved from other form
            List<Booking1> list = context.Booking1.Where(x => x.BookingID == bookingID).ToList();
            crReceipt cr = new crReceipt();
            cr.SetDataSource(list);
            crReceiptViewer.ReportSource = cr;

            
        }
    }
}
