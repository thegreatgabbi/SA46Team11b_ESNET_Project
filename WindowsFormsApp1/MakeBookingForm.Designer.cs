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
            this.BookingDateDtTimePckr = new System.Windows.Forms.DateTimePicker();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            this.BookingToTime = new System.Windows.Forms.DateTimePicker();
            this.BookingFromTime = new System.Windows.Forms.DateTimePicker();
            this.BookingTolbl = new System.Windows.Forms.Label();
            this.BookingFromlbl = new System.Windows.Forms.Label();
            this.BookingDatelbl = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.Locationlbl = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.Displaylbl = new System.Windows.Forms.Label();
            this.RoomNamelbl = new System.Windows.Forms.Label();
            this.txtNoOfpax = new System.Windows.Forms.TextBox();
            this.Noofpaxlbl = new System.Windows.Forms.Label();
            this.Displaygrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeBookinglbl
            // 
            this.MakeBookinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBookinglbl.Location = new System.Drawing.Point(24, 32);
            this.MakeBookinglbl.Name = "MakeBookinglbl";
            this.MakeBookinglbl.Size = new System.Drawing.Size(258, 46);
            this.MakeBookinglbl.TabIndex = 0;
            this.MakeBookinglbl.Text = "Make Booking";
            // 
            // MemberIDlbl
            // 
            this.MemberIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDlbl.Location = new System.Drawing.Point(57, 92);
            this.MemberIDlbl.Name = "MemberIDlbl";
            this.MemberIDlbl.Size = new System.Drawing.Size(122, 28);
            this.MemberIDlbl.TabIndex = 1;
            this.MemberIDlbl.Text = "Member ID";
            this.MemberIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemberNamelbl
            // 
            this.MemberNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNamelbl.Location = new System.Drawing.Point(37, 138);
            this.MemberNamelbl.Name = "MemberNamelbl";
            this.MemberNamelbl.Size = new System.Drawing.Size(159, 38);
            this.MemberNamelbl.TabIndex = 2;
            this.MemberNamelbl.Text = "Member Name ";
            this.MemberNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(213, 92);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 3;
            this.txtMemberID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemberID_KeyUp);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(213, 149);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(208, 22);
            this.txtMemberName.TabIndex = 4;
            // 
            // LookUpBtn
            // 
            this.LookUpBtn.Location = new System.Drawing.Point(339, 90);
            this.LookUpBtn.Name = "LookUpBtn";
            this.LookUpBtn.Size = new System.Drawing.Size(38, 24);
            this.LookUpBtn.TabIndex = 5;
            this.LookUpBtn.Text = "...";
            this.LookUpBtn.UseVisualStyleBackColor = true;
            this.LookUpBtn.Click += new System.EventHandler(this.LookUpBtn_Click_1);
            // 
            // Displaygrpbox
            // 
            this.Displaygrpbox.Controls.Add(this.BookingDateDtTimePckr);
            this.Displaygrpbox.Controls.Add(this.Cancelbtn);
            this.Displaygrpbox.Controls.Add(this.Okbtn);
            this.Displaygrpbox.Controls.Add(this.BookingToTime);
            this.Displaygrpbox.Controls.Add(this.BookingFromTime);
            this.Displaygrpbox.Controls.Add(this.BookingTolbl);
            this.Displaygrpbox.Controls.Add(this.BookingFromlbl);
            this.Displaygrpbox.Controls.Add(this.BookingDatelbl);
            this.Displaygrpbox.Controls.Add(this.txtRoomName);
            this.Displaygrpbox.Controls.Add(this.Locationlbl);
            this.Displaygrpbox.Controls.Add(this.txtLocation);
            this.Displaygrpbox.Controls.Add(this.Displaylbl);
            this.Displaygrpbox.Controls.Add(this.RoomNamelbl);
            this.Displaygrpbox.Location = new System.Drawing.Point(31, 211);
            this.Displaygrpbox.Name = "Displaygrpbox";
            this.Displaygrpbox.Size = new System.Drawing.Size(725, 317);
            this.Displaygrpbox.TabIndex = 6;
            this.Displaygrpbox.TabStop = false;
