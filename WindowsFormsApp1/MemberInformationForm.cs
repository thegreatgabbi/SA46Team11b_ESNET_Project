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
    public partial class MemberInformationForm : Form
    {
        SembawangSportEntities context = new SembawangSportEntities();
        List<Member> mList;
        int posn = 0;
        public MemberInformationForm()
        {
            InitializeComponent();
        }

        private void MemberInformationForm_Load(object sender, EventArgs e)
        {
            mList = context.Members.ToList();
            memGridView.DataSource = mList;
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            SearchMember();
        }

        private void addNewMemButton_Click(object sender, EventArgs e)
        {
            NewMemberInformation nmf = new NewMemberInformation();
            nmf.Show();
        }

        private void SearchMember()
        {
            int length = searchMemberTextBox.TextLength;
            string membertext = (searchMemberTextBox.Text).Trim();
            var q = from x in context.Members
                    where ((x.MemberName.Substring(0, length) == membertext) ||
                          (x.MemberID.ToString().Substring(0, length) == searchMemberTextBox.Text) ||
                          (x.ICNumber.Substring(0, length) == membertext) ||
                          (x.Address.Substring(0,length)==membertext)||
                          (x.EmailAddress.Substring(0, length) == membertext) ||
                          (x.Postcode.Substring(0, length) == membertext) ||
                          (x.ContactNumber.Substring(0, length) == membertext) ||
                          (x.Country.Substring(0, length) == membertext)||
                          (x.Gender.Substring(0,length)==membertext))

                    select x;
            memGridView.DataSource = q.ToList();
        }

        private void memGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posn = e.RowIndex;
           memberIDTextBox.Text = memGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
           memberNameTextBox.Text = memGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ICnumberTextBox.Text = memGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            memberBDPicker.Value = (DateTime)memGridView.Rows[e.RowIndex].Cells[3].Value;
            addressTextBox.Text = memGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            countryTextBox.Text = memGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            postalTextBox.Text = memGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            contactNumTextbox.Text = memGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            emailTextBox.Text = memGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            genderTextBox.Text = memGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void updateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (memberIDTextBox.Text != "" & memberNameTextBox.Text != "" & ICnumberTextBox.Text != "" & addressTextBox.Text != "" 
                & countryTextBox.Text != "" & postalTextBox.Text != "" & contactNumTextbox.Text!="" & emailTextBox.Text!="" & genderTextBox.Text!="")
            {
                //MessageBox.Show(posn.ToString());
                int i = Convert.ToInt16(memberIDTextBox.Text);
                mList[posn].MemberID = i;
                mList[posn].MemberName = memberNameTextBox.Text;
                mList[posn].ICNumber = ICnumberTextBox.Text;
                mList[posn].Address = addressTextBox.Text;
                mList[posn].Country = countryTextBox.Text;
                mList[posn].Postcode = postalTextBox.Text;
                mList[posn].ContactNumber = contactNumTextbox.Text;
                mList[posn].DateofBirth = memberBDPicker.Value;
                mList[posn].EmailAddress = emailTextBox.Text;
                mList[posn].Gender = genderTextBox.Text;

            }
            DialogResult res = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                context.SaveChanges();
                MessageBox.Show("Update Success!");
                memGridView.DataSource = mList;
            }
            if (res == DialogResult.Cancel)
            {
                memberIDTextBox.Text = "";
                memberNameTextBox.Text = "";
                ICnumberTextBox.Text = "";
                memberBDPicker.Value = DateTime.Today;
                addressTextBox.Text = "";
                countryTextBox.Text = "";
                postalTextBox.Text = "";
                contactNumTextbox.Text = "";
                emailTextBox.Text = "";
                genderTextBox.Text = "";
                posn = 0;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(posn.ToString());
            int currentRow = posn;
            Member m = mList[currentRow];
            context.Members.Remove(m);
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                context.SaveChanges();
                MessageBox.Show("Delete Success!");
                  
            }
            if (res == DialogResult.Cancel)
            {
                memberIDTextBox.Text = "";
                memberNameTextBox.Text = "";
                ICnumberTextBox.Text = "";
                memberBDPicker.Value = DateTime.Today;
                addressTextBox.Text = "";
                countryTextBox.Text = "";
                postalTextBox.Text = "";
                contactNumTextbox.Text = "";
                emailTextBox.Text = "";
                genderTextBox.Text = "";
                posn = 0;
            }
        }
    }
}
