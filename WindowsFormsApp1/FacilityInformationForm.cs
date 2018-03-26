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

    public partial class FacilityInformationForm : Form
    {
        SembawangSportEntities context = new SembawangSportEntities();
        List<Facility> fList;
        int posn = 0;

        public FacilityInformationForm()
        {
            InitializeComponent();
        }

        public FacilityInformationForm(int k)
        {
            InitializeComponent();
            posn = 0;
        }

        private void addNewFacilityButton_Click(object sender, EventArgs e)
        {
            NewFacilityInformation nfi = new NewFacilityInformation();
            nfi.ShowDialog();
            FactGridView.DataSource = context.Facilities.ToList();
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            int length = searchFacilityTextBox.TextLength;
            string text = (searchFacilityTextBox.Text).Trim();
            var q = from x in context.Facilities
                    where ((x.FacilityName.Substring(0, length) == text) ||
                          (x.FacilityID.ToString().Substring(0, length) == searchFacilityTextBox.Text) ||
                          (x.FacilityType.Substring(0, length) == text) ||
                          (x.Location.Substring(0, length) == text) ||
                          (x.AllowedHours.ToString().Substring(0, length) == text))
                    select x;
            FactGridView.DataSource = q.ToList();
        }

        private void FacilityInformationForm_Load(object sender, EventArgs e)
        {
            fList = context.Facilities.ToList();
            FactGridView.DataSource = fList;
            MaintenanceDateDPicker.CustomFormat = " ";
        }

        private void FactGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posn = e.RowIndex;
            FacilityIDTextBox.Text = FactGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            FacilityTypeTextBox.Text = FactGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            FacilityNameTextBox.Text = FactGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            LocationTextBox.Text = FactGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (FactGridView.Rows[e.RowIndex].Cells[4].Value == null)
            {
                MaintenanceDateDPicker.CustomFormat = " ";
                MaintenanceDateDPicker.Value = DateTimePicker.MinimumDateTime;
            }
            else
            {
                MaintenanceDateDPicker.CustomFormat = "dd-MM-yyyy";
                MaintenanceDateDPicker.Value = (DateTime)FactGridView.Rows[e.RowIndex].Cells[4].Value;

            }
            AllowedHoursTextBox.Text = FactGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
       

        private bool GoValidation()
        {
            if (FacilityNameTextBox.Text == String.Empty || FacilityTypeTextBox.Text == String.Empty
                || LocationTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please Fill Completely", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (FacilityIDTextBox.Text != "" & FacilityNameTextBox.Text != "" & FacilityTypeTextBox.Text != "" & LocationTextBox.Text != ""
                   & AllowedHoursTextBox.Text != "")
                {
                    MessageBox.Show(posn.ToString());
                    int i = Convert.ToInt16(FacilityIDTextBox.Text);
                    int j = Convert.ToInt16(AllowedHoursTextBox.Text);
                    fList[posn].FacilityID = i;
                    fList[posn].FacilityName = FacilityNameTextBox.Text;
                    fList[posn].FacilityType = FacilityTypeTextBox.Text;
                    fList[posn].Location = LocationTextBox.Text;
                    fList[posn].AllowedHours = j;
                    fList[posn].MaintenanceDate = MaintenanceDateDPicker.Value;
                }
                DialogResult res = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    context.SaveChanges();
                    MessageBox.Show("Update Success!");
                    this.Refresh();
                    FactGridView.DataSource = context.Facilities.ToList();
                }
                if (res == DialogResult.Cancel)
                {
                    FacilityIDTextBox.Text = "";
                    FacilityNameTextBox.Text = "";
                    FacilityTypeTextBox.Text = "";
                    LocationTextBox.Text = "";
                    AllowedHoursTextBox.Text = "";
                    MaintenanceDateDPicker.Value = DateTimePicker.MinimumDateTime;
                    posn = 0;
                }
            }

        }
        

        private void nodateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (nodateCheckbox.Checked == true)
            {
                MaintenanceDateDPicker.Value = DateTimePicker.MinimumDateTime;
                MaintenanceDateDPicker.CustomFormat = " ";
                MaintenanceDateDPicker.Visible = false;
                maintanceLabel.Visible = false;
            }
            else
            {
                MaintenanceDateDPicker.Visible = true;
                maintanceLabel.Visible = true;
                MaintenanceDateDPicker.CustomFormat = "dd-MM-yyyy";
            }
        }

        private void MaintenanceDateDPicker_ValueChanged_1(object sender, EventArgs e)
        {
            MaintenanceDateDPicker.CustomFormat = "dd-MM-yyyy";
        }

        public void FunctionRefresh()
        {
            fList = context.Facilities.ToList();
            FactGridView.DataSource = fList;
            Refresh();
            MaintenanceDateDPicker.CustomFormat = " ";
            posn = fList.Count;
            FacilityIDTextBox.Text = "";
            FacilityNameTextBox.Text = "";
            FacilityTypeTextBox.Text = "";
            LocationTextBox.Text = "";
            AllowedHoursTextBox.Text = "";
            MaintenanceDateDPicker.Value = DateTimePicker.MinimumDateTime;
        }

        private void DeleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Facility c = context.Facilities.Where(x => x.FacilityID.ToString() == (FacilityIDTextBox.Text)).First();

            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                context.Facilities.Remove(c);
                context.SaveChanges();
                MessageBox.Show("Delete Success!");
                this.FunctionRefresh();
                FactGridView.DataSource = context.Facilities.ToList();
            }
            if (res == DialogResult.Cancel)
            {
                FacilityIDTextBox.Text = "";
                FacilityNameTextBox.Text = "";
                FacilityTypeTextBox.Text = "";
                LocationTextBox.Text = "";
                AllowedHoursTextBox.Text = "";
                MaintenanceDateDPicker.Value = DateTimePicker.MinimumDateTime;
                posn = 0;
            }
        }

        private void bookingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingInformationForm bif = new BookingInformationForm();
            bif.Show();
        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberInformationForm mif = new MemberInformationForm();
            mif.Show();
        }
        
        private void FacilityInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityInformationForm_Load(sender, e);
        }
    }
}
