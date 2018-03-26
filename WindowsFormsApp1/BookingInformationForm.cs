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
    //Written Code By Su Su (e0284029)

    public partial class BookingInformationForm : Form
    {
        SembawangSportEntities context = new SembawangSportEntities();
        List<Booking> bList;
        int posn = 0;
        
        public BookingInformationForm()
        {
            InitializeComponent();
        }

        private void BookingInformationForm_Load(object sender, EventArgs e)
        {
            bList = context.Bookings.ToList();
            bookingGridView.DataSource = bList;
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "HH:mm";
            dateTimePickerTo.CustomFormat = "HH:mm";
            //bookingGridView.Columns["Members"].Visible = false;
            //bookingGridView.Columns["Facilities"].Visible = false;
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            int length = searchBookingTextBox.TextLength;
            string membertext = (searchBookingTextBox.Text).Trim();
            var q= from x in context.Bookings
                    where (
                          (x.BookingID.ToString().Substring(0, length) == searchBookingTextBox.Text) ||
                          (x.Member.MemberName.Substring(0, length) == membertext) ||
                          (x.MemberID.ToString().Substring(0, length) == membertext) ||
                          (x.FacilitiesID.ToString().Substring(0, length) == membertext) ||
                          (x.Facility.FacilityName.Substring(0, length) == membertext) ||
                          (x.NumberofPax.ToString().Substring(0, length) == membertext))

                    select x;
            
            bookingGridView.DataSource = q.ToList();
        }

        private void bookingGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = int.Parse(bookingGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            int b = int.Parse(bookingGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            Member m = context.Members.Where(x => x.MemberID == a).First();
            Facility f = context.Facilities.Where(x => x.FacilityID == b).First();
            posn = e.RowIndex;
            BookingIDTextBox.Text = bookingGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            BookingDatePicker.Value = (DateTime)bookingGridView.Rows[e.RowIndex].Cells[1].Value;
            memberIDTextBox.Text = bookingGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            memberNameTextBox.Text = m.MemberName;
            facilityNameTextBox.Text = f.FacilityName;
            locationTextBox.Text = f.Location;
            dateTimePickerFrom.Value = (DateTime)bookingGridView.Rows[e.RowIndex].Cells[4].Value;
            dateTimePickerTo.Value = (DateTime)bookingGridView.Rows[e.RowIndex].Cells[5].Value;
            numOfPaxTextBox.Text = bookingGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void updateBooking_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (numOfPaxTextBox .Text != "")
            {
                MessageBox.Show(posn.ToString());
                int i = Convert.ToInt16(memberIDTextBox.Text);
                //bList[posn].BookingID = i;
                bList[posn].IssueDate = BookingDatePicker.Value;
                //bList[posn].MemberID = int.Parse(memberIDTextBox.Text);
               // bList[posn].FacilitiesID = int.Parse(bookingGridView.Rows[posn].Cells[3].Value.ToString());
                bList[posn].BookingDateFrom = dateTimePickerFrom.Value;
                bList[posn].BookingDateTo = dateTimePickerTo.Value;
                bList[posn].NumberofPax = int.Parse(numOfPaxTextBox.Text);
            }
            DialogResult res = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                context.SaveChanges();
                MessageBox.Show("Update Success!");
                this.Refresh();
                bookingGridView.DataSource = bList;
            }
            if (res == DialogResult.Cancel)
            {
                BookingIDTextBox.Text = "";
                memberNameTextBox.Text = "";
                memberIDTextBox.Text = "";
                facilityNameTextBox.Text = "";
                locationTextBox.Text = "";
                numOfPaxTextBox.Text = "";
                BookingDatePicker.Value = DateTime.Today;
                dateTimePickerTo.Value = DateTime.Today;
                dateTimePickerFrom.Value = DateTime.Today;
                posn = 0;
            }
        }

        private void DeleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show(posn.ToString());
            int currentRow = posn;
            Booking b = bList[currentRow];
            context.Bookings.Remove(b);
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                context.SaveChanges();
                MessageBox.Show("Delete Success!");
                this.Refresh();
                bookingGridView.DataSource = bList;
            }
            if (res == DialogResult.Cancel)
            {
                BookingIDTextBox.Text = "";
                memberNameTextBox.Text = "";
                memberIDTextBox.Text = "";
                facilityNameTextBox.Text = "";
                locationTextBox.Text = "";
                numOfPaxTextBox.Text = "";
                BookingDatePicker.Value = DateTime.Today;
                dateTimePickerTo.Value = DateTime.Today;
                dateTimePickerFrom.Value = DateTime.Today;
                posn = 0;
            }
        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberInformationForm mif = new MemberInformationForm();
            mif.Show();
        }

        private void facilityInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityInformationForm fif = new FacilityInformationForm();
            fif.Show();
        }

        private void bookingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BookingInformationForm_Load(sender,e);
        }
    }
}
