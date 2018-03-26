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
    
    public partial class ModifyForm : Form
    {   
        SembawangSportEntities ctx = new SembawangSportEntities();
        Facility f;
        public ModifyForm()
        {
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            MakeBookinglbl.Text = "Booking #" + "";

            Booking b = (from x in ctx.Bookings where (x.BookingID == 40) select x).First();

            //Displays Bookings details for that Particular booking id
            BookingFromTime.Value = b.BookingDateFrom;
            BookingToTime.Value = b.BookingDateTo;
            BookingDateDtTimePckr.Value = b.BookingDateFrom;

            //Customizes booking date from and to into date and time format
            BookingDateDtTimePckr.MinDate = DateTime.Today;
            BookingDateDtTimePckr.MaxDate = DateTime.Today.AddDays(60);
            BookingFromTime.CustomFormat = "hh:00 tt";
            BookingFromTime.Format = DateTimePickerFormat.Custom;
            BookingFromTime.ShowUpDown = true;
            BookingToTime.CustomFormat = "hh:00 tt";
            BookingToTime.Format = DateTimePickerFormat.Custom;
            BookingToTime.ShowUpDown = true;

            //Displays facilities details for that booking
            f = (from x in ctx.Facilities where (x.FacilityID == b.FacilitiesID) select x).First();
            txtRoomName.Text = f.FacilityName;
            txtLocation.Text = f.Location;
        }

        private void LookUpBtn_Click(object sender, EventArgs e)
        {
            MemberForm mForm = new MemberForm(this);
            mForm.Show();
        }


        private void Modifybtn_Click(object sender, EventArgs e)
        {

            BookingFromTime.Value= new DateTime(BookingDateDtTimePckr.Value.Year, BookingDateDtTimePckr.Value.Month, BookingDateDtTimePckr.Value.Day,
             BookingFromTime.Value.Hour, 00, 00);

            BookingToTime.Value = new DateTime(BookingDateDtTimePckr.Value.Year, BookingDateDtTimePckr.Value.Month, BookingDateDtTimePckr.Value.Day,
            BookingToTime.Value.Hour, 00, 00);

            Booking b = (from x in ctx.Bookings where (x.BookingID == 41) select x).First();

            b.BookingDateFrom = BookingDateDtTimePckr.Value.Date + BookingFromTime.Value.TimeOfDay;
            b.BookingDateTo = BookingDateDtTimePckr.Value.Date + BookingToTime.Value.TimeOfDay;
            b.MemberID = Int32.Parse(txtMemberID.Text);
            b.NumberofPax= Int32.Parse(txtNoOfPax.Text);

            ctx.SaveChanges();
            MessageBox.Show("Booking Timing Modified");
            this.Close();
        }

        private void DeleteBookingbtn_Click(object sender, EventArgs e)
        {
            Booking b = (from x in ctx.Bookings where (x.BookingID == 41) select x).First();

            ctx.Bookings.Remove(b);

            ctx.SaveChanges();
            MessageBox.Show("Deleted Booking #");
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            BookingReceipt br = new BookingReceipt();
            br.Show();
        }
    }
}
