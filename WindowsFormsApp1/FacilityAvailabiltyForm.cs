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
    public partial class FacilityAvailabiltyForm : Form
    {
        // Test case: Badminton Court 4 on 7/1/2018

        DateTime selectedDate;

        SembawangSportEntities context;
        List<Booking> listBookings;
        List<FacilitySchedule> listFacilityAvailabiltyByDay;

        public DataGridView dataGrid1;

        public FacilityAvailabiltyForm()
        {
            InitializeComponent();

            // Cache from DB all entries for that day where the Facilities ID matches
            context = new SembawangSportEntities();

            // put focus on FacilityTypeCombo
            facilityTypeCombo.Select();
            facilityTypeCombo.Text = "- Select Facility Type -";

            // leave a reference for other forms
            dataGrid1 = dataGridView1;
        }

        /// <summary>
        /// When a Facility Type is selected. Assumes that bookDT picker is populated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void facilityTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (facilityTypeCombo.SelectedIndex != -1)
            {
                // Make sure you hide the Welcome Message!
                label1.Visible = false;
                label2.Visible = false;

                RenderDataGrid();
            }
        }

        /// <summary>
        /// Renders Data Grid.
        /// </summary>
        public void RenderDataGrid()
        {
            // get selectedDate
            // selectedDate = new DateTime(2018, 1, 4); // REMOVE: for testing
            selectedDate = bookDTPicker.Value.Date;

            // LINQ doesn't support 'Date' type, so we have to use `int` types
            var bookingsByDayQuery = context.Bookings
                .Where(x => x.BookingDateFrom.Day == selectedDate.Day)
                .Where(x => x.BookingDateFrom.Month == selectedDate.Month)
                .Where(x => x.BookingDateFrom.Year == selectedDate.Year)
                //.Where(x => x.Facility.FacilityType == "Badminton Court"); // REMOVE: for testing
                .Where(x => x.Facility.FacilityType == facilityTypeCombo.Text);

            // - Convert it to a List<Booking>
            listBookings = bookingsByDayQuery.ToList();

            // Generate the appropriate amount of FacilitySchedule objects
            // Get get unique facility types (e.g. "Badminton Court 1", "Badminton Court 2", "Badminton Court 3")
            var facilityNames = context.Facilities.Where(x => x.FacilityType == facilityTypeCombo.Text);
            listFacilityAvailabiltyByDay = new List<FacilitySchedule>();

            // create 3 FacilitySchedule objects
            foreach (var facility in facilityNames.ToList())
            {
                listFacilityAvailabiltyByDay.Add(new FacilitySchedule(listBookings, facility.FacilityName));
            }

            // display it in dataGridView
            dataGridView1.DataSource = listFacilityAvailabiltyByDay.ToList();
            // resize columns as necessary
            dataGridView1.Columns[0].Width = 200;
            for (var i = 1; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }
            // change column header names
            dataGridView1.Columns["FacName"].HeaderText = "Facility Name";
            dataGridView1.Columns[1].HeaderText = "7AM";
            dataGridView1.Columns[2].HeaderText = "8AM";
            dataGridView1.Columns[3].HeaderText = "9AM";
            dataGridView1.Columns[4].HeaderText = "10AM";
            dataGridView1.Columns[5].HeaderText = "11AM";
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > 0)
            {
                string facName;
                DateTime date;
                int hour = 0;

                facName = listFacilityAvailabiltyByDay[e.RowIndex].FacName.ToString();
                date = selectedDate;

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
                    default:
                        break;
                }

                // trigger correct type of form
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
                {
                    // Trigger Modify Booking
                    //bookingType = "Modify Booking";
                    ModifyForm form1 = new ModifyForm(facName, date, hour);
                    form1.refToAvailabiltyForm = this;
                    form1.ShowDialog();
                }
                else
                {
                    // Trigger New Booking
                    //bookingType = "New Booking";
                    MakeBookingForm form2 = new MakeBookingForm(facName, date, hour);
                    form2.refToAvailabiltyForm = this;
                    form2.ShowDialog();
                }

                //MessageBox.Show("Type of form triggerred: " + bookingType);
                //MessageBox.Show("Date: " + selectedDate.ToShortDateString());
                //MessageBox.Show("Facility Name: " + listFacilityAvailabiltyByDay[e.RowIndex].FacName.ToString());
                //MessageBox.Show("Time: " + hour.ToString() + "AM");
            }
        }

        public class FacilitySchedule
        {
            string facName;
            // Not the best class design I know...but it's to match the DataSource structure
            bool time7_8 = false;
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
                get { return time7_8.ToString(); }
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
                        if (bk.BookingDateFrom.Hour <= 7 && bk.BookingDateTo.Hour >= 8)
                        {
                            time7_8 = true;
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

        /// <summary>
        /// Prevents highlighting from occuring. Doesn't disrupt the clicking of a cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        /// <summary>
        /// Refreshes data grid when ">" button next to BookingDTPicker is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextDayButton_Click(object sender, EventArgs e)
        {
            bookDTPicker.Value = bookDTPicker.Value.AddDays(1);
            if (facilityTypeCombo.SelectedIndex != -1)
            {
                RenderDataGrid();
            }
        }

        /// <summary>
        /// Refreshes data grid when "<" button next to BookingDTPicker is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void previousDayButton_Click(object sender, EventArgs e)
        {
            bookDTPicker.Value = bookDTPicker.Value.AddDays(-1);
            if (facilityTypeCombo.SelectedIndex != -1)
            {
                RenderDataGrid();
            }
        }

        private void bookDTPicker_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (facilityTypeCombo.SelectedIndex != -1)
                {
                    RenderDataGrid();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void FacilityAvailabiltyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
