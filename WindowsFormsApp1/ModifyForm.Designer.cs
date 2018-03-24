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
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.BookingTolbl = new System.Windows.Forms.Label();
            this.BookingFromlbl = new System.Windows.Forms.Label();
            this.BookingDatelbl = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.MemberNamelbl = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.DeleteBookingbtn = new System.Windows.Forms.Button();
            this.Printbtn = new System.Windows.Forms.Button();
            this.grpMemberDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // MakeBookinglbl
            // 
            this.MakeBookinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBookinglbl.Location = new System.Drawing.Point(12, 9);
            this.MakeBookinglbl.Name = "MakeBookinglbl";
            this.MakeBookinglbl.Size = new System.Drawing.Size(258, 46);
            this.MakeBookinglbl.TabIndex = 16;
            this.MakeBookinglbl.Text = "Modify Booking";
            this.MakeBookinglbl.Click += new System.EventHandler(this.MakeBookinglbl_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(513, 394);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(91, 44);
            this.Cancelbtn.TabIndex = 34;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            // 
            // LookUpBtn
            // 
            this.LookUpBtn.Location = new System.Drawing.Point(300, 85);
            this.LookUpBtn.Name = "LookUpBtn";
            this.LookUpBtn.Size = new System.Drawing.Size(38, 24);
            this.LookUpBtn.TabIndex = 22;
            this.LookUpBtn.Text = "...";
            this.LookUpBtn.UseVisualStyleBackColor = true;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(181, 131);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(208, 22);
            this.txtMemberName.TabIndex = 21;
            // 
            // Modifybtn
            // 
            this.Modifybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifybtn.Location = new System.Drawing.Point(71, 394);
            this.Modifybtn.Name = "Modifybtn";
            this.Modifybtn.Size = new System.Drawing.Size(89, 44);
            this.Modifybtn.TabIndex = 33;
            this.Modifybtn.Text = "Modify";
            this.Modifybtn.UseVisualStyleBackColor = true;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(181, 85);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 20;
            // 
            // Locationlbl
            // 
            this.Locationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locationlbl.Location = new System.Drawing.Point(31, 94);
            this.Locationlbl.Name = "Locationlbl";
            this.Locationlbl.Size = new System.Drawing.Size(109, 38);
            this.Locationlbl.TabIndex = 26;
            this.Locationlbl.Text = "Location";
            this.Locationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RoomNamelbl
            // 
            this.RoomNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNamelbl.Location = new System.Drawing.Point(6, 18);
            this.RoomNamelbl.Name = "RoomNamelbl";
            this.RoomNamelbl.Size = new System.Drawing.Size(139, 46);
            this.RoomNamelbl.TabIndex = 23;
            this.RoomNamelbl.Text = "Room Name";
            this.RoomNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemberIDlbl
            // 
            this.MemberIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDlbl.Location = new System.Drawing.Point(32, 85);
            this.MemberIDlbl.Name = "MemberIDlbl";
            this.MemberIDlbl.Size = new System.Drawing.Size(122, 28);
            this.MemberIDlbl.TabIndex = 18;
            this.MemberIDlbl.Text = "Member ID";
            this.MemberIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingToTime
            // 
            this.BookingToTime.Location = new System.Drawing.Point(580, 146);
            this.BookingToTime.Name = "BookingToTime";
            this.BookingToTime.Size = new System.Drawing.Size(100, 22);
            this.BookingToTime.TabIndex = 32;
            // 
            // BookingFromTime
            // 
            this.BookingFromTime.Location = new System.Drawing.Point(580, 82);
            this.BookingFromTime.Name = "BookingFromTime";
            this.BookingFromTime.Size = new System.Drawing.Size(100, 22);
            this.BookingFromTime.TabIndex = 31;
            this.BookingFromTime.Value = new System.DateTime(2018, 3, 23, 10, 48, 0, 0);
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Location = new System.Drawing.Point(580, 33);
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.ReadOnly = true;
            this.txtBookingDate.Size = new System.Drawing.Size(100, 22);
            this.txtBookingDate.TabIndex = 24;
            // 
            // BookingTolbl
            // 
            this.BookingTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTolbl.Location = new System.Drawing.Point(404, 133);
            this.BookingTolbl.Name = "BookingTolbl";
            this.BookingTolbl.Size = new System.Drawing.Size(140, 35);
            this.BookingTolbl.TabIndex = 30;
            this.BookingTolbl.Text = "Booking To";
            this.BookingTolbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingFromlbl
            // 
            this.BookingFromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingFromlbl.Location = new System.Drawing.Point(383, 71);
            this.BookingFromlbl.Name = "BookingFromlbl";
            this.BookingFromlbl.Size = new System.Drawing.Size(164, 42);
            this.BookingFromlbl.TabIndex = 29;
            this.BookingFromlbl.Text = "Booking From";
            this.BookingFromlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookingDatelbl
            // 
            this.BookingDatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDatelbl.Location = new System.Drawing.Point(383, 18);
            this.BookingDatelbl.Name = "BookingDatelbl";
            this.BookingDatelbl.Size = new System.Drawing.Size(161, 46);
            this.BookingDatelbl.TabIndex = 28;
            this.BookingDatelbl.Text = "Booking Date";
            this.BookingDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(160, 110);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 25;
            // 
            // MemberNamelbl
            // 
            this.MemberNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNamelbl.Location = new System.Drawing.Point(12, 120);
            this.MemberNamelbl.Name = "MemberNamelbl";
            this.MemberNamelbl.Size = new System.Drawing.Size(159, 38);
            this.MemberNamelbl.TabIndex = 19;
            this.MemberNamelbl.Text = "Member Name ";
            this.MemberNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(160, 33);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.Size = new System.Drawing.Size(185, 22);
            this.txtRoomName.TabIndex = 27;
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.RoomNamelbl);
            this.grpMemberDetails.Controls.Add(this.txtRoomName);
            this.grpMemberDetails.Controls.Add(this.BookingDatelbl);
            this.grpMemberDetails.Controls.Add(this.txtBookingDate);
            this.grpMemberDetails.Controls.Add(this.BookingFromlbl);
            this.grpMemberDetails.Controls.Add(this.BookingFromTime);
            this.grpMemberDetails.Controls.Add(this.BookingTolbl);
            this.grpMemberDetails.Controls.Add(this.BookingToTime);
            this.grpMemberDetails.Controls.Add(this.Locationlbl);
            this.grpMemberDetails.Controls.Add(this.txtLocation);
            this.grpMemberDetails.Location = new System.Drawing.Point(31, 176);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(739, 204);
            this.grpMemberDetails.TabIndex = 35;
            this.grpMemberDetails.TabStop = false;
            // 
            // DeleteBookingbtn
            // 
            this.DeleteBookingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookingbtn.Location = new System.Drawing.Point(258, 394);
            this.DeleteBookingbtn.Name = "DeleteBookingbtn";
            this.DeleteBookingbtn.Size = new System.Drawing.Size(192, 44);
            this.DeleteBookingbtn.TabIndex = 36;
            this.DeleteBookingbtn.Text = "Delete Booking";
            this.DeleteBookingbtn.UseVisualStyleBackColor = true;
            this.DeleteBookingbtn.Click += new System.EventHandler(this.DeleteBookingbtn_Click);
            // 
            // Printbtn
            // 
            this.Printbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.Location = new System.Drawing.Point(526, 24);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(175, 40);
            this.Printbtn.TabIndex = 37;
            this.Printbtn.Text = "Re-Print Receipt";
            this.Printbtn.UseVisualStyleBackColor = true;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Printbtn);
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
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Button Modifybtn;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label Locationlbl;
        private System.Windows.Forms.Label RoomNamelbl;
        private System.Windows.Forms.Label MemberIDlbl;
        private System.Windows.Forms.DateTimePicker BookingToTime;
        private System.Windows.Forms.DateTimePicker BookingFromTime;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.Label BookingTolbl;
        private System.Windows.Forms.Label BookingFromlbl;
        private System.Windows.Forms.Label BookingDatelbl;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label MemberNamelbl;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.Button DeleteBookingbtn;
        private System.Windows.Forms.Button Printbtn;
    }
}