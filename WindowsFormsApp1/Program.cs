using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
        static public int GetBookingID(DateTime bookingDate, string facName, int bookingFrom)
        {
            TimeSpan ts = new TimeSpan(bookingFrom, 0, 0);
            DateTime bookingDateFrom = bookingDate + ts;
            int bookingID;

            // When to cache and when not to cache?
            SembawangSportEntities context = new SembawangSportEntities();

            var q = context.Bookings.Where(x => x.BookingDateFrom == bookingDateFrom).Where(x => x.Facility.FacilityName == facName).Select(x => x.BookingID);

            bookingID = q.First();
            // MessageBox.Show(q.First().ToString()); // FOR DEBUG
            return bookingID;
        }
    }
}
