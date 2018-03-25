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
    public partial class BookFacility : Form
    {
        DateTime selectedDate;

        SembawangSportEntities context;
        List<Booking> listBookings;
        List<FacilitySchedule> listFacilityAvailabiltyByDay;

        public BookFacility()
        {
            InitializeComponent();

            // initialize selectedDate
            selectedDate = new DateTime(2018, 1, 4);

            // Cache from DB all entries for that day where the Facilities ID matches
            context = new SembawangSportEntities();

            // LINQ doesn't support 'Date' type, so we have to use `int` types
            var bookingsByDayQuery = context.Bookings
                .Where(x => x.BookingDateFrom.Day == selectedDate.Day)
                .Where(x => x.BookingDateFrom.Month == selectedDate.Month)
                .Where(x => x.BookingDateFrom.Year == selectedDate.Year)
                .Where(x => x.Facility.FacilityType == "Badminton Court");

            // - Convert it to a List<Booking>
            listBookings = bookingsByDayQuery.ToList();

            // Generate the appropriate amount of FacilitySchedule objects
            // Get get unique facility types (e.g. "Badminton Court 1", "Badminton Court 2", "Badminton Court 3")
            var facilityScheduleQuery = bookingsByDayQuery.GroupBy(x => x.Facility.FacilityName).Select(y => new { y.Key });

            listFacilityAvailabiltyByDay = new List<FacilitySchedule>();

            // create 3 FacilitySchedule objects
            foreach (var schedule in facilityScheduleQuery.ToList())
            {
                listFacilityAvailabiltyByDay.Add(new FacilitySchedule(listBookings, schedule.Key));
            }

        }

        /// <summary>
        /// When a Facility Type is selected. Assumes that bookDT picker is populated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void facilityTypeCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Make sure you hide the Welcome Message!
            label1.Visible = false;
            label2.Visible = false;

            // display it in dataGridView
            dataGridView1.DataSource = listFacilityAvailabiltyByDay.ToList();
            // change column header names
            dataGridView1.Columns["FacName"].HeaderText = "Facility Name";
            dataGridView1.Columns[1].HeaderText = "7AM";
            dataGridView1.Columns[2].HeaderText = "8AM";
            dataGridView1.Columns[3].HeaderText = "9AM";
            dataGridView1.Columns[4].HeaderText = "10AM";
            dataGridView1.Columns[5].HeaderText = "11AM";
            // Add more columns as necessary
        }

        /// <summary>
        /// Turn true/false values into blue/blank boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // if e.RowIndex != -1 && e.ColumnIndex != -1
            if (e.RowIndex > -1 && e.ColumnIndex > 0)
            {
                // if cell value is “true”
                if (e.Value.ToString() == "True")
                {
                    e.CellStyle.BackColor = SystemColors.Highlight;
                    e.CellStyle.ForeColor = SystemColors.Highlight;
                }
                if (e.Value.ToString() == "False")
                {
                    e.CellStyle.ForeColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }
        }

        /// <summary>
        /// When double-clicking a cell, either trigger a New Booking form or Modify Booking form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int hour = 0;
            string bookingType;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
            {
                bookingType = "Modify Booking";
            } else
            {
                bookingType = "New Booking";
            }

            MessageBox.Show("Type of form triggerred: " + bookingType);
            MessageBox.Show("Date: " + selectedDate.ToShortDateString());
            MessageBox.Show("Facility Name:" + listFacilityAvailabiltyByDay[e.RowIndex].FacName.ToString());
            // get the correct timing
            // look at the column, and pass an Hour object
            // can we create an Enum to help with the mapping?
            switch (e.ColumnIndex)
            {
                case 1:
                    hour = 7;
                    break;
                case 2:
                    hour = 8;
                    break;
                case 3:
                    hour = 9;
                    break;
                case 4:
                    hour = 10;
                    break;
                case 5:
                    hour = 11;
                    break;
            }
            MessageBox.Show("Time: " + hour.ToString());

        }
        // TODO: Create FacilitySchedule class
        public class FacilitySchedule
        {
            string facName;
            // Not the best class design I know...but it's to match the DataSource structure
            bool time14_16 = false;
            bool time8_9 = false;
            bool time9_10 = false;
            bool time10_11 = false;
            bool time11_12 = false;

            public string FacName
            {
                get { return facName; }
            }
            public string Time14_16
            {
                get { return time14_16.ToString(); }
            }
            public string Time8_9
            {
                get { return time8_9.ToString(); }
            }
            public string Time9_10
            {
                get { return time9_10.ToString(); }
            }
            public string Time10_11
            {
                get { return time10_11.ToString(); }
            }
            public string Time11_12
            {
                get { return time11_12.ToString(); }
            }

            /// <summary>
            /// With a list of Bookings by day and
            /// </summary>
            /// <param name="dailyBookings"></param>
            /// <param name="facName"></param>
            public FacilitySchedule(List<Booking> dailyBookings, string facName)
            {
                this.facName = facName;
                // for the day, if the slot has been booked, make that slot true
                foreach (Booking bk in dailyBookings)
                {
                    if (bk.Facility.FacilityName == facName)
                    {
                        if (bk.BookingDateFrom.Hour <= 14 && bk.BookingDateTo.Hour >= 16)
                        {
                            time14_16 = true;
                        }
                        if (bk.BookingDateFrom.Hour <= 8 && bk.BookingDateTo.Hour >= 9)
                        {
                            time8_9 = true;
                        }
                        if (bk.BookingDateFrom.Hour <= 9 && bk.BookingDateTo.Hour >= 10)
                        {
                            time9_10 = true;
                        }
                        if (bk.BookingDateFrom.Hour <= 10 && bk.BookingDateTo.Hour >= 11)
                        {
                            time10_11 = true;
                        }
                        if (bk.BookingDateFrom.Hour <= 11 && bk.BookingDateTo.Hour >= 12)
                        {
                            time11_12 = true;
                        }
                    }
                }
            }
        }
    }
}
