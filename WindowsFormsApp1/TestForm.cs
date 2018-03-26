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
        /// Test getting the BookingID. Should return 11.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bookingDate = new DateTime(2018, 2, 3);
            string facName = "Badminton Court 2";
            int bookingFrom = 12;

            label1.Text = Program.GetBookingID(bookingDate, facName, bookingFrom).ToString();
        }

        /// <summary>
        /// Test validating against existing booking of Badminton Court 4 on 2018-1-4 from 14:00 to 16:00. Should return false because it clashes with the booking.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime bookingDate = new DateTime(2018, 1, 4);
            string facName = "Badminton Court 4";
            int bookingFrom = 12;
            int bookingTo = 14;

            label1.Text = Program.ValidateBooking(bookingDate, facName, bookingFrom, bookingTo).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "label1";
        }
    }
}
