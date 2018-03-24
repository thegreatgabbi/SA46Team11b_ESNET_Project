namespace WindowsFormsApp1
{
    partial class NewMemberInformation
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
            this.newMemGBox = new System.Windows.Forms.GroupBox();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.ContactTitleTextBox = new System.Windows.Forms.TextBox();
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.memberBDPicker = new System.Windows.Forms.DateTimePicker();
            this.ICNumberTextBox = new System.Windows.Forms.TextBox();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newMemberCancelButton = new System.Windows.Forms.Button();
            this.NewMemberAddButton = new System.Windows.Forms.Button();
            this.newMemGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newMemGBox
            // 
            this.newMemGBox.Controls.Add(this.ContactNumberTextBox);
            this.newMemGBox.Controls.Add(this.EmailTextBox);
            this.newMemGBox.Controls.Add(this.PostalCodeTextBox);
            this.newMemGBox.Controls.Add(this.AddressTextBox);
            this.newMemGBox.Controls.Add(this.CountryTextBox);
            this.newMemGBox.Controls.Add(this.ContactTitleTextBox);
            this.newMemGBox.Controls.Add(this.GenderTextBox);
            this.newMemGBox.Controls.Add(this.memberBDPicker);
            this.newMemGBox.Controls.Add(this.ICNumberTextBox);
            this.newMemGBox.Controls.Add(this.MemberNameTextBox);
            this.newMemGBox.Controls.Add(this.label11);
            this.newMemGBox.Controls.Add(this.label10);
            this.newMemGBox.Controls.Add(this.label9);
            this.newMemGBox.Controls.Add(this.label8);
            this.newMemGBox.Controls.Add(this.label7);
            this.newMemGBox.Controls.Add(this.label6);
            this.newMemGBox.Controls.Add(this.label5);
            this.newMemGBox.Controls.Add(this.label4);
            this.newMemGBox.Controls.Add(this.label3);
            this.newMemGBox.Controls.Add(this.label2);
            this.newMemGBox.Location = new System.Drawing.Point(13, 13);
            this.newMemGBox.Name = "newMemGBox";
            this.newMemGBox.Size = new System.Drawing.Size(749, 461);
            this.newMemGBox.TabIndex = 0;
            this.newMemGBox.TabStop = false;
            this.newMemGBox.Text = "New Member Information Query";
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(169, 395);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(291, 38);
            this.ContactNumberTextBox.TabIndex = 43;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(168, 343);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(291, 38);
            this.EmailTextBox.TabIndex = 42;
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(581, 270);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(142, 38);
            this.PostalCodeTextBox.TabIndex = 41;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(168, 220);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(292, 106);
            this.AddressTextBox.TabIndex = 40;
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(581, 220);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(142, 38);
            this.CountryTextBox.TabIndex = 39;
            // 
            // ContactTitleTextBox
            // 
            this.ContactTitleTextBox.Location = new System.Drawing.Point(375, 173);
            this.ContactTitleTextBox.Name = "ContactTitleTextBox";
            this.ContactTitleTextBox.ReadOnly = true;
            this.ContactTitleTextBox.Size = new System.Drawing.Size(85, 38);
            this.ContactTitleTextBox.TabIndex = 38;
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Location = new System.Drawing.Point(168, 176);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(92, 38);
            this.GenderTextBox.TabIndex = 37;
            this.GenderTextBox.TextChanged += new System.EventHandler(this.GenderTextBox_TextChanged);
            // 
            // memberBDPicker
            // 
            this.memberBDPicker.CustomFormat = "dd-MM-yyyy";
            this.memberBDPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.memberBDPicker.Location = new System.Drawing.Point(168, 134);
            this.memberBDPicker.Name = "memberBDPicker";
            this.memberBDPicker.Size = new System.Drawing.Size(195, 38);
            this.memberBDPicker.TabIndex = 36;
            // 
            // ICNumberTextBox
            // 
            this.ICNumberTextBox.Location = new System.Drawing.Point(169, 42);
            this.ICNumberTextBox.Name = "ICNumberTextBox";
            this.ICNumberTextBox.Size = new System.Drawing.Size(85, 38);
            this.ICNumberTextBox.TabIndex = 35;
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Location = new System.Drawing.Point(168, 90);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.Size = new System.Drawing.Size(291, 38);
            this.MemberNameTextBox.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 176);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 31);
            this.label11.TabIndex = 32;
            this.label11.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 31);
            this.label10.TabIndex = 31;
            this.label10.Text = "Email Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 392);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Contact Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 31);
            this.label8.TabIndex = 29;
            this.label8.Text = "Contact Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 273);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "IC Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 31);
            this.label2.TabIndex = 23;
            this.label2.Text = "Member Name";
            // 
            // newMemberCancelButton
            // 
            this.newMemberCancelButton.Location = new System.Drawing.Point(388, 480);
            this.newMemberCancelButton.Name = "newMemberCancelButton";
            this.newMemberCancelButton.Size = new System.Drawing.Size(101, 39);
            this.newMemberCancelButton.TabIndex = 47;
            this.newMemberCancelButton.Text = "Cancel";
            this.newMemberCancelButton.UseVisualStyleBackColor = true;
            this.newMemberCancelButton.Click += new System.EventHandler(this.NewMemberCancelButton_Click);
            // 
            // NewMemberAddButton
            // 
            this.NewMemberAddButton.Location = new System.Drawing.Point(257, 480);
            this.NewMemberAddButton.Name = "NewMemberAddButton";
            this.NewMemberAddButton.Size = new System.Drawing.Size(101, 39);
            this.NewMemberAddButton.TabIndex = 46;
            this.NewMemberAddButton.Text = "Submit";
            this.NewMemberAddButton.UseVisualStyleBackColor = true;
            this.NewMemberAddButton.Click += new System.EventHandler(this.NewMemberAddButton_Click);
            // 
            // NewMemberInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.newMemberCancelButton);
            this.Controls.Add(this.NewMemberAddButton);
            this.Controls.Add(this.newMemGBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewMemberInformation";
            this.Text = "New Member Information Query";
            this.Load += new System.EventHandler(this.NewMemberInformation_Load);
            this.newMemGBox.ResumeLayout(false);
            this.newMemGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newMemGBox;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox ContactTitleTextBox;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.DateTimePicker memberBDPicker;
        private System.Windows.Forms.TextBox ICNumberTextBox;
        private System.Windows.Forms.TextBox MemberNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newMemberCancelButton;
        private System.Windows.Forms.Button NewMemberAddButton;
    }
}