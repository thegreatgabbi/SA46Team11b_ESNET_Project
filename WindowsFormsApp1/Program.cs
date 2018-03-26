using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGenerator;

namespace WindowsFormsApp1
{
    static class Program
    {
        // Global Variables
        static string SQL_NAME = "NAGAPPAN\\VALLISQL";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FacilityAvailabiltyForm());
        }
        /// <summary>
        /// Get the Booking ID.
        /// </summary>
        /// <param name="bookingDate"></param>
        /// <param name="facName"></param>
        /// <param name="bookingFrom"></param>
        /// <returns></returns>
        static public int GetBookingID(DateTime bookingDate, string facName, int bookingFrom)
        {
            TimeSpan ts = new TimeSpan(bookingFrom, 0, 0);
            DateTime bookingDateFrom = bookingDate + ts;
            int bookingID;

            // When to cache and when not to cache?
            SembawangSportEntities context = new SembawangSportEntities();

            var q = context.Bookings
                .Where(x => x.BookingDateFrom <= bookingDateFrom &&
                            x.BookingDateTo > bookingDateFrom        
                )
                .Where(x => x.Facility.FacilityName == facName).Select(x => x.BookingID);
            if (q.Count() == 1)
            {
                bookingID = q.First();
            } else
            {
                bookingID = -1; // no ID found!
            }
            
            // MessageBox.Show(q.First().ToString()); // FOR DEBUG
            return bookingID;
        }
        /// <summary>
        /// Checks to see if the slot chosen overlaps with any other booking. Assumes all bookings mutually exclusive.
        /// </summary>
        /// <param name="bookingDate"></param>
        /// <param name="facName"></param>
        /// <param name="bookingFrom"></param>
        /// <param name="bookingTo"></param>
        /// <returns></returns>
        public static bool ValidateBooking(DateTime bookingDate, string facName, int bookingFrom, int bookingTo)
        {
            // get full timestamps
            DateTime bookingDateFrom = bookingDate + new TimeSpan(bookingFrom, 0, 0);
            DateTime bookingDateTo = bookingDate + new TimeSpan(bookingTo, 0, 0);
            bool isBookingValid;

            SembawangSportEntities context = new SembawangSportEntities();

            var q = context.Bookings
                .Where(x => (x.BookingDateFrom >= bookingDateFrom && x.BookingDateTo <= bookingDateTo) || // queried timeslot sits completely inside existing timeslot
                            (x.BookingDateFrom <= bookingDateFrom && x.BookingDateTo >= bookingDateTo) || // exisiting timeslot sits completely inside queried timeslot
                            (x.BookingDateFrom <= bookingDateFrom && x.BookingDateTo > bookingDateFrom) || // exisiting timeslot overlaps with queried timeslot
                            (x.BookingDateFrom < bookingDateTo && x.BookingDateTo >= bookingDateTo) // exisiting timeslot overlaps with queried timeslot
                )
                .Where(x => x.Facility.FacilityName == facName);

            if (q.Count() == 0)
            {
                isBookingValid = true;
            } else
            {
                isBookingValid = false;
            }

            return isBookingValid;
        }
    }
}
