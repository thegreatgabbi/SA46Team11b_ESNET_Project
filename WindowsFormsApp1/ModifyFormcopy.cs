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
        string facilityname;
        DateTime dateofbooking;
        int time,bookID;

        public ModifyForm(string facname,DateTime date,int bookingfrom)
        {
            InitializeComponent();
            facilityname = facname;
            dateofbooking = date;
            time = bookingfrom;

            // BookingDateDtTimePckr.MinDate = DateTime.Today; // FOR TESTING: uncomment this later
            BookingDateDtTimePckr.MaxDate = DateTime.Today.AddDays(60);
            BookingFromTime.CustomFormat = "hh:00 tt";
            BookingFromTime.Format = DateTimePickerFormat.Custom;
            BookingFromTime.ShowUpDown = true;
            BookingToTime.CustomFormat = "hh:00 tt";
            BookingToTime.Format = DateTimePickerFormat.Custom;
            BookingToTime.ShowUpDown = true;

        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            f = (from x in ctx.Facilities where (x.FacilityName == facilityname) select x).First();
            txtRoomName.Text = f.FacilityName;
            txtLocation.Text = f.Location;

            // get the booking ID
            bookID = Program.GetBookingID(dateofbooking, facilityname, time);

            b = (from x in ctx.Bookings where (x.BookingID == bookID) select x).First();
            MakeBookinglbl.Text = "Booking #" + b.BookingID;

            //Displays Bookings details for that Particular booking id
            BookingFromTime.Value = b.BookingDateFrom;
            BookingToTime.Value = b.BookingDateTo;
            BookingDateDtTimePckr.Value = dateofbooking;
            txtNoOfPax.Text = b.NumberofPax.ToString();
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

            b.BookingDateFrom = BookingDateDtTimePckr.Value.Date + BookingFromTime.Value.TimeOfDay;
            b.BookingDateTo = BookingDateDtTimePckr.Value.Date + BookingToTime.Value.TimeOfDay;
            b.MemberID = Int32.Parse(txtMemberID.Text);
            b.NumberofPax= Int32.Parse(txtNoOfPax.Text);

            ctx.SaveChanges();
            MessageBox.Show("Booking Timing Modified");
            DialogResult res = MessageBox.Show("Do you want to print a receipt?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Printing Receipt");
            }
            else
                this.Close();
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
      
    }
}
