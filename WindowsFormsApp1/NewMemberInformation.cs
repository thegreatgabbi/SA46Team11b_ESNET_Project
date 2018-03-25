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

        private void NewMemberAddButton_Click(object sender, EventArgs e)
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
           
            if (ICNumberTextBox .Text != "" & MemberNameTextBox.Text != "" & AddressTextBox.Text != ""
                &  CountryTextBox.Text != "" & PostalCodeTextBox.Text != "" & ContactNumberTextBox.Text != "" & EmailTextBox.Text != "" & ContactTitleTextBox.Text != "")
            {
                context.Members.Add(newmember);
                context.SaveChanges();
                MessageBox.Show("New Member Insertion Success!");
            }
            FunctionRefresh();
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
