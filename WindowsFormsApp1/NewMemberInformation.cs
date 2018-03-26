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

    public partial class NewMemberInformation : Form
    {
        SembawangSportEntities context = new SembawangSportEntities();
        List<Member> mList;
        int posn;

        public NewMemberInformation()
        {
            InitializeComponent();
        }

        private void NewMemberInformation_Load(object sender, EventArgs e)
        {
            mList = context.Members.ToList();
            posn = mList.Count;
        }

        private void NewMemberCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (MemberNameTextBox.Text == String.Empty || ICNumberTextBox.Text == String.Empty
                || AddressTextBox.Text == String.Empty || CountryTextBox.Text == String.Empty
                || PostalCodeTextBox.Text == String.Empty || ContactNumberTextBox.Text == String.Empty
                || EmailTextBox.Text == String.Empty || genderComboBox.Text == String.Empty)
            {
                MessageBox.Show("Please Fill Completely", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (NameCheck(MemberNameTextBox.Text) == false)
            {
                MessageBox.Show("Digits are not allowed for name!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!this.EmailTextBox.Text.Contains('@') || !this.EmailTextBox.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.ContactNumberTextBox.Text.Length < 9)
            {
                MessageBox.Show("Please Enter A Valid Phone Number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.PostalCodeTextBox.Text.Length != 6)
            {
                MessageBox.Show("Please Enter A Valid Postal Code", "Invalid Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NewMemberAddButton_Click(object sender, EventArgs e)
        {
            if (GoValidation() == false)
            {
                return;
            }
            else
            {
                if (ICNumberTextBox.Text != "" & MemberNameTextBox.Text != "" & AddressTextBox.Text != ""
                    & CountryTextBox.Text != "" & PostalCodeTextBox.Text != "" & ContactNumberTextBox.Text != "" & EmailTextBox.Text != "" & ContactTitleTextBox.Text != "")
                {
                    Member newmember = new Member();
                    newmember.MemberID = mList[mList.Count - 1].MemberID + 1;
                    newmember.MemberName = MemberNameTextBox.Text.ToString();
                    newmember.ICNumber = ICNumberTextBox.Text.ToString();
                    newmember.DateofBirth = memberBDPicker.Value;
                    newmember.Address = AddressTextBox.Text.ToString();
                    newmember.Country = CountryTextBox.Text.ToString();
                    newmember.Postcode = PostalCodeTextBox.Text.ToString();
                    newmember.ContactTitle = ContactTitleTextBox.Text.ToString();
                    newmember.ContactNumber = ContactNumberTextBox.Text.ToString();
                    newmember.EmailAddress = EmailTextBox.Text.ToString();
                    newmember.Gender = genderComboBox.Text.ToString();
                    context.Members.Add(newmember);

                }
                    DialogResult res = MessageBox.Show("Are you sure you want to Insert?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        context.SaveChanges();
                        MessageBox.Show("New Member Insertion Success!");
                        FunctionRefresh();
                        this.Close();
                    }
                    if (res == DialogResult.Cancel)
                    {
                        ICNumberTextBox.Text = "";
                        MemberNameTextBox.Text = "";
                        AddressTextBox.Text = "";
                        CountryTextBox.Text = "";
                        PostalCodeTextBox.Text = "";
                        ContactNumberTextBox.Text = "";
                        EmailTextBox.Text = "";
                        ContactTitleTextBox.Text = "";
                        FunctionRefresh();
                    }
            }
        }

        private void FunctionRefresh()
        {
            mList = context.Members.ToList();
            MemberInformationForm n = new MemberInformationForm();
            n.memGridView.DataSource = mList;
            n.Refresh();
        }

        private void genderComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            String gender = genderComboBox.Text.ToString();
            if (gender == "Female")
            {
                ContactTitleTextBox.Text = "Ms";
            }
            else if (gender == "Male")
            {
                ContactTitleTextBox.Text = "Mr";
            }
        }

    }
}
