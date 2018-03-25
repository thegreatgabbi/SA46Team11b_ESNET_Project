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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Test getting the BookingID. Should return 10.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bookingDate = new DateTime(2018, 1, 14);
            string facName = "Azelea";
            int bookingFrom = 8;
            Program.GetBookingID(bookingDate, facName, bookingFrom);
        }
    }
}
