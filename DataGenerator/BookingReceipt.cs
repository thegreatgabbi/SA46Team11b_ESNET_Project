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
        public int bookingID =16; //dummy initial value for bookingID
        public BookingReceipt(int x)
        {
            InitializeComponent();
            bookingID = x;
        }
    

        private void BookingReceipt_Load(object sender, EventArgs e)
        {
            SembawangSportEntities1 context = new SembawangSportEntities1();
            //retrieve the booking in question from database
            List<Booking1> list = context.Booking1.Where(x => x.BookingID == bookingID).ToList();
            crReceipt cr = new crReceipt();
            cr.SetDataSource(list);
            crReceiptViewer.ReportSource = cr;

            
        }
    }
}
