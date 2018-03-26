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
    public partial class ModifyForm : Form
    {
        public FacilityAvailabiltyForm refToAvailabiltyForm;

        Facility f;
        Booking b;
        Member m;
        string facilityname;
        DateTime dateofbooking;
        int time,bookID,flag=0;
        
        TimeSpan fromts = new TimeSpan(7, 0, 0);
        TimeSpan tots = new TimeSpan(21, 0, 0);

        SembawangSportEntities ctx = new SembawangSportEntities();

        public ModifyForm(string facname,DateTime date,int bookingfrom)
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

            int result = DateTime.Compare(dateofbooking, DateTime.Today);
            if (result < 0)
            {
                MessageBox.Show("Booking date cannot be earlier than Today");
                flag = 1;
            }
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            if (flag == 1)
                this.Close();
            f = (from x in ctx.Facilities where (x.FacilityName == facilityname) select x).First();
            txtRoomName.Text = f.FacilityName;
            txtLocation.Text = f.Location;

            // get the booking ID
            bookID = Program.GetBookingID(dateofbooking, facilityname, time);

            b = (from x in ctx.Bookings where (x.BookingID == bookID) select x).First();
            MakeBookinglbl.Text = "Booking #" + b.BookingID;

            m = (from x in ctx.Members where (x.MemberID == b.MemberID) select x).First();
            txtMemberID.Text = m.MemberID.ToString();
            txtMemberName.Text = m.MemberName;

            txtNoOfPax.Text = b.NumberofPax.ToString();

            //Displays Bookings details for that Particular booking id
            BookingFromTime.Value = b.BookingDateFrom;
            BookingToTime.Value = b.BookingDateTo;
            if(flag!=1)
                BookingDateDtTimePckr.Value = dateofbooking;
            BookingFromTime.MinDate = BookingDateDtTimePckr.Value.Date + fromts;
            BookingToTime.MaxDate = BookingDateDtTimePckr.Value.Date + tots;
        }
        
        private void Modifybtn_Click(object sender, EventArgs e)
        {

            BookingFromTime.Value= new DateTime(BookingDateDtTimePckr.Value.Year, BookingDateDtTimePckr.Value.Month, BookingDateDtTimePckr.Value.Day,
            BookingFromTime.Value.Hour, 00, 00);

            BookingToTime.Value = new DateTime(BookingDateDtTimePckr.Value.Year, BookingDateDtTimePckr.Value.Month, BookingDateDtTimePckr.Value.Day,
            BookingToTime.Value.Hour, 00, 00);

            try
            {
            b.BookingDateFrom = BookingDateDtTimePckr.Value.Date + BookingFromTime.Value.TimeOfDay;
            b.BookingDateTo = BookingDateDtTimePckr.Value.Date + BookingToTime.Value.TimeOfDay;
            b.MemberID = Int32.Parse(txtMemberID.Text);
            b.NumberofPax= Int32.Parse(txtNoOfPax.Text);
            } catch (Exception ex) {
                MessageBox.Show("Please ensure that all fields are filled.");
                return;
            }

            // convert booking date from 
            int BookingTimeFrom = BookingFromTime.Value.Hour;
            int BookingTimeTo = BookingToTime.Value.Hour;
            DateTime bkgdt = BookingFromTime.Value.Date;
            bool value;

            //Checking whether slots are available
            value = Program.ValidateBooking(bkgdt, f.FacilityName, BookingTimeFrom, BookingTimeTo);
            if (value)
            {
                ctx.SaveChanges();
                MessageBox.Show("Booking Successfully Modified");

                DialogResult res = MessageBox.Show("Do you want to print a receipt?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("Printing Receipt");
                }
                Close();
                refToAvailabiltyForm.RenderDataGrid();

            } else {
                MessageBox.Show("Slot is not available");
            }
        }

        private void DeleteBookingbtn_Click(object sender, EventArgs e)
        {
            Booking b = (from x in ctx.Bookings where (x.BookingID == bookID) select x).First();

            ctx.Bookings.Remove(b);

            ctx.SaveChanges();
            MessageBox.Show("Deleted Booking #" + bookID);
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PopulateText()
        {
            m = (from x in ctx.Members where x.MemberID.ToString() == txtMemberID.Text select x).First();
            txtMemberID.Text = m.MemberID.ToString();
            txtMemberName.Text = m.MemberName;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing Receipt");
        }

        private void txtMemberID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PopulateText();
            }
        }

        private void LookUpBtn_Click(object sender, EventArgs e)
        {
            MemberForm mForm = new MemberForm(this);
            mForm.Show();
        }


    }
}
