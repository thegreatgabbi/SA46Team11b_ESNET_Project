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
        DateTime bookingDateFrom;
        int time, flag = 0, fl = 0;
        List<Booking> bList;

        // opening hours of gym
        TimeSpan fromts = new TimeSpan(7, 0, 0);
        TimeSpan tots = new TimeSpan(21, 0, 0);

        SembawangSportEntities ctx = new SembawangSportEntities();
        public MakeBookingForm() // called from Booking Information Form
        {
            InitializeComponent();

            fl = 1;
            time = 0;

            bookingDateFrom = DateTime.Today;

            BookingFromTime.CustomFormat = "hh:00 tt";
            BookingFromTime.Format = DateTimePickerFormat.Custom;
            BookingFromTime.ShowUpDown = true;

            BookingToTime.CustomFormat = "hh:00 tt";
            BookingToTime.Format = DateTimePickerFormat.Custom;
            BookingToTime.ShowUpDown = true;
        }
        public MakeBookingForm(string facname, DateTime date, int bookingfrom) // Called from Booking Availability Form
        {
            InitializeComponent();
            facilityname = facname;
            BookingDateDtTimePckr.MinDate = DateTime.Today; // FOR TESTING: uncomment this later
            //BookingDateDtTimePckr.MaxDate = DateTime.Today.AddDays(30);

            // choose the correct item in the facility List
            facilityList.SelectedIndex = facilityList.FindStringExact(facname);
            time = bookingfrom;
            // prep Booking From Time
            BookingFromTime.CustomFormat = "hh:00 tt";
            BookingFromTime.Format = DateTimePickerFormat.Custom;
            BookingFromTime.ShowUpDown = true;
            // prep Booking To Time
            BookingToTime.CustomFormat = "hh:00 tt";
            BookingToTime.Format = DateTimePickerFormat.Custom;
            BookingToTime.ShowUpDown = true;

            // is date of booking earlier than today?
            int result = DateTime.Compare(date, DateTime.Today);

            if (result == -1)
            {
                MessageBox.Show("Booking date cannot be earlier than Today");
                flag = 1;
            }
            else
            {
                bookingDateFrom = date.Date;
                BookingDateDtTimePckr.Value = date;
            }

        }

        private void MakeBookingForm_Load(object sender, EventArgs e)
        {
            if (flag == 1) // if booking date is earlier than today
            {
                this.Close();
                return;
            }

            bList = ctx.Bookings.ToList();

            TimeSpan ts = new TimeSpan(time, 0, 0);
            bookingDateFrom = bookingDateFrom + ts;
            BookingDateDtTimePckr.Value = bookingDateFrom.Date;
            if (fl == 1) // if called from Booking Information Form
            {
                txtLocation.ReadOnly = false;
            }
            else
            {
                // if called from Facility Availabilty form, populate fields
                f = (from x in ctx.Facilities where (x.FacilityName == facilityname) select x).First();
                facilityList.Text = f.FacilityName;
                txtLocation.Text = f.Location;
            }

            //Displays Bookings details for that Particular booking id

            if (flag == 0) // if called from facility availability form
            {
                BookingDateDtTimePckr.Value = DateTime.Today.Date;
            }
            BookingFromTime.Value = bookingDateFrom;
            BookingToTime.Value = BookingFromTime.Value.AddHours(1);

            //BookingFromTime.MinDate = BookingDateDtTimePckr.Value.Date + fromts;
           // BookingToTime.MaxDate = BookingDateDtTimePckr.Value.Date + tots;

            //load combobox items
            List<Facility> flist = ctx.Facilities.ToList();
            
            foreach (Facility x in flist)
            {
                facilityList.Items.Add(x.FacilityName);
            }
        }

        private void FunctionRefresh()
        {
            bList = ctx.Bookings.ToList();
            
        }

        private void Okbtn_Click_1(object sender, EventArgs e)
        {
            BookingFromTime.MinDate = BookingDateDtTimePckr.Value.Date + fromts;
            BookingToTime.MaxDate = BookingDateDtTimePckr.Value.Date + tots;

            // convert booking date from 
            int BookingTimeFrom = BookingFromTime.Value.Hour;
            int BookingTimeTo = BookingToTime.Value.Hour;
            DateTime bkgdt = BookingFromTime.Value.Date;
            bool value;

            TimeSpan s = new TimeSpan(BookingTimeTo, 0, 0);
            TimeSpan t = new TimeSpan(BookingTimeFrom, 0, 0);
            BookingToTime.Value = BookingDateDtTimePckr.Value.Date + s;
            BookingFromTime.Value = BookingDateDtTimePckr.Value.Date + t;

            
            //assign f according to facility booked.
            f = ctx.Facilities.Where(x => x.FacilityName == facilityList.Text).First();

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
                    BookingReceipt br = new BookingReceipt(b.BookingID); 
                    br.ShowDialog();
                    Close();
                }
                else
                {
                    Close();
                }
                if (refToAvailabiltyForm != null)
                {
                    refToAvailabiltyForm.RenderDataGrid();
                }
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

        private void facilityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Facility F;
            F = ctx.Facilities.Where(x => x.FacilityName == facilityList.SelectedItem.ToString()).First();
            txtLocation.Text = F.Location;
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
