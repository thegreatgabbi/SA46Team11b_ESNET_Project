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
    public partial class NewFacilityInformation : Form
    {
        SembawangSportEntities context = new SembawangSportEntities();
        List<Facility> fList;
        int posn;
        Facility newfact = new Facility();
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
            FacilityInformationForm n = new FacilityInformationForm();
            n.FactGridView.DataSource = fList;
            n.Refresh();
        }

        private void NewFacilityAddButton_Click(object sender, EventArgs e)
        {
            newfact.FacilityID = fList[fList.Count - 1].FacilityID + 1;
            newfact.FacilityName = FacilityNameTextBox.Text.ToString();
            newfact.FacilityType = FacilityTypeTextBox.Text.ToString();
            
            newfact.Location = LocationTextBox.Text.ToString();
            newfact.AllowedHours = int.Parse(AllowedHoursTextBox.Text);

            if (FacilityNameTextBox.Text != "" & FacilityTypeTextBox.Text != "" & AllowedHoursTextBox.Text != ""
                & LocationTextBox.Text != "")
            {
                context.Facilities.Add(newfact);
                context.SaveChanges();
                MessageBox.Show("New Facility Insertion Success!");
            }
            FunctionRefresh();
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
