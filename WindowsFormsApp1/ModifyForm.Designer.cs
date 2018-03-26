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
            this.MakeBookinglbl.Location = new System.Drawing.Point(24, 17);
            this.MakeBookinglbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MakeBookinglbl.Name = "MakeBookinglbl";
            this.MakeBookinglbl.Size = new System.Drawing.Size(516, 89);
            this.MakeBookinglbl.TabIndex = 16;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(1027, 764);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(181, 86);
            this.Cancelbtn.TabIndex = 34;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // LookUpBtn
            // 
            this.LookUpBtn.Location = new System.Drawing.Point(600, 165);
            this.LookUpBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LookUpBtn.Name = "LookUpBtn";
            this.LookUpBtn.Size = new System.Drawing.Size(76, 47);
            this.LookUpBtn.TabIndex = 22;
            this.LookUpBtn.Text = "...";
            this.LookUpBtn.UseVisualStyleBackColor = true;
            this.LookUpBtn.Click += new System.EventHandler(this.LookUpBtn_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(363, 254);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(412, 38);
            this.txtMemberName.TabIndex = 21;
            // 
            // Modifybtn
            // 
            this.Modifybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifybtn.Location = new System.Drawing.Point(141, 764);
            this.Modifybtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(179, 86);
            this.Modifybtn.TabIndex = 33;
            this.Modifybtn.Text = "Modify";
            this.Modifybtn.UseVisualStyleBackColor = true;
            this.Modifybtn.Click += new System.EventHandler(this.Modifybtn_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(363, 165);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(196, 38);
            this.txtMemberID.TabIndex = 20;
            // 
            // Locationlbl
            // 
            this.Locationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locationlbl.Location = new System.Drawing.Point(61, 182);
            this.Locationlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(219, 73);
            this.Locationlbl.TabIndex = 26;
            this.Locationlbl.Text = "Location";
            this.Locationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RoomNamelbl
            // 
            this.RoomNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNamelbl.Location = new System.Drawing.Point(12, 35);
            this.RoomNamelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RoomNamelbl.Name = "RoomNamelbl";
            this.RoomNamelbl.Size = new System.Drawing.Size(277, 89);
            this.RoomNamelbl.TabIndex = 23;
            this.RoomNamelbl.Text = "Facility Name";
            this.RoomNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemberIDlbl
            // 
            this.MemberIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDlbl.Location = new System.Drawing.Point(43, 105);
            this.MemberIDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberIDlbl.Name = "MemberIDlbl";
            this.MemberIDlbl.Size = new System.Drawing.Size(244, 55);
            this.MemberIDlbl.TabIndex = 18;
            this.MemberIDlbl.Text = "Member ID";
            this.MemberIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingToTime
            // 
            this.BookingToTime.CustomFormat = "HH:MM tt";
            this.BookingToTime.Location = new System.Drawing.Point(1160, 283);
            this.BookingToTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BookingToTime.Name = "BookingToTime";
            this.BookingToTime.Size = new System.Drawing.Size(196, 38);
            this.BookingToTime.TabIndex = 32;
            // 
            // BookingFromTime
            // 
            this.BookingFromTime.CustomFormat = "HH:MM tt";
            this.BookingFromTime.Location = new System.Drawing.Point(1160, 159);
            this.BookingFromTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BookingFromTime.Name = "BookingFromTime";
            this.BookingFromTime.Size = new System.Drawing.Size(196, 38);
            this.BookingFromTime.TabIndex = 31;
            this.BookingFromTime.TabStop = false;
            this.BookingFromTime.Value = new System.DateTime(2018, 3, 23, 10, 48, 0, 0);
            // 
            // BookingTolbl
            // 
            this.BookingTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTolbl.Location = new System.Drawing.Point(808, 258);
            this.BookingTolbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BookingTolbl.Name = "BookingTolbl";
            this.BookingTolbl.Size = new System.Drawing.Size(280, 68);
            this.BookingTolbl.TabIndex = 30;
            this.BookingTolbl.Text = "Booking To";
            this.BookingTolbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingFromlbl
            // 
            this.BookingFromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingFromlbl.Location = new System.Drawing.Point(765, 138);
            this.BookingFromlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BookingFromlbl.Name = "BookingFromlbl";
            this.BookingFromlbl.Size = new System.Drawing.Size(328, 82);
            this.BookingFromlbl.TabIndex = 29;
            this.BookingFromlbl.Text = "Booking From";
            this.BookingFromlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingDatelbl
            // 
            this.BookingDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDatelbl.Location = new System.Drawing.Point(765, 35);
            this.BookingDatelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BookingDatelbl.Name = "BookingDatelbl";
            this.BookingDatelbl.Size = new System.Drawing.Size(323, 89);
            this.BookingDatelbl.TabIndex = 28;
            this.BookingDatelbl.Text = "Booking Date";
            this.BookingDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(320, 213);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(196, 38);
            this.txtLocation.TabIndex = 25;
            // 
            // MemberNamelbl
            // 
            this.MemberNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNamelbl.Location = new System.Drawing.Point(24, 233);
            this.MemberNamelbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MemberNamelbl.Name = "MemberNamelbl";
            this.MemberNamelbl.Size = new System.Drawing.Size(317, 73);
            this.MemberNamelbl.TabIndex = 19;
            this.MemberNamelbl.Text = "Member Name ";
            this.MemberNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(320, 64);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.Size = new System.Drawing.Size(367, 38);
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
            this.grpMemberDetails.Location = new System.Drawing.Point(61, 341);
            this.grpMemberDetails.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpMemberDetails.Size = new System.Drawing.Size(1477, 396);
            this.grpMemberDetails.TabIndex = 35;
            this.grpMemberDetails.TabStop = false;
            // 
            // BookingDateDtTimePckr
            // 
            this.BookingDateDtTimePckr.Location = new System.Drawing.Point(1160, 60);
            this.BookingDateDtTimePckr.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BookingDateDtTimePckr.Name = "BookingDateDtTimePckr";
            this.BookingDateDtTimePckr.Size = new System.Drawing.Size(303, 38);
            this.BookingDateDtTimePckr.TabIndex = 33;
            // 
            // DeleteBookingbtn
            // 
            this.DeleteBookingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookingbtn.Location = new System.Drawing.Point(516, 764);
            this.DeleteBookingbtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.DeleteBookingbtn.Name = "DeleteBookingbtn";
            this.DeleteBookingbtn.Size = new System.Drawing.Size(384, 86);
            this.DeleteBookingbtn.TabIndex = 36;
            this.DeleteBookingbtn.Text = "Delete Booking";
            this.DeleteBookingbtn.UseVisualStyleBackColor = true;
            this.DeleteBookingbtn.Click += new System.EventHandler(this.DeleteBookingbtn_Click);
            // 
            // txtNoOfPax
            // 
            this.txtNoOfPax.Location = new System.Drawing.Point(1221, 263);
            this.txtNoOfPax.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNoOfPax.Name = "txtNoOfPax";
            this.txtNoOfPax.Size = new System.Drawing.Size(88, 38);
            this.txtNoOfPax.TabIndex = 39;
            // 
            // NoOfPaxlbl
            // 
            this.NoOfPaxlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfPaxlbl.Location = new System.Drawing.Point(896, 258);
            this.NoOfPaxlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoOfPaxlbl.Name = "NoOfPaxlbl";
            this.NoOfPaxlbl.Size = new System.Drawing.Size(253, 40);
            this.NoOfPaxlbl.TabIndex = 38;
            this.NoOfPaxlbl.Text = "# Persons";
            this.NoOfPaxlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(1259, 20);
            this.printButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(320, 79);
            this.printButton.TabIndex = 40;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
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
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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