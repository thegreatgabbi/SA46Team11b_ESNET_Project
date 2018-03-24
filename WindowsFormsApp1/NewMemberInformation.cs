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

        public NewMemberInformation()
        {
            InitializeComponent();
        }

        private void NewMemberInformation_Load(object sender, EventArgs e)
        {
            mList = context.Members.ToList();
        }

        private void NewMemberCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewMemberAddButton_Click(object sender, EventArgs e)
        {
            int posn = mList.Count();
            if (ICNumberTextBox .Text != "" & MemberNameTextBox.Text != "" & AddressTextBox.Text != ""
                &  CountryTextBox.Text != "" & PostalCodeTextBox.Text != "" & ContactNumberTextBox.Text != "" & EmailTextBox.Text != "" & GenderTextBox.Text != "")
            {
                MessageBox.Show(posn.ToString());
            }
        }

        private void GenderTextBox_TextChanged(object sender, EventArgs e)
        {
            string gender = GenderTextBox.Text.ToString();
            if (gender == "Female")
            {
                ContactTitleTextBox.Text = "Ms";
            }
            else if(gender=="Male")
            {
                ContactTitleTextBox.Text = "Mr";
            }
        }
    }
}
