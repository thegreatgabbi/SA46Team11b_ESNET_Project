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
        MakeBookingForm form;
        SembawangSportEntities ctx = new SembawangSportEntities();
        public MemberForm(MakeBookingForm f)
        {
            InitializeComponent();
            form = f;
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

        private void BookingTolbl_Click(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOBlbl_Click(object sender, EventArgs e)
        {

        }

        private void Emaillbl_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MemberdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MemberdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMemberID.Text = MemberdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtMemberName.Text = MemberdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtICNumber.Text = MemberdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtDOB.Text = MemberdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtAddress.Text = MemberdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtCountry.Text = MemberdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            //txtPostalCode.Text = MemberdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            //txtPhoneNumber.Text = MemberdataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            //txtEmail.Text = MemberdataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            //txtGender.Text = MemberdataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            MessageBox.Show("Hello");
        }

        private void Searchbtn_MouseClick(object sender, MouseEventArgs e)
        {
            int length = txtMemberSearch.TextLength;
            var q = from x in ctx.Members where ((x.MemberName.Substring(0, length) == txtMemberSearch.Text) ||
                                                (x.MemberID.ToString().Substring(0, length) == txtMemberSearch.Text) ||
                                                (x.ICNumber.Substring(0, length) == txtMemberSearch.Text)||
                                                (x.EmailAddress.Substring(0, length) == txtMemberSearch.Text)||
                                                (x.Postcode.Substring(0, length) == txtMemberSearch.Text)||
                                                (x.ContactNumber.Substring(0, length) == txtMemberSearch.Text)||
                                                (x.Country.Substring(0, length) == txtMemberSearch.Text)) select x;
            MemberdataGridView.DataSource = q.ToList();
        }

        private void MemberdataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
