namespace WindowsFormsApp1
{
    partial class BookingInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingInformationForm));
            this.DeleteLink = new System.Windows.Forms.LinkLabel();
            this.updateBooking = new System.Windows.Forms.LinkLabel();
            this.facilityNameTextBox = new System.Windows.Forms.TextBox();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.BookingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BookingIDTextBox = new System.Windows.Forms.TextBox();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MakeNewBookingButton = new System.Windows.Forms.Button();
            this.searchBookingTextBox = new System.Windows.Forms.TextBox();
            this.searchPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numOfPaxTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.bookingGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteLink
            // 
            this.DeleteLink.AutoSize = true;
            this.DeleteLink.LinkColor = System.Drawing.Color.Blue;
            this.DeleteLink.Location = new System.Drawing.Point(747, 67);
            this.DeleteLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteLink.Name = "DeleteLink";
            this.DeleteLink.Size = new System.Drawing.Size(93, 31);
            this.DeleteLink.TabIndex = 90;
            this.DeleteLink.TabStop = true;
            this.DeleteLink.Text = "Delete";
            this.DeleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteLink_LinkClicked);
            // 
            // updateBooking
            // 
            this.updateBooking.AutoSize = true;
            this.updateBooking.Location = new System.Drawing.Point(747, 35);
            this.updateBooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updateBooking.Name = "updateBooking";
            this.updateBooking.Size = new System.Drawing.Size(102, 31);
            this.updateBooking.TabIndex = 89;
            this.updateBooking.TabStop = true;
            this.updateBooking.Text = "Update";
            this.updateBooking.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateBooking_LinkClicked);
            // 
            // facilityNameTextBox
            // 
            this.facilityNameTextBox.Location = new System.Drawing.Point(209, 160);
            this.facilityNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.facilityNameTextBox.Name = "facilityNameTextBox";
            this.facilityNameTextBox.ReadOnly = true;
            this.facilityNameTextBox.Size = new System.Drawing.Size(215, 38);
            this.facilityNameTextBox.TabIndex = 88;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(616, 110);
            this.memberIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.ReadOnly = true;
            this.memberIDTextBox.Size = new System.Drawing.Size(138, 38);
            this.memberIDTextBox.TabIndex = 85;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(208, 210);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(216, 38);
            this.locationTextBox.TabIndex = 83;
            // 
            // BookingDatePicker
            // 
            this.BookingDatePicker.CustomFormat = "dd-MM-yyyy";
            this.BookingDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BookingDatePicker.Location = new System.Drawing.Point(616, 160);
            this.BookingDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.BookingDatePicker.Name = "BookingDatePicker";
            this.BookingDatePicker.Size = new System.Drawing.Size(138, 38);
            this.BookingDatePicker.TabIndex = 80;
            // 
            // BookingIDTextBox
            // 
            this.BookingIDTextBox.Location = new System.Drawing.Point(208, 51);
            this.BookingIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookingIDTextBox.Name = "BookingIDTextBox";
            this.BookingIDTextBox.ReadOnly = true;
            this.BookingIDTextBox.Size = new System.Drawing.Size(170, 38);
            this.BookingIDTextBox.TabIndex = 78;
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.Location = new System.Drawing.Point(208, 110);
            this.memberNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.ReadOnly = true;
            this.memberNameTextBox.Size = new System.Drawing.Size(274, 38);
            this.memberNameTextBox.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 160);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 31);
            this.label11.TabIndex = 76;
            this.label11.Text = "Facility Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 31);
            this.label9.TabIndex = 74;
            this.label9.Text = "Booking From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 31);
            this.label6.TabIndex = 71;
            this.label6.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 31);
            this.label4.TabIndex = 69;
            this.label4.Text = "Booking Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 68;
            this.label3.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 31);
            this.label2.TabIndex = 67;
            this.label2.Text = "Member Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 66;
            this.label1.Text = "Booking ID";
            // 
            // MakeNewBookingButton
            // 
            this.MakeNewBookingButton.Location = new System.Drawing.Point(674, 33);
            this.MakeNewBookingButton.Margin = new System.Windows.Forms.Padding(4);
            this.MakeNewBookingButton.Name = "MakeNewBookingButton";
            this.MakeNewBookingButton.Size = new System.Drawing.Size(281, 46);
            this.MakeNewBookingButton.TabIndex = 15;
            this.MakeNewBookingButton.Text = "+ Make New Booking";
            this.MakeNewBookingButton.UseVisualStyleBackColor = true;
            this.MakeNewBookingButton.Click += new System.EventHandler(this.MakeNewBookingButton_Click);
            // 
            // searchBookingTextBox
            // 
            this.searchBookingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookingTextBox.Location = new System.Drawing.Point(102, 41);
            this.searchBookingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBookingTextBox.Multiline = true;
            this.searchBookingTextBox.Name = "searchBookingTextBox";
            this.searchBookingTextBox.Size = new System.Drawing.Size(223, 45);
            this.searchBookingTextBox.TabIndex = 13;
            // 
            // searchPic
            // 
            this.searchPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPic.Image = ((System.Drawing.Image)(resources.GetObject("searchPic.Image")));
            this.searchPic.Location = new System.Drawing.Point(333, 41);
            this.searchPic.Margin = new System.Windows.Forms.Padding(4);
            this.searchPic.Name = "searchPic";
            this.searchPic.Size = new System.Drawing.Size(38, 45);
            this.searchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPic.TabIndex = 12;
            this.searchPic.TabStop = false;
            this.searchPic.Click += new System.EventHandler(this.searchPic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numOfPaxTextBox);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DeleteLink);
            this.groupBox1.Controls.Add(this.updateBooking);
            this.groupBox1.Controls.Add(this.facilityNameTextBox);
            this.groupBox1.Controls.Add(this.memberIDTextBox);
            this.groupBox1.Controls.Add(this.locationTextBox);
            this.groupBox1.Controls.Add(this.BookingDatePicker);
            this.groupBox1.Controls.Add(this.BookingIDTextBox);
            this.groupBox1.Controls.Add(this.memberNameTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(102, 348);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(890, 322);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Information Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 31);
            this.label7.TabIndex = 97;
            this.label7.Text = "Number of People";
            // 
            // numOfPaxTextBox
            // 
            this.numOfPaxTextBox.Location = new System.Drawing.Point(208, 262);
            this.numOfPaxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numOfPaxTextBox.Name = "numOfPaxTextBox";
            this.numOfPaxTextBox.Size = new System.Drawing.Size(216, 38);
            this.numOfPaxTextBox.TabIndex = 96;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTo.Location = new System.Drawing.Point(616, 263);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.ShowUpDown = true;
            this.dateTimePickerTo.Size = new System.Drawing.Size(164, 38);
            this.dateTimePickerTo.TabIndex = 95;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(616, 213);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.ShowUpDown = true;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(164, 38);
            this.dateTimePickerFrom.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 93;
            this.label5.Text = "Booking To";
            // 
            // bookingGridView
            // 
            this.bookingGridView.AllowUserToOrderColumns = true;
            this.bookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingGridView.Location = new System.Drawing.Point(102, 94);
            this.bookingGridView.Margin = new System.Windows.Forms.Padding(4);
            this.bookingGridView.Name = "bookingGridView";
            this.bookingGridView.ReadOnly = true;
            this.bookingGridView.RowTemplate.Height = 33;
            this.bookingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingGridView.Size = new System.Drawing.Size(890, 250);
            this.bookingGridView.TabIndex = 14;
            this.bookingGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingGridView_CellClick);
            // 
            // BookingInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1158, 704);
            this.Controls.Add(this.MakeNewBookingButton);
            this.Controls.Add(this.searchBookingTextBox);
            this.Controls.Add(this.searchPic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bookingGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookingInformationForm";
            this.Text = "Booking Information Form";
            this.Load += new System.EventHandler(this.BookingInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel DeleteLink;
        private System.Windows.Forms.LinkLabel updateBooking;
        private System.Windows.Forms.TextBox facilityNameTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.DateTimePicker BookingDatePicker;
        private System.Windows.Forms.TextBox BookingIDTextBox;
        private System.Windows.Forms.TextBox memberNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MakeNewBookingButton;
        private System.Windows.Forms.TextBox searchBookingTextBox;
        private System.Windows.Forms.PictureBox searchPic;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView bookingGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numOfPaxTextBox;
    }
}