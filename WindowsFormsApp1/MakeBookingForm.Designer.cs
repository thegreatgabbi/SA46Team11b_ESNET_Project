namespace WindowsFormsApp1
{
    partial class MakeBookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MakeBookinglbl = new System.Windows.Forms.Label();
            this.MemberIDlbl = new System.Windows.Forms.Label();
            this.MemberNamelbl = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.LookUpBtn = new System.Windows.Forms.Button();
            this.Displaygrpbox = new System.Windows.Forms.GroupBox();
            this.facilityList = new System.Windows.Forms.ComboBox();
            this.BookingDateDtTimePckr = new System.Windows.Forms.DateTimePicker();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            this.BookingToTime = new System.Windows.Forms.DateTimePicker();
            this.BookingFromTime = new System.Windows.Forms.DateTimePicker();
            this.BookingTolbl = new System.Windows.Forms.Label();
            this.BookingFromlbl = new System.Windows.Forms.Label();
            this.BookingDatelbl = new System.Windows.Forms.Label();
            this.Locationlbl = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.RoomNamelbl = new System.Windows.Forms.Label();
            this.txtNoOfPax = new System.Windows.Forms.TextBox();
            this.Noofpaxlbl = new System.Windows.Forms.Label();
            this.Displaygrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeBookinglbl
            // 
            this.MakeBookinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBookinglbl.Location = new System.Drawing.Point(18, 26);
            this.MakeBookinglbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MakeBookinglbl.Name = "MakeBookinglbl";
            this.MakeBookinglbl.Size = new System.Drawing.Size(194, 37);
            this.MakeBookinglbl.TabIndex = 0;
            this.MakeBookinglbl.Text = "Make Booking";
            // 
            // MemberIDlbl
            // 
            this.MemberIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDlbl.Location = new System.Drawing.Point(43, 75);
            this.MemberIDlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIDlbl.Name = "MemberIDlbl";
            this.MemberIDlbl.Size = new System.Drawing.Size(92, 23);
            this.MemberIDlbl.TabIndex = 1;
            this.MemberIDlbl.Text = "Member ID";
            this.MemberIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemberNamelbl
            // 
            this.MemberNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNamelbl.Location = new System.Drawing.Point(28, 112);
            this.MemberNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberNamelbl.Name = "MemberNamelbl";
            this.MemberNamelbl.Size = new System.Drawing.Size(119, 31);
            this.MemberNamelbl.TabIndex = 2;
            this.MemberNamelbl.Text = "Member Name ";
            this.MemberNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(160, 75);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(76, 20);
            this.txtMemberID.TabIndex = 3;
            this.txtMemberID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemberID_KeyUp);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(160, 121);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(157, 20);
            this.txtMemberName.TabIndex = 4;
            // 
            // LookUpBtn
            // 
            this.LookUpBtn.Location = new System.Drawing.Point(254, 73);
            this.LookUpBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LookUpBtn.Name = "LookUpBtn";
            this.LookUpBtn.Size = new System.Drawing.Size(28, 20);
            this.LookUpBtn.TabIndex = 5;
            this.LookUpBtn.Text = "...";
            this.LookUpBtn.UseVisualStyleBackColor = true;
            this.LookUpBtn.Click += new System.EventHandler(this.LookUpBtn_Click_1);
            // 
            // Displaygrpbox
            // 
            this.Displaygrpbox.Controls.Add(this.facilityList);
            this.Displaygrpbox.Controls.Add(this.BookingDateDtTimePckr);
            this.Displaygrpbox.Controls.Add(this.Cancelbtn);
            this.Displaygrpbox.Controls.Add(this.Okbtn);
            this.Displaygrpbox.Controls.Add(this.BookingToTime);
            this.Displaygrpbox.Controls.Add(this.BookingFromTime);
            this.Displaygrpbox.Controls.Add(this.BookingTolbl);
            this.Displaygrpbox.Controls.Add(this.BookingFromlbl);
            this.Displaygrpbox.Controls.Add(this.BookingDatelbl);
            this.Displaygrpbox.Controls.Add(this.Locationlbl);
            this.Displaygrpbox.Controls.Add(this.txtLocation);
            this.Displaygrpbox.Controls.Add(this.RoomNamelbl);
            this.Displaygrpbox.Location = new System.Drawing.Point(23, 172);
            this.Displaygrpbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Displaygrpbox.Name = "Displaygrpbox";
            this.Displaygrpbox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Displaygrpbox.Size = new System.Drawing.Size(544, 257);
            this.Displaygrpbox.TabIndex = 6;
            this.Displaygrpbox.TabStop = false;
            this.Displaygrpbox.Text = "Details";
            // 
            // facilityList
            // 
            this.facilityList.FormattingEnabled = true;
            this.facilityList.Location = new System.Drawing.Point(120, 56);
            this.facilityList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.facilityList.Name = "facilityList";
            this.facilityList.Size = new System.Drawing.Size(131, 21);
            this.facilityList.TabIndex = 17;
            this.facilityList.SelectedIndexChanged += new System.EventHandler(this.facilityList_SelectedIndexChanged);
            // 
            // BookingDateDtTimePckr
            // 
            this.BookingDateDtTimePckr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDateDtTimePckr.Location = new System.Drawing.Point(409, 59);
            this.BookingDateDtTimePckr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BookingDateDtTimePckr.Name = "BookingDateDtTimePckr";
            this.BookingDateDtTimePckr.Size = new System.Drawing.Size(115, 20);
            this.BookingDateDtTimePckr.TabIndex = 16;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(280, 204);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(68, 36);
            this.Cancelbtn.TabIndex = 15;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Okbtn
            // 
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.Location = new System.Drawing.Point(155, 204);
            this.Okbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(67, 36);
            this.Okbtn.TabIndex = 14;
            this.Okbtn.Text = "Ok";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click_1);
            // 
            // BookingToTime
            // 
            this.BookingToTime.Location = new System.Drawing.Point(409, 162);
            this.BookingToTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BookingToTime.Name = "BookingToTime";
            this.BookingToTime.Size = new System.Drawing.Size(76, 20);
            this.BookingToTime.TabIndex = 13;
            // 
            // BookingFromTime
            // 
            this.BookingFromTime.Location = new System.Drawing.Point(409, 107);
            this.BookingFromTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BookingFromTime.Name = "BookingFromTime";
            this.BookingFromTime.Size = new System.Drawing.Size(76, 20);
            this.BookingFromTime.TabIndex = 12;
            this.BookingFromTime.Value = new System.DateTime(2018, 3, 23, 10, 48, 0, 0);
            // 
            // BookingTolbl
            // 
            this.BookingTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTolbl.Location = new System.Drawing.Point(278, 153);
            this.BookingTolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingTolbl.Name = "BookingTolbl";
            this.BookingTolbl.Size = new System.Drawing.Size(105, 29);
            this.BookingTolbl.TabIndex = 11;
            this.BookingTolbl.Text = "Booking To";
            this.BookingTolbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingFromlbl
            // 
            this.BookingFromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingFromlbl.Location = new System.Drawing.Point(266, 98);
            this.BookingFromlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingFromlbl.Name = "BookingFromlbl";
            this.BookingFromlbl.Size = new System.Drawing.Size(123, 34);
            this.BookingFromlbl.TabIndex = 10;
            this.BookingFromlbl.Text = "Booking From";
            this.BookingFromlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingDatelbl
            // 
            this.BookingDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDatelbl.Location = new System.Drawing.Point(262, 46);
            this.BookingDatelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingDatelbl.Name = "BookingDatelbl";
            this.BookingDatelbl.Size = new System.Drawing.Size(124, 45);
            this.BookingDatelbl.TabIndex = 9;
            this.BookingDatelbl.Text = "Booking Date";
            this.BookingDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Locationlbl
            // 
            this.Locationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locationlbl.Location = new System.Drawing.Point(20, 92);
            this.Locationlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(82, 31);
            this.Locationlbl.TabIndex = 8;
            this.Locationlbl.Text = "Location";
            this.Locationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(120, 101);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(76, 20);
            this.txtLocation.TabIndex = 7;
            // 
            // RoomNamelbl
            // 
            this.RoomNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNamelbl.Location = new System.Drawing.Point(-10, 44);
            this.RoomNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomNamelbl.Name = "RoomNamelbl";
            this.RoomNamelbl.Size = new System.Drawing.Size(111, 37);
            this.RoomNamelbl.TabIndex = 7;
            this.RoomNamelbl.Text = "Facility Name";
            this.RoomNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNoOfPax
            // 
            this.txtNoOfPax.Location = new System.Drawing.Point(441, 120);
            this.txtNoOfPax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNoOfPax.Name = "txtNoOfPax";
            this.txtNoOfPax.Size = new System.Drawing.Size(27, 20);
            this.txtNoOfPax.TabIndex = 8;
            // 
            // Noofpaxlbl
            // 
            this.Noofpaxlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noofpaxlbl.Location = new System.Drawing.Point(356, 114);
            this.Noofpaxlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Noofpaxlbl.Name = "Noofpaxlbl";
            this.Noofpaxlbl.Size = new System.Drawing.Size(80, 28);
            this.Noofpaxlbl.TabIndex = 7;
            this.Noofpaxlbl.Text = "# Persons";
            this.Noofpaxlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MakeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 425);
            this.Controls.Add(this.txtNoOfPax);
            this.Controls.Add(this.Noofpaxlbl);
            this.Controls.Add(this.Displaygrpbox);
            this.Controls.Add(this.LookUpBtn);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.MemberNamelbl);
            this.Controls.Add(this.MemberIDlbl);
            this.Controls.Add(this.MakeBookinglbl);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MakeBookingForm";
            this.Text = "Make Booking ";
            this.Load += new System.EventHandler(this.MakeBookingForm_Load);
            this.Displaygrpbox.ResumeLayout(false);
            this.Displaygrpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MakeBookinglbl;
        private System.Windows.Forms.Label MemberIDlbl;
        private System.Windows.Forms.Label MemberNamelbl;
        private System.Windows.Forms.Button LookUpBtn;
        private System.Windows.Forms.GroupBox Displaygrpbox;
        private System.Windows.Forms.Label Locationlbl;
        private System.Windows.Forms.Label RoomNamelbl;
        private System.Windows.Forms.DateTimePicker BookingToTime;
        private System.Windows.Forms.DateTimePicker BookingFromTime;
        private System.Windows.Forms.Label BookingTolbl;
        private System.Windows.Forms.Label BookingFromlbl;
        private System.Windows.Forms.Label BookingDatelbl;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Okbtn;
        public System.Windows.Forms.TextBox txtMemberID;
        public System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.DateTimePicker BookingDateDtTimePckr;
        public System.Windows.Forms.TextBox txtLocation;
        public System.Windows.Forms.TextBox txtNoOfPax;
        private System.Windows.Forms.Label Noofpaxlbl;
        private System.Windows.Forms.ComboBox facilityList;
    }
}

