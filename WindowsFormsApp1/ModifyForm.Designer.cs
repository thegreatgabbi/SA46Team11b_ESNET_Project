namespace WindowsFormsApp1
{
    partial class ModifyForm
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
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.LookUpBtn = new System.Windows.Forms.Button();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.Modifybtn = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.Locationlbl = new System.Windows.Forms.Label();
            this.RoomNamelbl = new System.Windows.Forms.Label();
            this.MemberIDlbl = new System.Windows.Forms.Label();
            this.BookingToTime = new System.Windows.Forms.DateTimePicker();
            this.BookingFromTime = new System.Windows.Forms.DateTimePicker();
            this.BookingTolbl = new System.Windows.Forms.Label();
            this.BookingFromlbl = new System.Windows.Forms.Label();
            this.BookingDatelbl = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.MemberNamelbl = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.BookingDateDtTimePckr = new System.Windows.Forms.DateTimePicker();
            this.DeleteBookingbtn = new System.Windows.Forms.Button();
            this.txtNoOfPax = new System.Windows.Forms.TextBox();
            this.NoOfPaxlbl = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.grpMemberDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeBookinglbl
            // 
            this.MakeBookinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBookinglbl.Location = new System.Drawing.Point(9, 7);
            this.MakeBookinglbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MakeBookinglbl.Name = "MakeBookinglbl";
            this.MakeBookinglbl.Size = new System.Drawing.Size(194, 37);
            this.MakeBookinglbl.TabIndex = 16;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(385, 320);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(68, 36);
            this.Cancelbtn.TabIndex = 34;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // LookUpBtn
            // 
            this.LookUpBtn.Location = new System.Drawing.Point(225, 69);
            this.LookUpBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LookUpBtn.Name = "LookUpBtn";
            this.LookUpBtn.Size = new System.Drawing.Size(28, 20);
            this.LookUpBtn.TabIndex = 22;
            this.LookUpBtn.Text = "...";
            this.LookUpBtn.UseVisualStyleBackColor = true;
            this.LookUpBtn.Click += new System.EventHandler(this.LookUpBtn_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(136, 107);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(157, 20);
            this.txtMemberName.TabIndex = 21;
            // 
            // Modifybtn
            // 
            this.Modifybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifybtn.Location = new System.Drawing.Point(53, 320);
            this.Modifybtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(67, 36);
            this.Modifybtn.TabIndex = 33;
            this.Modifybtn.Text = "Modify";
            this.Modifybtn.UseVisualStyleBackColor = true;
            this.Modifybtn.Click += new System.EventHandler(this.Modifybtn_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(136, 69);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(76, 20);
            this.txtMemberID.TabIndex = 20;
            // 
            // Locationlbl
            // 
            this.Locationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locationlbl.Location = new System.Drawing.Point(23, 76);
            this.Locationlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(82, 31);
            this.Locationlbl.TabIndex = 26;
            this.Locationlbl.Text = "Location";
            this.Locationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RoomNamelbl
            // 
            this.RoomNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNamelbl.Location = new System.Drawing.Point(4, 15);
            this.RoomNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomNamelbl.Name = "RoomNamelbl";
            this.RoomNamelbl.Size = new System.Drawing.Size(104, 37);
            this.RoomNamelbl.TabIndex = 23;
            this.RoomNamelbl.Text = "Facility Name";
            this.RoomNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemberIDlbl
            // 
            this.MemberIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDlbl.Location = new System.Drawing.Point(16, 44);
            this.MemberIDlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIDlbl.Name = "MemberIDlbl";
            this.MemberIDlbl.Size = new System.Drawing.Size(92, 23);
            this.MemberIDlbl.TabIndex = 18;
            this.MemberIDlbl.Text = "Member ID";
            this.MemberIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingToTime
            // 
            this.BookingToTime.CustomFormat = "HH:MM tt";
            this.BookingToTime.Location = new System.Drawing.Point(435, 119);
            this.BookingToTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BookingToTime.Name = "BookingToTime";
            this.BookingToTime.Size = new System.Drawing.Size(76, 20);
            this.BookingToTime.TabIndex = 32;
            // 
            // BookingFromTime
            // 
            this.BookingFromTime.CustomFormat = "HH:MM tt";
            this.BookingFromTime.Location = new System.Drawing.Point(435, 67);
            this.BookingFromTime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BookingFromTime.Name = "BookingFromTime";
            this.BookingFromTime.Size = new System.Drawing.Size(76, 20);
            this.BookingFromTime.TabIndex = 31;
            this.BookingFromTime.TabStop = false;
            this.BookingFromTime.Value = new System.DateTime(2018, 3, 23, 10, 48, 0, 0);
            // 
            // BookingTolbl
            // 
            this.BookingTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTolbl.Location = new System.Drawing.Point(303, 108);
            this.BookingTolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingTolbl.Name = "BookingTolbl";
            this.BookingTolbl.Size = new System.Drawing.Size(105, 29);
            this.BookingTolbl.TabIndex = 30;
            this.BookingTolbl.Text = "Booking To";
            this.BookingTolbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingFromlbl
            // 
            this.BookingFromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingFromlbl.Location = new System.Drawing.Point(287, 58);
            this.BookingFromlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingFromlbl.Name = "BookingFromlbl";
            this.BookingFromlbl.Size = new System.Drawing.Size(123, 34);
            this.BookingFromlbl.TabIndex = 29;
            this.BookingFromlbl.Text = "Booking From";
            this.BookingFromlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingDatelbl
            // 
            this.BookingDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDatelbl.Location = new System.Drawing.Point(287, 15);
            this.BookingDatelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingDatelbl.Name = "BookingDatelbl";
            this.BookingDatelbl.Size = new System.Drawing.Size(121, 37);
            this.BookingDatelbl.TabIndex = 28;
            this.BookingDatelbl.Text = "Booking Date";
            this.BookingDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(120, 89);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(76, 20);
            this.txtLocation.TabIndex = 25;
            // 
            // MemberNamelbl
            // 
            this.MemberNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNamelbl.Location = new System.Drawing.Point(9, 98);
            this.MemberNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberNamelbl.Name = "MemberNamelbl";
            this.MemberNamelbl.Size = new System.Drawing.Size(119, 31);
            this.MemberNamelbl.TabIndex = 19;
            this.MemberNamelbl.Text = "Member Name ";
            this.MemberNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(120, 27);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.Size = new System.Drawing.Size(140, 20);
            this.txtRoomName.TabIndex = 27;
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.BookingDateDtTimePckr);
            this.grpMemberDetails.Controls.Add(this.RoomNamelbl);
            this.grpMemberDetails.Controls.Add(this.txtRoomName);
            this.grpMemberDetails.Controls.Add(this.BookingDatelbl);
            this.grpMemberDetails.Controls.Add(this.BookingFromlbl);
            this.grpMemberDetails.Controls.Add(this.BookingFromTime);
            this.grpMemberDetails.Controls.Add(this.BookingTolbl);
            this.grpMemberDetails.Controls.Add(this.BookingToTime);
            this.grpMemberDetails.Controls.Add(this.Locationlbl);
            this.grpMemberDetails.Controls.Add(this.txtLocation);
            this.grpMemberDetails.Location = new System.Drawing.Point(23, 143);
            this.grpMemberDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpMemberDetails.Size = new System.Drawing.Size(554, 166);
            this.grpMemberDetails.TabIndex = 35;
            this.grpMemberDetails.TabStop = false;
            // 
            // BookingDateDtTimePckr
            // 
            this.BookingDateDtTimePckr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookingDateDtTimePckr.Location = new System.Drawing.Point(435, 25);
            this.BookingDateDtTimePckr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BookingDateDtTimePckr.Name = "BookingDateDtTimePckr";
            this.BookingDateDtTimePckr.Size = new System.Drawing.Size(116, 20);
            this.BookingDateDtTimePckr.TabIndex = 33;
            // 
            // DeleteBookingbtn
            // 
            this.DeleteBookingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookingbtn.Location = new System.Drawing.Point(194, 320);
            this.DeleteBookingbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DeleteBookingbtn.Name = "DeleteBookingbtn";
            this.DeleteBookingbtn.Size = new System.Drawing.Size(144, 36);
            this.DeleteBookingbtn.TabIndex = 36;
            this.DeleteBookingbtn.Text = "Delete Booking";
            this.DeleteBookingbtn.UseVisualStyleBackColor = true;
            this.DeleteBookingbtn.Click += new System.EventHandler(this.DeleteBookingbtn_Click);
            // 
            // txtNoOfPax
            // 
            this.txtNoOfPax.Location = new System.Drawing.Point(458, 110);
            this.txtNoOfPax.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNoOfPax.Name = "txtNoOfPax";
            this.txtNoOfPax.Size = new System.Drawing.Size(36, 20);
            this.txtNoOfPax.TabIndex = 39;
            // 
            // NoOfPaxlbl
            // 
            this.NoOfPaxlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfPaxlbl.Location = new System.Drawing.Point(336, 108);
            this.NoOfPaxlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoOfPaxlbl.Name = "NoOfPaxlbl";
            this.NoOfPaxlbl.Size = new System.Drawing.Size(95, 17);
            this.NoOfPaxlbl.TabIndex = 38;
            this.NoOfPaxlbl.Text = "# Persons";
            this.NoOfPaxlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(472, 8);
            this.printButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(120, 33);
            this.printButton.TabIndex = 40;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 399);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.txtNoOfPax);
            this.Controls.Add(this.NoOfPaxlbl);
            this.Controls.Add(this.DeleteBookingbtn);
            this.Controls.Add(this.grpMemberDetails);
            this.Controls.Add(this.MakeBookinglbl);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.LookUpBtn);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.Modifybtn);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.MemberIDlbl);
            this.Controls.Add(this.MemberNamelbl);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ModifyForm";
            this.Text = "Modify Booking";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MakeBookinglbl;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button LookUpBtn;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.Label Locationlbl;
        private System.Windows.Forms.Label RoomNamelbl;
        private System.Windows.Forms.Label MemberIDlbl;
        private System.Windows.Forms.DateTimePicker BookingToTime;
        private System.Windows.Forms.DateTimePicker BookingFromTime;
        private System.Windows.Forms.Label BookingTolbl;
        private System.Windows.Forms.Label BookingFromlbl;
        private System.Windows.Forms.Label BookingDatelbl;
        private System.Windows.Forms.Label MemberNamelbl;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.Button DeleteBookingbtn;
        public System.Windows.Forms.TextBox txtMemberName;
        public System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.DateTimePicker BookingDateDtTimePckr;
        public System.Windows.Forms.TextBox txtLocation;
        public System.Windows.Forms.TextBox txtRoomName;
        public System.Windows.Forms.TextBox txtNoOfPax;
        private System.Windows.Forms.Label NoOfPaxlbl;
        private System.Windows.Forms.Button printButton;
    }
}