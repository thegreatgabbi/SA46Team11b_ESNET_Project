﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGenerator
{
    public partial class MemberList : Form
    {
        public MemberList()
        {
            InitializeComponent();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
           
            CRMem cr = new CRMem();
            MemListView.ReportSource = cr;
        }
    }
}
