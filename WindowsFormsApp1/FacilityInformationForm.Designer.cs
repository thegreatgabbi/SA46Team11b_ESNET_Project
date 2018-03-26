namespace WindowsFormsApp1
{
    partial class FacilityInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacilityInformationForm));
            this.DeleteLink = new System.Windows.Forms.LinkLabel();
            this.updateLink = new System.Windows.Forms.LinkLabel();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.AllowedHoursTextBox = new System.Windows.Forms.TextBox();
            this.FacilityNameTextBox = new System.Windows.Forms.TextBox();
            this.FacilityIDTextBox = new System.Windows.Forms.TextBox();
            this.FacilityTypeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.facilityType = new System.Windows.Forms.Label();
            this.facilityIDlabel = new System.Windows.Forms.Label();
            this.FactGridView = new System.Windows.Forms.DataGridView();
            this.addNewFacilityButton = new System.Windows.Forms.Button();
            this.searchFacilityTextBox = new System.Windows.Forms.TextBox();
            this.searchPic = new System.Windows.Forms.PictureBox();
            this.facilityInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FactGroupBox = new System.Windows.Forms.GroupBox();
            this.nodateCheckbox = new System.Windows.Forms.CheckBox();
            this.MaintenanceDateDPicker = new System.Windows.Forms.DateTimePicker();
            this.maintanceLabel = new System.Windows.Forms.Label();
            this.FacilityMenuStrip = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.FactGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).BeginInit();
            this.FactGroupBox.SuspendLayout();
            this.FacilityMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteLink
            // 
            this.DeleteLink.AutoSize = true;
            this.DeleteLink.LinkColor = System.Drawing.Color.Blue;
            this.DeleteLink.Location = new System.Drawing.Point(591, 52);
            this.DeleteLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteLink.Name = "DeleteLink";
            this.DeleteLink.Size = new System.Drawing.Size(93, 31);
            this.DeleteLink.TabIndex = 90;
            this.DeleteLink.TabStop = true;
            this.DeleteLink.Text = "Delete";
            this.DeleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteLink_LinkClicked);
            // 
            // updateLink
            // 
            this.updateLink.AutoSize = true;
            this.updateLink.Location = new System.Drawing.Point(591, 21);
            this.updateLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updateLink.Name = "updateLink";
            this.updateLink.Size = new System.Drawing.Size(102, 31);
            this.updateLink.TabIndex = 89;
            this.updateLink.TabStop = true;
            this.updateLink.Text = "Update";
            this.updateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateLink_LinkClicked);
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(455, 97);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(122, 38);
            this.LocationTextBox.TabIndex = 88;
            // 
            // AllowedHoursTextBox
            // 
            this.AllowedHoursTextBox.Location = new System.Drawing.Point(456, 145);
            this.AllowedHoursTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllowedHoursTextBox.Name = "AllowedHoursTextBox";
            this.AllowedHoursTextBox.Size = new System.Drawing.Size(121, 38);
            this.AllowedHoursTextBox.TabIndex = 83;
            // 
            // FacilityNameTextBox
            // 
            this.FacilityNameTextBox.Location = new System.Drawing.Point(456, 38);
            this.FacilityNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityNameTextBox.Name = "FacilityNameTextBox";
            this.FacilityNameTextBox.Size = new System.Drawing.Size(121, 38);
            this.FacilityNameTextBox.TabIndex = 79;
            // 
            // FacilityIDTextBox
            // 
            this.FacilityIDTextBox.Location = new System.Drawing.Point(154, 45);
            this.FacilityIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityIDTextBox.Name = "FacilityIDTextBox";
            this.FacilityIDTextBox.ReadOnly = true;
            this.FacilityIDTextBox.Size = new System.Drawing.Size(136, 38);
            this.FacilityIDTextBox.TabIndex = 78;
            // 
            // FacilityTypeTextBox
            // 
            this.FacilityTypeTextBox.Location = new System.Drawing.Point(154, 97);
            this.FacilityTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityTypeTextBox.Name = "FacilityTypeTextBox";
            this.FacilityTypeTextBox.Size = new System.Drawing.Size(176, 38);
            this.FacilityTypeTextBox.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(336, 95);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 31);
            this.label11.TabIndex = 76;
            this.label11.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 31);
            this.label7.TabIndex = 72;
            this.label7.Text = "Allowed Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 31);
            this.label3.TabIndex = 68;
            this.label3.Text = "Facility Name";
            // 
            // facilityType
            // 
            this.facilityType.AutoSize = true;
            this.facilityType.Location = new System.Drawing.Point(13, 89);
            this.facilityType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.facilityType.Name = "facilityType";
            this.facilityType.Size = new System.Drawing.Size(168, 31);
            this.facilityType.TabIndex = 67;
            this.facilityType.Text = "Facility Type";
            // 
            // facilityIDlabel
            // 
            this.facilityIDlabel.AutoSize = true;
            this.facilityIDlabel.Location = new System.Drawing.Point(13, 45);
            this.facilityIDlabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.facilityIDlabel.Name = "facilityIDlabel";
            this.facilityIDlabel.Size = new System.Drawing.Size(135, 31);
            this.facilityIDlabel.TabIndex = 66;
            this.facilityIDlabel.Text = "Facility ID";
            // 
            // FactGridView
            // 
            this.FactGridView.AllowUserToOrderColumns = true;
            this.FactGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FactGridView.Location = new System.Drawing.Point(23, 96);
            this.FactGridView.Margin = new System.Windows.Forms.Padding(4);
            this.FactGridView.Name = "FactGridView";
            this.FactGridView.ReadOnly = true;
            this.FactGridView.RowTemplate.Height = 33;
            this.FactGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FactGridView.Size = new System.Drawing.Size(660, 237);
            this.FactGridView.TabIndex = 14;
            this.FactGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FactGridView_CellClick);
            // 
            // addNewFacilityButton
            // 
            this.addNewFacilityButton.Location = new System.Drawing.Point(402, 43);
            this.addNewFacilityButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewFacilityButton.Name = "addNewFacilityButton";
            this.addNewFacilityButton.Size = new System.Drawing.Size(281, 46);
            this.addNewFacilityButton.TabIndex = 15;
            this.addNewFacilityButton.Text = "+ Add New Facility";
            this.addNewFacilityButton.UseVisualStyleBackColor = true;
            this.addNewFacilityButton.Click += new System.EventHandler(this.addNewFacilityButton_Click);
            // 
            // searchFacilityTextBox
            // 
            this.searchFacilityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchFacilityTextBox.Location = new System.Drawing.Point(24, 42);
            this.searchFacilityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchFacilityTextBox.Multiline = true;
            this.searchFacilityTextBox.Name = "searchFacilityTextBox";
            this.searchFacilityTextBox.Size = new System.Drawing.Size(223, 45);
            this.searchFacilityTextBox.TabIndex = 13;
            // 
            // searchPic
            // 
            this.searchPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPic.Image = ((System.Drawing.Image)(resources.GetObject("searchPic.Image")));
            this.searchPic.Location = new System.Drawing.Point(250, 40);
            this.searchPic.Margin = new System.Windows.Forms.Padding(4);
            this.searchPic.Name = "searchPic";
            this.searchPic.Size = new System.Drawing.Size(43, 47);
            this.searchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPic.TabIndex = 12;
            this.searchPic.TabStop = false;
            this.searchPic.Click += new System.EventHandler(this.searchPic_Click);
            // 
            // facilityInformationToolStripMenuItem
            // 
            this.facilityInformationToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.facilityInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityInformationToolStripMenuItem.Name = "facilityInformationToolStripMenuItem";
            this.facilityInformationToolStripMenuItem.Size = new System.Drawing.Size(255, 38);
            this.facilityInformationToolStripMenuItem.Text = "Facility Information";
            this.facilityInformationToolStripMenuItem.Click += new System.EventHandler(this.FacilityInformationToolStripMenuItem_Click);
            // 
            // memberInformationToolStripMenuItem
            // 
            this.memberInformationToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.memberInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInformationToolStripMenuItem.Name = "memberInformationToolStripMenuItem";
            this.memberInformationToolStripMenuItem.Size = new System.Drawing.Size(267, 35);
            this.memberInformationToolStripMenuItem.Text = "Member Information";
            this.memberInformationToolStripMenuItem.Click += new System.EventHandler(this.memberInformationToolStripMenuItem_Click);
            // 
            // bookingInformationToolStripMenuItem
            // 
            this.bookingInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingInformationToolStripMenuItem.Name = "bookingInformationToolStripMenuItem";
            this.bookingInformationToolStripMenuItem.Size = new System.Drawing.Size(267, 35);
            this.bookingInformationToolStripMenuItem.Text = "Booking Information";
            this.bookingInformationToolStripMenuItem.Click += new System.EventHandler(this.bookingInformationToolStripMenuItem_Click);
            // 
            // bookFacilityToolStripMenuItem
            // 
            this.bookFacilityToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookFacilityToolStripMenuItem.Name = "bookFacilityToolStripMenuItem";
            this.bookFacilityToolStripMenuItem.Size = new System.Drawing.Size(181, 35);
            this.bookFacilityToolStripMenuItem.Text = "Book Facility";
            // 
            // FactGroupBox
            // 
            this.FactGroupBox.Controls.Add(this.nodateCheckbox);
            this.FactGroupBox.Controls.Add(this.MaintenanceDateDPicker);
            this.FactGroupBox.Controls.Add(this.maintanceLabel);
            this.FactGroupBox.Controls.Add(this.DeleteLink);
            this.FactGroupBox.Controls.Add(this.updateLink);
            this.FactGroupBox.Controls.Add(this.LocationTextBox);
            this.FactGroupBox.Controls.Add(this.AllowedHoursTextBox);
            this.FactGroupBox.Controls.Add(this.FacilityNameTextBox);
            this.FactGroupBox.Controls.Add(this.FacilityIDTextBox);
            this.FactGroupBox.Controls.Add(this.FacilityTypeTextBox);
            this.FactGroupBox.Controls.Add(this.label11);
            this.FactGroupBox.Controls.Add(this.label7);
            this.FactGroupBox.Controls.Add(this.label3);
            this.FactGroupBox.Controls.Add(this.facilityType);
            this.FactGroupBox.Controls.Add(this.facilityIDlabel);
            this.FactGroupBox.Location = new System.Drawing.Point(23, 341);
            this.FactGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.FactGroupBox.Name = "FactGroupBox";
            this.FactGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.FactGroupBox.Size = new System.Drawing.Size(660, 220);
            this.FactGroupBox.TabIndex = 16;
            this.FactGroupBox.TabStop = false;
            this.FactGroupBox.Text = "Facility Information Details";
            // 
            // nodateCheckbox
            // 
            this.nodateCheckbox.AutoSize = true;
            this.nodateCheckbox.Location = new System.Drawing.Point(19, 184);
            this.nodateCheckbox.Name = "nodateCheckbox";
            this.nodateCheckbox.Size = new System.Drawing.Size(308, 35);
            this.nodateCheckbox.TabIndex = 93;
            this.nodateCheckbox.Text = "No Maintenance Date";
            this.nodateCheckbox.UseVisualStyleBackColor = true;
            this.nodateCheckbox.CheckedChanged += new System.EventHandler(this.nodateCheckbox_CheckedChanged);
            // 
            // MaintenanceDateDPicker
            // 
            this.MaintenanceDateDPicker.CustomFormat = "dd-MM-yyyy";
            this.MaintenanceDateDPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MaintenanceDateDPicker.Location = new System.Drawing.Point(154, 142);
            this.MaintenanceDateDPicker.Margin = new System.Windows.Forms.Padding(4);
            this.MaintenanceDateDPicker.Name = "MaintenanceDateDPicker";
            this.MaintenanceDateDPicker.Size = new System.Drawing.Size(176, 38);
            this.MaintenanceDateDPicker.TabIndex = 92;
            this.MaintenanceDateDPicker.ValueChanged += new System.EventHandler(this.MaintenanceDateDPicker_ValueChanged_1);
            // 
            // maintanceLabel
            // 
            this.maintanceLabel.AutoSize = true;
            this.maintanceLabel.Location = new System.Drawing.Point(9, 139);
            this.maintanceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maintanceLabel.Name = "maintanceLabel";
            this.maintanceLabel.Size = new System.Drawing.Size(234, 31);
            this.maintanceLabel.TabIndex = 91;
            this.maintanceLabel.Text = "Maintenance Date";
            // 
            // FacilityMenuStrip
            // 
            this.FacilityMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.FacilityMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookFacilityToolStripMenuItem,
            this.bookingInformationToolStripMenuItem,
            this.memberInformationToolStripMenuItem,
            this.facilityInformationToolStripMenuItem});
            this.FacilityMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.FacilityMenuStrip.Name = "FacilityMenuStrip";
            this.FacilityMenuStrip.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.FacilityMenuStrip.Size = new System.Drawing.Size(694, 39);
            this.FacilityMenuStrip.TabIndex = 11;
            this.FacilityMenuStrip.Text = "MainMenuStrip";
            // 
            // FacilityInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 573);
            this.Controls.Add(this.FactGridView);
            this.Controls.Add(this.addNewFacilityButton);
            this.Controls.Add(this.searchFacilityTextBox);
            this.Controls.Add(this.searchPic);
            this.Controls.Add(this.FactGroupBox);
            this.Controls.Add(this.FacilityMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacilityInformationForm";
            this.Text = "FacilityInformationForm";
            this.Load += new System.EventHandler(this.FacilityInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FactGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).EndInit();
            this.FactGroupBox.ResumeLayout(false);
            this.FactGroupBox.PerformLayout();
            this.FacilityMenuStrip.ResumeLayout(false);
            this.FacilityMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel DeleteLink;
        private System.Windows.Forms.LinkLabel updateLink;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox AllowedHoursTextBox;
        private System.Windows.Forms.TextBox FacilityNameTextBox;
        private System.Windows.Forms.TextBox FacilityIDTextBox;
        private System.Windows.Forms.TextBox FacilityTypeTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label facilityType;
        private System.Windows.Forms.Label facilityIDlabel;
        public System.Windows.Forms.DataGridView FactGridView;
        private System.Windows.Forms.Button addNewFacilityButton;
        private System.Windows.Forms.TextBox searchFacilityTextBox;
        private System.Windows.Forms.PictureBox searchPic;
        private System.Windows.Forms.ToolStripMenuItem facilityInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookFacilityToolStripMenuItem;
        private System.Windows.Forms.GroupBox FactGroupBox;
        private System.Windows.Forms.MenuStrip FacilityMenuStrip;
        private System.Windows.Forms.DateTimePicker MaintenanceDateDPicker;
        private System.Windows.Forms.Label maintanceLabel;
        private System.Windows.Forms.CheckBox nodateCheckbox;
    }
}