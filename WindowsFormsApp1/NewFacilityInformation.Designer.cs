namespace WindowsFormsApp1
{
    partial class NewFacilityInformation
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
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.AllowedHoursTextBox = new System.Windows.Forms.TextBox();
            this.MaintananceDPicker = new System.Windows.Forms.DateTimePicker();
            this.FacilityTypeTextBox = new System.Windows.Forms.TextBox();
            this.FacilityNameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newMemGBox = new System.Windows.Forms.GroupBox();
            this.newFacilityCancelButton = new System.Windows.Forms.Button();
            this.NewFacilityAddButton = new System.Windows.Forms.Button();
            this.nomaintananceDateCheckbox = new System.Windows.Forms.CheckBox();
            this.newMemGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Location = new System.Drawing.Point(224, 222);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(336, 38);
            this.LocationTextBox.TabIndex = 43;
            // 
            // AllowedHoursTextBox
            // 
            this.AllowedHoursTextBox.Location = new System.Drawing.Point(224, 387);
            this.AllowedHoursTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllowedHoursTextBox.Name = "AllowedHoursTextBox";
            this.AllowedHoursTextBox.Size = new System.Drawing.Size(145, 38);
            this.AllowedHoursTextBox.TabIndex = 41;
            // 
            // MaintananceDPicker
            // 
            this.MaintananceDPicker.CustomFormat = "dd-MM-yyyy";
            this.MaintananceDPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MaintananceDPicker.Location = new System.Drawing.Point(224, 324);
            this.MaintananceDPicker.Margin = new System.Windows.Forms.Padding(4);
            this.MaintananceDPicker.Name = "MaintananceDPicker";
            this.MaintananceDPicker.Size = new System.Drawing.Size(225, 38);
            this.MaintananceDPicker.TabIndex = 36;
            // 
            // FacilityTypeTextBox
            // 
            this.FacilityTypeTextBox.Location = new System.Drawing.Point(225, 75);
            this.FacilityTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityTypeTextBox.Name = "FacilityTypeTextBox";
            this.FacilityTypeTextBox.Size = new System.Drawing.Size(335, 38);
            this.FacilityTypeTextBox.TabIndex = 35;
            // 
            // FacilityNameTextBox
            // 
            this.FacilityNameTextBox.Location = new System.Drawing.Point(224, 148);
            this.FacilityNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacilityNameTextBox.Name = "FacilityNameTextBox";
            this.FacilityNameTextBox.Size = new System.Drawing.Size(336, 38);
            this.FacilityNameTextBox.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 222);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "Allowed Hours";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(17, 324);
            this.datelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(234, 31);
            this.datelabel.TabIndex = 25;
            this.datelabel.Text = "Maintanance Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Facility Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Facility Name";
            // 
            // newMemGBox
            // 
            this.newMemGBox.Controls.Add(this.nomaintananceDateCheckbox);
            this.newMemGBox.Controls.Add(this.LocationTextBox);
            this.newMemGBox.Controls.Add(this.AllowedHoursTextBox);
            this.newMemGBox.Controls.Add(this.MaintananceDPicker);
            this.newMemGBox.Controls.Add(this.FacilityTypeTextBox);
            this.newMemGBox.Controls.Add(this.FacilityNameTextBox);
            this.newMemGBox.Controls.Add(this.label9);
            this.newMemGBox.Controls.Add(this.label7);
            this.newMemGBox.Controls.Add(this.datelabel);
            this.newMemGBox.Controls.Add(this.label3);
            this.newMemGBox.Controls.Add(this.label2);
            this.newMemGBox.Location = new System.Drawing.Point(15, 16);
            this.newMemGBox.Margin = new System.Windows.Forms.Padding(4);
            this.newMemGBox.Name = "newMemGBox";
            this.newMemGBox.Padding = new System.Windows.Forms.Padding(4);
            this.newMemGBox.Size = new System.Drawing.Size(744, 446);
            this.newMemGBox.TabIndex = 1;
            this.newMemGBox.TabStop = false;
            this.newMemGBox.Text = "New Facility Information Query";
            // 
            // newFacilityCancelButton
            // 
            this.newFacilityCancelButton.Location = new System.Drawing.Point(363, 475);
            this.newFacilityCancelButton.Name = "newFacilityCancelButton";
            this.newFacilityCancelButton.Size = new System.Drawing.Size(101, 39);
            this.newFacilityCancelButton.TabIndex = 49;
            this.newFacilityCancelButton.Text = "Cancel";
            this.newFacilityCancelButton.UseVisualStyleBackColor = true;
            this.newFacilityCancelButton.Click += new System.EventHandler(this.newFacilityCancelButton_Click);
            // 
            // NewFacilityAddButton
            // 
            this.NewFacilityAddButton.Location = new System.Drawing.Point(232, 475);
            this.NewFacilityAddButton.Name = "NewFacilityAddButton";
            this.NewFacilityAddButton.Size = new System.Drawing.Size(101, 39);
            this.NewFacilityAddButton.TabIndex = 48;
            this.NewFacilityAddButton.Text = "Submit";
            this.NewFacilityAddButton.UseVisualStyleBackColor = true;
            this.NewFacilityAddButton.Click += new System.EventHandler(this.NewFacilityAddButton_Click);
            // 
            // nomaintananceDateCheckbox
            // 
            this.nomaintananceDateCheckbox.AutoSize = true;
            this.nomaintananceDateCheckbox.Location = new System.Drawing.Point(26, 277);
            this.nomaintananceDateCheckbox.Name = "nomaintananceDateCheckbox";
            this.nomaintananceDateCheckbox.Size = new System.Drawing.Size(308, 35);
            this.nomaintananceDateCheckbox.TabIndex = 44;
            this.nomaintananceDateCheckbox.Text = "No Maintenance Date";
            this.nomaintananceDateCheckbox.UseVisualStyleBackColor = true;
            this.nomaintananceDateCheckbox.CheckedChanged += new System.EventHandler(this.nomaintananceDateCheckbox_CheckedChanged);
            // 
            // NewFacilityInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.newFacilityCancelButton);
            this.Controls.Add(this.NewFacilityAddButton);
            this.Controls.Add(this.newMemGBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewFacilityInformation";
            this.Text = "New Facility Information Query";
            this.Load += new System.EventHandler(this.NewFacilityInformation_Load);
            this.newMemGBox.ResumeLayout(false);
            this.newMemGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox AllowedHoursTextBox;
        private System.Windows.Forms.DateTimePicker MaintananceDPicker;
        private System.Windows.Forms.TextBox FacilityTypeTextBox;
        private System.Windows.Forms.TextBox FacilityNameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox newMemGBox;
        private System.Windows.Forms.Button newFacilityCancelButton;
        private System.Windows.Forms.Button NewFacilityAddButton;
        private System.Windows.Forms.CheckBox nomaintananceDateCheckbox;
    }
}