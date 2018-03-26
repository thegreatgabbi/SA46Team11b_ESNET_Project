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
    public partial class MakeBookingForm : Form
    {
        Facility f;
        Booking b,b1;
        Member m;
       
       SembawangSportEntities ctx = new SembawangSportEntities();
        public MakeBookingForm()
        {
            InitializeComponent();
            BookingDateDtTimePckr.MinDate = DateTime.Today;
            BookingDateDtTimePckr.MaxDate = DateTime.Today.AddDays(60);
            BookingFromTime.CustomFormat = "hh:00 tt";
            BookingFromTime.Format = DateTimePickerFormat.Custom;
            BookingFromTime.ShowUpDown = true;
            BookingToTime.CustomFormat = "hh:00 tt";
            BookingToTime.Format = DateTimePickerFormat.Custom;
            BookingToTime.ShowUpDown = true;

            //Displays facilities details for that booking
            f = (from x in ctx.Facilities where (x.FacilityName =="Badminton Court 4") select x).First();
            txtRoomName.Text = f.FacilityName;
            txtLocation.Text = f.Location;
            b = (from x in ctx.Bookings select x).First();
            BookingFromTime.Value = b.BookingDateFrom;
            BookingToTime.Value = b.BookingDateTo;
            BookingDateDtTimePckr.Value = b.BookingDateFrom;
         }

        private void PopulateText()
        {
            m = (from x in ctx.Members where x.MemberID.ToString() == txtMemberID.Text select x).First();
            txtMemberID.Text = m.MemberID.ToString();
            txtMemberName.Text = m.MemberName;
         }

        private void LookUpBtn_Click_1(object sender, EventArgs e)
        {
            MemberForm mForm = new MemberForm(this,f);
            mForm.Show();
        }

        
        private void txtMemberID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PopulateText();
             }
        }

        private void Okbtn_Click_1(object sender, EventArgs e)
        {
            BookingFromTime.Value = new DateTime(BookingDateDtTimePckr.Value.Year, BookingDateDtTimePckr.Value.Month, BookingDateDtTimePckr.Value.Day,
             BookingFromTime.Value.Hour, 00, 00);

            BookingToTime.Value = new DateTime(BookingDateDtTimePckr.Value.Year, BookingDateDtTimePckr.Value.Month, BookingDateDtTimePckr.Value.Day,
            BookingToTime.Value.Hour, 00, 00);

            b1 = new Booking();
            int count = ctx.Bookings.Count();
            count++;
            b1.BookingID = count;
            b1.BookingDateFrom = BookingFromTime.Value;
            //BookingDateDtTimePckr.Value.Date + BookingFromTime.Value.TimeOfDay;
            b1.BookingDateTo = BookingToTime.Value;
            //BookingDateDtTimePckr.Value.Date + BookingToTime.Value.TimeOfDay;
            f = (from x in ctx.Facilities where (x.FacilityName == "Badminton Court 4") select x).First();
            b1.FacilitiesID = f.FacilityID;
            b1.MemberID = Int32.Parse(txtMemberID.Text);
            b1.IssueDate = DateTime.Today;
            b1.NumberofPax = Int32.Parse(txtNoOfpax.Text);
            
            ctx.Bookings.Add(b1);

            ctx.SaveChanges();
     
            MessageBox.Show("Booking Saved");
            this.Close();
        }

       

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
