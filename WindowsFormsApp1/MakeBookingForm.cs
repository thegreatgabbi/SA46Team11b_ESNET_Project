using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGenerator;

namespace WindowsFormsApp1
{
    public partial class MakeBookingForm : Form
    {
        public FacilityAvailabilityForm refToAvailabiltyForm;

        Facility f;
        Booking b;
        Member m;
        string facilityname;
        DateTime dateofbooking,bookingDateFrom;
        int time, flag = 0, fl = 0;
        List<Booking> bList;

        TimeSpan fromts = new TimeSpan(7, 0, 0);
        TimeSpan tots = new TimeSpan(21, 0, 0);

        SembawangSportEntities ctx = new SembawangSportEntities();
        public MakeBookingForm()
        {
            InitializeComponent();
            fl = 1;
            dateofbooking = DateTime.Today;
            bookingDateFrom = dateofbooking;


            BookingFromTime.CustomFormat = "hh:00 tt";
            BookingFromTime.Format = DateTimePickerFormat.Custom;
            BookingFromTime.ShowUpDown = true;

            BookingToTime.CustomFormat = "hh:00 tt";
            BookingToTime.Format = DateTimePickerFormat.Custom;
            BookingToTime.ShowUpDown = true;
        }
        public MakeBookingForm(string facname, DateTime date, int bookingfrom)
        {
            InitializeComponent();
            facilityname = facname;
            dateofbooking = date;
            time = bookingfrom;

            BookingDateDtTimePckr.MinDate = DateTime.Today; // FOR TESTING: uncomment this later
            BookingDateDtTimePckr.MaxDate = DateTime.Today.AddDays(30);

            BookingFromTime.CustomFormat = "hh:00 tt";
            BookingFromTime.Format = DateTimePickerFormat.Custom;
            BookingFromTime.ShowUpDown = true;

            BookingToTime.CustomFormat = "hh:00 tt";
            BookingToTime.Format = DateTimePickerFormat.Custom;
            BookingToTime.ShowUpDown = true;

            TimeSpan ts = new TimeSpan(time, 0, 0);
            bookingDateFrom = dateofbooking + ts;

            int result = DateTime.Compare(dateofbooking, DateTime.Today);
            if (result < 0)
            {
                MessageBox.Show("Booking date cannot be earlier than Today");
                flag = 1;
            }

        }


        private void MakeBookingForm_Load(object sender, EventArgs e)
        {
            if (flag == 1)
                this.Close();
            bList = ctx.Bookings.ToList();
            if (fl == 1)
            {
                txtRoomName.ReadOnly = false;
                txtLocation.ReadOnly = false;
            }
            else
            {
                //Displays facilities details
                f = (from x in ctx.Facilities where (x.FacilityName == facilityname) select x).First();
                txtRoomName.Text = f.FacilityName;
                txtLocation.Text = f.Location;
            }

            //Displays Bookings details for that Particular booking id
           
            if (flag == 0)
            {
                BookingDateDtTimePckr.Value = dateofbooking;
            }
            // MessageBox.Show(bookingDateFrom.ToString()); // For testing
            BookingFromTime.Value = bookingDateFrom;
            BookingToTime.Value = bookingDateFrom.AddHours(1);
            
            BookingFromTime.MinDate = BookingDateDtTimePckr.Value.Date + fromts;
            BookingToTime.MaxDate = BookingDateDtTimePckr.Value.Date + tots;
        }

        private void FunctionRefresh()
        {
            bList = ctx.Bookings.ToList();
            
        }

        private void Okbtn_Click_1(object sender, EventArgs e)
        {
            BookingFromTime.Value = new DateTime(BookingDateDtTimePckr.Value.Year, BookingDateDtTimePckr.Value.Month, BookingDateDtTimePckr.Value.Day,
             BookingFromTime.Value.Hour, 00, 00);

            BookingToTime.Value = new DateTime(BookingDateDtTimePckr.Value.Year, BookingDateDtTimePckr.Value.Month, BookingDateDtTimePckr.Value.Day,
            BookingToTime.Value.Hour, 00, 00);

            b = new Booking();
            // table values

            try
            {
                b.BookingID = bList[bList.Count - 1].BookingID + 1;
                b.BookingDateFrom = BookingFromTime.Value;
                b.BookingDateTo = BookingToTime.Value;
                b.FacilitiesID = f.FacilityID;
                b.MemberID = Int32.Parse(txtMemberID.Text);
                b.IssueDate = DateTime.Today;
                b.NumberofPax = Int32.Parse(txtNoOfPax.Text);
            }
            catch
            {
                MessageBox.Show("Please ensure all fields are filled.");
                return;
            }

            // convert booking date from 
            int BookingTimeFrom = BookingFromTime.Value.Hour;
            int BookingTimeTo = BookingToTime.Value.Hour;
            DateTime bkgdt = BookingFromTime.Value.Date;
            bool value;

            // check if 
            value = Program.ValidateBooking(bkgdt, f.FacilityName, BookingTimeFrom, BookingTimeTo);

            if (value)
            {
                ctx.Bookings.Add(b);
                ctx.SaveChanges();
                MessageBox.Show("Booking Successfully Saved");
                FunctionRefresh();
                DialogResult res = MessageBox.Show("Do you want to print a receipt?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    BookingReceipt br = new BookingReceipt(b.BookingID); // TODO: to provide arguments
                    br.ShowDialog();
                }
                Close();
                refToAvailabiltyForm.RenderDataGrid();
            }
            else
            {
                MessageBox.Show("Slot is not available");
            }
        }



        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LookUpBtn_Click_1(object sender, EventArgs e)
        {
            MemberForm mForm = new MemberForm(this, f);
            mForm.ShowDialog();
        }

        private void PopulateText()
        {
            m = (from x in ctx.Members where x.MemberID.ToString() == txtMemberID.Text select x).First();
            txtMemberID.Text = m.MemberID.ToString();
            txtMemberName.Text = m.MemberName;
        }

        private void txtMemberID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PopulateText();
            }
        }
    }
}
