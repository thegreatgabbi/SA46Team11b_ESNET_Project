﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    //Written Code By Su Su (e0284029)

    public partial class MainForm : Form
    {
        SembawangSportEntities context = new SembawangSportEntities();


        public MainForm()
        {
            InitializeComponent();
        }
        
     
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            var f2 = new BookingInformationForm();
            f2.TopLevel = false;
            f2.Location = new Point(0, 0);
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Visible = true;
            this.tabPage2.Controls.Add(f2);

            var f3 = new MemberInformationForm();
            f3.TopLevel = false;
            f3.Location = new Point(0, 0);
            f3.FormBorderStyle = FormBorderStyle.None;
            f3.Visible = true;
            this.tabPage3.Controls.Add(f3);

            var f4 = new FacilityInformationForm();
            f4.TopLevel = false;
            f4.Location = new Point(0, 0);
            f4.FormBorderStyle = FormBorderStyle.None;
            f4.Visible = true;
            this.tabPage4.Controls.Add(f4);



        }
    }
}
