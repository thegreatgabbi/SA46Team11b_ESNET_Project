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
    public partial class MemberForm : Form
    {
        MakeBookingForm bkgform;
        ModifyForm mdyform;
        Facility fac;
        int i;
        SembawangSportEntities ctx = new SembawangSportEntities();
        //To populate member records in the gridbox
        private void PopulateText()
        {
            int length = txtMemberSearch.TextLength;
            string membertext = (txtMemberSearch.Text).Trim();
            var q = from x in ctx.Members
                    where ((x.MemberName.Substring(0, length) == membertext) ||
                          (x.MemberID.ToString().Substring(0, length) == txtMemberSearch.Text) ||
                          (x.ICNumber.Substring(0, length) == membertext) ||
                          (x.EmailAddress.Substring(0, length) == membertext) ||
                          (x.Postcode.Substring(0, length) == membertext) ||
                          (x.ContactNumber.Substring(0, length) == membertext) ||
                          (x.Country.Substring(0, length) == membertext))
                    select x;
            MemberdataGridView.DataSource = q.ToList();
        }

       
        public MemberForm(MakeBookingForm f,Facility fa)
        {
            InitializeComponent();
            bkgform = f;
            fac = fa;
            i = 0;
        }

        public MemberForm(ModifyForm f)
        {
            InitializeComponent();
            mdyform = f;
            i = 1;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sembawangSportDataSet1.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter1.Fill(this.sembawangSportDataSet1.Members);
            // TODO: This line of code loads data into the 'sembawangSportDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.sembawangSportDataSet.Members);
            var q = from x in ctx.Members select x;
            MemberdataGridView.DataSource = q.ToList();

        }

        
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Searchbtn_MouseClick(object sender, MouseEventArgs e)
        {
            PopulateText();
        }

       
        private void Searchbtn_KeyUp(object sender, KeyEventArgs e)
        {
            PopulateText();
        }

        private void MemberdataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string datetoint;
            int spaceIndex;

            MemberdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            txtMemberID.Text = MemberdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMemberName.Text = MemberdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtICNumber.Text = MemberdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            datetoint = MemberdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            spaceIndex = datetoint.IndexOf(" ", 0);
            txtDOB.Text = datetoint.Substring(0, spaceIndex);
            txtAddress.Text = MemberdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCountry.Text = MemberdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPostalCode.Text = MemberdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPhoneNumber.Text = MemberdataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEmail.Text = MemberdataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtGender.Text = MemberdataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {   
                 
            
            if (i == 0)
            {
                bkgform.txtMemberID.Text = txtMemberID.Text;
                bkgform.txtMemberName.Text = txtMemberName.Text;
            }
            else
            {
                mdyform.txtMemberID.Text = txtMemberID.Text;
                mdyform.txtMemberName.Text = txtMemberName.Text;
            }

            this.Close();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
