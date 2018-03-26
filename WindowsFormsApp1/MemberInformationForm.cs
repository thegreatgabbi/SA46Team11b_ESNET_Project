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
    //Written Code By Su Su (e0284029)

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
            memGridView.Columns["Bookings"].Visible = false;
;        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            int length = searchMemberTextBox.TextLength;
            string membertext = (searchMemberTextBox.Text).Trim();
            var q = from x in context.Members
                    where ((x.MemberName.Substring(0, length) == membertext) ||
                          (x.MemberID.ToString().Substring(0, length) == searchMemberTextBox.Text) ||
                          (x.ICNumber.Substring(0, length) == membertext) ||
                          (x.Address.Substring(0, length) == membertext) ||
                          (x.EmailAddress.Substring(0, length) == membertext) ||
                          (x.Postcode.Substring(0, length) == membertext) ||
                          (x.ContactNumber.Substring(0, length) == membertext) ||
                          (x.Country.Substring(0, length) == membertext) ||
                          (x.Gender.Substring(0, length) == membertext))

                    select x;
            memGridView.DataSource = q.ToList();
        }

        private void addNewMemButton_Click(object sender, EventArgs e)
        {
            NewMemberInformation nmf = new NewMemberInformation();
            nmf.ShowDialog();
            memGridView.DataSource = context.Members.ToList();
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
            comboBox1.Text = memGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
        }


        private bool NameCheck(string name)
        {
            foreach (char n in name)
            {
                if (Char.IsDigit(n))
                    return false;
                else
                    return true;
            }
            return false;
        }

        private bool GoValidation()
        {
            if (memberNameTextBox.Text == String.Empty || ICnumberTextBox.Text == String.Empty
                || addressTextBox.Text == String.Empty || countryTextBox.Text == String.Empty
                || postalTextBox.Text == String.Empty || contactNumTextbox.Text == String.Empty
                || emailTextBox.Text == String.Empty || comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Please Fill Completely", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (NameCheck(memberNameTextBox.Text) == false)
            {
                MessageBox.Show("Digits are not allowed for name!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!this.emailTextBox.Text.Contains('@') || !this.emailTextBox.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.contactNumTextbox.Text.Length < 9)
            {
                MessageBox.Show("Please Enter A Valid Phone Number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.postalTextBox.Text.Length != 6)
            {
                MessageBox.Show("Please Enter A Valid Postal Code", "Invalid Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void updateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GoValidation() == false)
            {
                return;
            }
            else
            {
                if (memberIDTextBox.Text != "" & memberNameTextBox.Text != "" & ICnumberTextBox.Text != "" & addressTextBox.Text != ""
                & countryTextBox.Text != "" & postalTextBox.Text != "" & contactNumTextbox.Text != "" & emailTextBox.Text != "" & comboBox1.Text != "")
                {
                    int i = Convert.ToInt16(memberIDTextBox.Text);
                    mList[posn].MemberID = i;
                    mList[posn].MemberName = memberNameTextBox.Text;
                    mList[posn].ICNumber = ICnumberTextBox.Text;
                    mList[posn].Address = addressTextBox.Text;
                    mList[posn].Country = countryTextBox.Text;
                    mList[posn].Postcode = postalTextBox.Text;
                    mList[posn].ContactNumber = contactNumTextbox.Text;
                    if (comboBox1.Text == "Female")
                    {
                        mList[posn].ContactTitle = "Ms";
                    }
                    else if(comboBox1.Text == "Male")
                    {
                        mList[posn].ContactTitle = "Mr";
                    }
                    mList[posn].DateofBirth = memberBDPicker.Value;
                    mList[posn].EmailAddress = emailTextBox.Text;
                    mList[posn].Gender = comboBox1.Text;

                }
                DialogResult res = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    context.SaveChanges();
                    MessageBox.Show("Update Success!");
                    FunctionRefresh();
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
                    comboBox1.Text = "";
                    posn = 0;
                }
            }
        }

        private void FunctionRefresh()
        {
            mList= context.Members.ToList();
            memGridView.DataSource = mList;
            memberIDTextBox.Text = "";
            memberNameTextBox.Text = "";
            ICnumberTextBox.Text = "";
            memberBDPicker.Value = DateTime.Today;
            addressTextBox.Text = "";
            countryTextBox.Text = "";
            postalTextBox.Text = "";
            contactNumTextbox.Text = "";
            emailTextBox.Text = "";
            comboBox1.Text = "";
            posn = 0;
        }


        private void Delete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Refresh();
           
            Member c = context.Members.Where(x => x.MemberID.ToString() == (memberIDTextBox.Text)).First();

            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                context.Members.Remove(c);
                context.SaveChanges();
               
                MessageBox.Show("Delete Success!");
                this.FunctionRefresh();
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
                comboBox1.Text = "";
                posn = 0;
            }
        }

        private void bookingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingInformationForm bi = new BookingInformationForm();
            bi.Show();
        }

        private void facilityInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityInformationForm fi = new FacilityInformationForm();
            fi.Show();
        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MemberInformationForm_Load(sender,e);
        }

        private void searchMemberTextBox_TextChanged(object sender, EventArgs e)
        {
           if( searchMemberTextBox.Text== String.Empty)
            {
                memGridView.DataSource = context.Members.ToList();
            }
        }
        private void PrintMembersList_Click(object sender, EventArgs e)
        {
            MemberList m = new MemberList();
            m.Show();
        }
        private void comboBoxMember_SelectedValueChanged(object sender, EventArgs e)
        {
            String gender = comboBox1.Text.ToString();
            if (gender == "Female")
            {
                comboBox1.Text = "Ms";
            }
            else if (gender == "Male")
            {
                comboBox1.Text = "Mr";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PrintMembers_Click(object sender, EventArgs e)
        {
            MemberList m = new MemberList();
            m.Show();
        }
    }
}
