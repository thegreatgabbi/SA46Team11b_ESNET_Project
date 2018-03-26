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

    public partial class NewFacilityInformation : Form
    {
        SembawangSportEntities context = new SembawangSportEntities();
        List<Facility> fList;
        int posn;
        Facility newfact = new Facility();
        FacilityInformationForm n = new FacilityInformationForm();
        public NewFacilityInformation()
        {
            InitializeComponent();
        }

        private void NewFacilityInformation_Load(object sender, EventArgs e)
        {
            fList = context.Facilities.ToList();
            posn = fList.Count;
        }

        private void newFacilityCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FunctionRefresh()
        {
            fList = context.Facilities.ToList();
            n.FunctionRefresh();
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
            if (FacilityNameTextBox.Text == String.Empty || FacilityTypeTextBox.Text == String.Empty
                || LocationTextBox.Text == String.Empty || AllowedHoursTextBox.Text == String.Empty)
            {
                MessageBox.Show("Please Fill Completely", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void NewFacilityAddButton_Click(object sender, EventArgs e)
        {
            if (GoValidation() == false)
            {
                return;
            }
            else
            {
                if (FacilityNameTextBox.Text != "" || FacilityTypeTextBox.Text != ""
                || LocationTextBox.Text != "")
                {
                    newfact.FacilityID = fList[fList.Count - 1].FacilityID + 1;
                    newfact.FacilityName = FacilityNameTextBox.Text.ToString();
                    newfact.FacilityType = FacilityTypeTextBox.Text.ToString();
                    newfact.Location = LocationTextBox.Text.ToString();
                    newfact.AllowedHours = Convert.ToInt32(AllowedHoursTextBox.Text);
                    context.Facilities.Add(newfact);
                }
                    DialogResult res = MessageBox.Show("Are you sure you want to Insert?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        context.SaveChanges();
                        MessageBox.Show("New Facility Insertion Success!");
                        FunctionRefresh();                        
                        this.Close();
                }
                    if (res == DialogResult.Cancel)
                    {
                        FacilityNameTextBox.Text = "";
                        FacilityTypeTextBox.Text = "";
                        LocationTextBox.Text = "";
                        AllowedHoursTextBox.Text = "";
                        FunctionRefresh();
                    
                }
                }
            }

        private void nomaintananceDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (nomaintananceDateCheckbox.Checked == true)
            {
                datelabel.Visible = false;
                MaintananceDPicker.Visible = false;
                newfact.MaintenanceDate = DateTimePicker.MinimumDateTime;
            }
            else
            {
                datelabel.Visible = true;
                MaintananceDPicker.Visible = true;
                newfact.MaintenanceDate = MaintananceDPicker.Value;
            }
        }
    }
}
