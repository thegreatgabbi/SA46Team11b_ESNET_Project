using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BookingForm
    {
        SembawangSportEntities ctx = new SembawangSportEntities();
        Member m;
        Booking b1;
        Facility fa;
        MakeBookingForm form;
        //ModifyForm form1;


        public BookingForm(MakeBookingForm f)
        {
            form = f;
            //BookingDateDtTimePckr.MinDate = DateTime.Today;
            form.BookingDateDtTimePckr.MaxDate = DateTime.Today.AddDays(60);
            form.BookingFromTime.CustomFormat = "hh:00 tt";
           // form.BookingFromTime.Format = DateTimePickerFormat.Custom;
            form.BookingFromTime.ShowUpDown = true;
            form.BookingToTime.CustomFormat = "hh:00 tt";
           // form.BookingToTime.Format = DateTimePickerFormat.Custom;
            form.BookingToTime.ShowUpDown = true;
        }
        public void PopulateText()
        {
            m = (from x in ctx.Members where x.MemberID.ToString() == form.txtMemberID.Text select x).First();
            form.txtMemberID.Text = m.MemberID.ToString();
            form.txtMemberName.Text = m.MemberName;
        }

        public void Create()
        {
            form.BookingFromTime.Value = new DateTime(form.BookingDateDtTimePckr.Value.Year, form.BookingDateDtTimePckr.Value.Month, form.BookingDateDtTimePckr.Value.Day,
            form.BookingFromTime.Value.Hour, 00, 00);

            form.BookingToTime.Value = new DateTime(form.BookingDateDtTimePckr.Value.Year, form.BookingDateDtTimePckr.Value.Month, form.BookingDateDtTimePckr.Value.Day,
            form.BookingToTime.Value.Hour, 00, 00);

            b1 = new Booking();
            int count = ctx.Bookings.Count();
            count++;
            b1.BookingID = count;
            b1.BookingDateFrom = form.BookingFromTime.Value;
            //BookingDateDtTimePckr.Value.Date + BookingFromTime.Value.TimeOfDay;
            b1.BookingDateTo = form.BookingToTime.Value;
            //BookingDateDtTimePckr.Value.Date + BookingToTime.Value.TimeOfDay;
            fa = (from x in ctx.Facilities where (x.FacilityName == "Badminton Court 4") select x).First();
            b1.FacilitiesID = fa.FacilityID;
            b1.MemberID = Int32.Parse(form.txtMemberID.Text);
            b1.IssueDate = DateTime.Today;
            b1.NumberofPax = Int32.Parse(form.txtNoOfpax.Text);

            ctx.Bookings.Add(b1);

            ctx.SaveChanges();
         
        }
    }
}