//            this.Displaygrpbox.Enter += new System.EventHandler(this.Displaygrpbox_Enter);
            // 
            // BookingDateDtTimePckr
            // 
            this.BookingDateDtTimePckr.Location = new System.Drawing.Point(545, 73);
            this.BookingDateDtTimePckr.Name = "BookingDateDtTimePckr";
            this.BookingDateDtTimePckr.Size = new System.Drawing.Size(152, 22);
            this.BookingDateDtTimePckr.TabIndex = 16;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(374, 251);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(91, 44);
            this.Cancelbtn.TabIndex = 15;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // Okbtn
            // 
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.Location = new System.Drawing.Point(207, 251);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(89, 44);
            this.Okbtn.TabIndex = 14;
            this.Okbtn.Text = "Ok";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click_1);
            // 
            // BookingToTime
            // 
            this.BookingToTime.Location = new System.Drawing.Point(545, 199);
            this.BookingToTime.Name = "BookingToTime";
            this.BookingToTime.Size = new System.Drawing.Size(100, 22);
            this.BookingToTime.TabIndex = 13;
            // 
            // BookingFromTime
            // 
            this.BookingFromTime.Location = new System.Drawing.Point(545, 132);
            this.BookingFromTime.Name = "BookingFromTime";
            this.BookingFromTime.Size = new System.Drawing.Size(100, 22);
            this.BookingFromTime.TabIndex = 12;
            this.BookingFromTime.Value = new System.DateTime(2018, 3, 23, 10, 48, 0, 0);
            // 
            // BookingTolbl
            // 
            this.BookingTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTolbl.Location = new System.Drawing.Point(371, 188);
            this.BookingTolbl.Name = "BookingTolbl";
            this.BookingTolbl.Size = new System.Drawing.Size(140, 35);
            this.BookingTolbl.TabIndex = 11;
            this.BookingTolbl.Text = "Booking To";
            this.BookingTolbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingFromlbl
            // 
            this.BookingFromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingFromlbl.Location = new System.Drawing.Point(354, 121);
            this.BookingFromlbl.Name = "BookingFromlbl";
            this.BookingFromlbl.Size = new System.Drawing.Size(164, 42);
            this.BookingFromlbl.TabIndex = 10;
            this.BookingFromlbl.Text = "Booking From";
            this.BookingFromlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingDatelbl
            // 
            this.BookingDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDatelbl.Location = new System.Drawing.Point(350, 56);
            this.BookingDatelbl.Name = "BookingDatelbl";
            this.BookingDatelbl.Size = new System.Drawing.Size(166, 55);
            this.BookingDatelbl.TabIndex = 9;
            this.BookingDatelbl.Text = "Booking Date";
            this.BookingDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(160, 66);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.Size = new System.Drawing.Size(185, 22);
            this.txtRoomName.TabIndex = 8;
            // 
            // Locationlbl
            // 
            this.Locationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locationlbl.Location = new System.Drawing.Point(20, 112);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(109, 38);
            this.Locationlbl.TabIndex = 8;
            this.Locationlbl.Text = "Location";
            this.Locationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(160, 128);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 7;
            // 
            // Displaylbl
            // 
            this.Displaylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Displaylbl.Location = new System.Drawing.Point(15, 18);
            this.Displaylbl.Name = "Displaylbl";
            this.Displaylbl.Size = new System.Drawing.Size(100, 23);
            this.Displaylbl.TabIndex = 0;
            this.Displaylbl.Text = "Details";
            // 
            // RoomNamelbl
            // 
            this.RoomNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNamelbl.Location = new System.Drawing.Point(-14, 54);
            this.RoomNamelbl.Name = "RoomNamelbl";
            this.RoomNamelbl.Size = new System.Drawing.Size(148, 46);
            this.RoomNamelbl.TabIndex = 7;
            this.RoomNamelbl.Text = "Room Name";
            this.RoomNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNoOfpax
            // 
            this.txtNoOfpax.Location = new System.Drawing.Point(555, 90);
            this.txtNoOfpax.Name = "txtNoOfpax";
            this.txtNoOfpax.Size = new System.Drawing.Size(35, 22);
            this.txtNoOfpax.TabIndex = 8;
  //          this.txtNoOfpax.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Noofpaxlbl
            // 
            this.Noofpaxlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noofpaxlbl.Location = new System.Drawing.Point(407, 83);
            this.Noofpaxlbl.Name = "Noofpaxlbl";
            this.Noofpaxlbl.Size = new System.Drawing.Size(142, 34);
            this.Noofpaxlbl.TabIndex = 7;
            this.Noofpaxlbl.Text = "No of Persons";
            this.Noofpaxlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
   //         this.Noofpaxlbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MakeBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtNoOfpax);
            this.Controls.Add(this.Noofpaxlbl);
            this.Controls.Add(this.Displaygrpbox);
            this.Controls.Add(this.LookUpBtn);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.MemberNamelbl);
            this.Controls.Add(this.MemberIDlbl);
            this.Controls.Add(this.MakeBookinglbl);
            this.Name = "MakeBookingForm";
            this.Text = "Make Booking ";
     //       this.Load += new System.EventHandler(this.MakeBookingForm_Load_1);
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
        private System.Windows.Forms.Label Displaylbl;
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
        public System.Windows.Forms.TextBox txtRoomName;
        public System.Windows.Forms.TextBox txtLocation;
        public System.Windows.Forms.TextBox txtNoOfpax;
        private System.Windows.Forms.Label Noofpaxlbl;
    }
}

