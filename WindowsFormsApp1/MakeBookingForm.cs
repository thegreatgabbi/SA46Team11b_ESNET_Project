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
        SembawangSportEntities ctx = new SembawangSportEntities();
        public MakeBookingForm()
        {
            InitializeComponent();
        }

        private void MakeBookingForm_Load(object sender, EventArgs e)
        {

        }

        private void LookUpBtn_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Okbtn_Click(object sender, EventArgs e)
        {

        }

        private void LookUpBtn_Click_1(object sender, EventArgs e)
        {
            MemberForm mForm = new MemberForm(this);
            mForm.Show();
        }

        private void Displaygrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void MakeBookingForm_Load_1(object sender, EventArgs e)
        {

        }

        private void txtMemberID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {   
                // Retrieving Member's details for that particular member Id
                Member m = (from x in ctx.Members where x.MemberID.ToString() == txtMemberID.Text select x).First();
                // Retrieving Booking details for that member Id
                Booking b = (from x in ctx.Bookings where x.MemberID.ToString() == txtMemberID.Text select x).First();
                //Retrieving Facility details for that Booking Id
                Facility f= (from x in ctx.Facilities where x.FacilityID == b.FacilitiesID select x).First();
                txtMemberID.Text = m.MemberID.ToString();
                txtMemberName.Text = m.MemberName;
                string theDate = b.BookingDateFrom.ToString("yyyy-MM-dd");
                txtBookingDate.Text = theDate;
                BookingFromTime.Format = DateTimePickerFormat.Custom;
                BookingFromTime.CustomFormat = "HH:mm tt";
                BookingFromTime.Value = b.BookingDateFrom;
                BookingToTime.Format = DateTimePickerFormat.Custom;
                BookingToTime.CustomFormat= "HH:mm tt";
                BookingToTime.Value = b.BookingDateTo;
                txtRoomName.Text = f.FacilityName;
                txtLocation.Text = f.Location;
             }
        }

        private void Okbtn_Click_1(object sender, EventArgs e)
        {
            Booking b = (from x in ctx.Bookings where x.MemberID.ToString() == txtMemberID.Text select x).First();
            b.BookingDateFrom= BookingFromTime.Value;
            b.BookingDateTo= BookingToTime.Value;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
