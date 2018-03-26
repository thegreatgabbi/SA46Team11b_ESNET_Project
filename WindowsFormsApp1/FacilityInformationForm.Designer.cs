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
            this.FactGroupBox = new System.Windows.Forms.GroupBox();
            this.nodateCheckbox = new System.Windows.Forms.CheckBox();
            this.MaintenanceDateDPicker = new System.Windows.Forms.DateTimePicker();
            this.maintanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FactGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).BeginInit();
            this.FactGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteLink
            // 
            this.DeleteLink.AutoSize = true;
            this.DeleteLink.LinkColor = System.Drawing.Color.Blue;
            this.DeleteLink.Location = new System.Drawing.Point(608, 73);
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
            this.updateLink.Location = new System.Drawing.Point(608, 42);
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
            this.LocationTextBox.Location = new System.Drawing.Point(474, 129);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(123, 38);
            this.LocationTextBox.TabIndex = 88;
            // 
            // AllowedHoursTextBox
            // 
            this.AllowedHoursTextBox.Location = new System.Drawing.Point(473, 197);
            this.AllowedHoursTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllowedHoursTextBox.Name = "AllowedHoursTextBox";
            this.AllowedHoursTextBox.Size = new System.Drawing.Size(121, 38);
            this.AllowedHoursTextBox.TabIndex = 83;
            // 
            // FacilityNameTextBox
            // 
            this.FacilityNameTextBox.Location = new System.Drawing.Point(473, 63);
            this.FacilityNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityNameTextBox.Name = "FacilityNameTextBox";
            this.FacilityNameTextBox.Size = new System.Drawing.Size(121, 38);
            this.FacilityNameTextBox.TabIndex = 79;
            // 
            // FacilityIDTextBox
            // 
            this.FacilityIDTextBox.Location = new System.Drawing.Point(171, 66);
            this.FacilityIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityIDTextBox.Name = "FacilityIDTextBox";
            this.FacilityIDTextBox.ReadOnly = true;
            this.FacilityIDTextBox.Size = new System.Drawing.Size(136, 38);
            this.FacilityIDTextBox.TabIndex = 78;
            // 
            // FacilityTypeTextBox
            // 
            this.FacilityTypeTextBox.Location = new System.Drawing.Point(171, 135);
            this.FacilityTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityTypeTextBox.Name = "FacilityTypeTextBox";
            this.FacilityTypeTextBox.Size = new System.Drawing.Size(176, 38);
            this.FacilityTypeTextBox.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 31);
            this.label11.TabIndex = 76;
            this.label11.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 31);
            this.label7.TabIndex = 72;
            this.label7.Text = "Allowed Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 31);
            this.label3.TabIndex = 68;
            this.label3.Text = "Facility Name";
            // 
            // facilityType
            // 
            this.facilityType.AutoSize = true;
            this.facilityType.Location = new System.Drawing.Point(30, 127);
            this.facilityType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.facilityType.Name = "facilityType";
            this.facilityType.Size = new System.Drawing.Size(168, 31);
            this.facilityType.TabIndex = 67;
            this.facilityType.Text = "Facility Type";
            // 
            // facilityIDlabel
            // 
            this.facilityIDlabel.AutoSize = true;
            this.facilityIDlabel.Location = new System.Drawing.Point(30, 66);
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
            this.FactGridView.Location = new System.Drawing.Point(36, 97);
            this.FactGridView.Margin = new System.Windows.Forms.Padding(4);
            this.FactGridView.Name = "FactGridView";
            this.FactGridView.ReadOnly = true;
            this.FactGridView.RowTemplate.Height = 33;
            this.FactGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FactGridView.Size = new System.Drawing.Size(780, 237);
            this.FactGridView.TabIndex = 14;
            this.FactGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FactGridView_CellClick);
            // 
            // addNewFacilityButton
            // 
            this.addNewFacilityButton.Location = new System.Drawing.Point(535, 39);
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
            this.searchFacilityTextBox.Location = new System.Drawing.Point(37, 38);
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
            this.searchPic.Location = new System.Drawing.Point(263, 36);
            this.searchPic.Margin = new System.Windows.Forms.Padding(4);
            this.searchPic.Name = "searchPic";
            this.searchPic.Size = new System.Drawing.Size(43, 47);
            this.searchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPic.TabIndex = 12;
            this.searchPic.TabStop = false;
            this.searchPic.Click += new System.EventHandler(this.searchPic_Click);
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
            this.FactGroupBox.Location = new System.Drawing.Point(36, 342);
            this.FactGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.FactGroupBox.Name = "FactGroupBox";
            this.FactGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.FactGroupBox.Size = new System.Drawing.Size(780, 349);
            this.FactGroupBox.TabIndex = 16;
            this.FactGroupBox.TabStop = false;
            this.FactGroupBox.Text = "Facility Information Details";
            // 
            // nodateCheckbox
            // 
            this.nodateCheckbox.AutoSize = true;
            this.nodateCheckbox.Location = new System.Drawing.Point(32, 250);
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
            this.MaintenanceDateDPicker.Location = new System.Drawing.Point(171, 194);
            this.MaintenanceDateDPicker.Margin = new System.Windows.Forms.Padding(4);
            this.MaintenanceDateDPicker.Name = "MaintenanceDateDPicker";
            this.MaintenanceDateDPicker.Size = new System.Drawing.Size(176, 38);
            this.MaintenanceDateDPicker.TabIndex = 92;
            this.MaintenanceDateDPicker.ValueChanged += new System.EventHandler(this.MaintenanceDateDPicker_ValueChanged_1);
            // 
            // maintanceLabel
            // 
            this.maintanceLabel.AutoSize = true;
            this.maintanceLabel.Location = new System.Drawing.Point(26, 191);
            this.maintanceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.maintanceLabel.Name = "maintanceLabel";
            this.maintanceLabel.Size = new System.Drawing.Size(234, 31);
            this.maintanceLabel.TabIndex = 91;
            this.maintanceLabel.Text = "Maintenance Date";
            // 
            // FacilityInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 704);
            this.Controls.Add(this.FactGridView);
            this.Controls.Add(this.addNewFacilityButton);
            this.Controls.Add(this.searchFacilityTextBox);
            this.Controls.Add(this.searchPic);
            this.Controls.Add(this.FactGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacilityInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FacilityInformationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FacilityInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FactGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).EndInit();
            this.FactGroupBox.ResumeLayout(false);
            this.FactGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox FactGroupBox;
        private System.Windows.Forms.DateTimePicker MaintenanceDateDPicker;
        private System.Windows.Forms.Label maintanceLabel;
        private System.Windows.Forms.CheckBox nodateCheckbox;
    }
}