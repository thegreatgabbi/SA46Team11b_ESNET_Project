﻿using System;
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

    public partial class MainForm : Form
    {
        SembawangSportEntities context = new SembawangSportEntities();
        List<Facility> fList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LookUpBtn_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberInformationForm mi = new MemberInformationForm();
            mi.Show();
            //this.Close();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            fList = context.Facilities.ToList();
            var list = fList.Select(x => x.FacilityType).Distinct();
            foreach(var x in list)
            {
                facilityTypeCombo.Items.Add(x.ToString());
            }
        }
    }
}
