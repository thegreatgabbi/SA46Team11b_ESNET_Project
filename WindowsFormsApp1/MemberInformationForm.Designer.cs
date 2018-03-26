namespace WindowsFormsApp1
{
    partial class MemberInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberInformationForm));
            this.memGridView = new System.Windows.Forms.DataGridView();
            this.addNewMemButton = new System.Windows.Forms.Button();
            this.searchMemberTextBox = new System.Windows.Forms.TextBox();
            this.searchPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteLink = new System.Windows.Forms.LinkLabel();
            this.updateLink = new System.Windows.Forms.LinkLabel();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.contactNumTextbox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.postalTextBox = new System.Windows.Forms.TextBox();
            this.memberBDPicker = new System.Windows.Forms.DateTimePicker();
            this.ICnumberTextBox = new System.Windows.Forms.TextBox();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memGridView
            // 
            this.memGridView.AllowUserToOrderColumns = true;
            this.memGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memGridView.Location = new System.Drawing.Point(70, 78);
            this.memGridView.Margin = new System.Windows.Forms.Padding(4);
            this.memGridView.Name = "memGridView";
            this.memGridView.ReadOnly = true;
            this.memGridView.RowTemplate.Height = 33;
            this.memGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memGridView.Size = new System.Drawing.Size(964, 259);
            this.memGridView.TabIndex = 8;
            this.memGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memGridView_CellClick);
            // 
            // addNewMemButton
            // 
            this.addNewMemButton.Location = new System.Drawing.Point(758, 21);
            this.addNewMemButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewMemButton.Name = "addNewMemButton";
            this.addNewMemButton.Size = new System.Drawing.Size(281, 46);
            this.addNewMemButton.TabIndex = 9;
            this.addNewMemButton.Text = "+ Add New Member";
            this.addNewMemButton.UseVisualStyleBackColor = true;
            this.addNewMemButton.Click += new System.EventHandler(this.addNewMemButton_Click);
            // 
            // searchMemberTextBox
            // 
            this.searchMemberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberTextBox.Location = new System.Drawing.Point(70, 25);
            this.searchMemberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchMemberTextBox.Multiline = true;
            this.searchMemberTextBox.Name = "searchMemberTextBox";
            this.searchMemberTextBox.Size = new System.Drawing.Size(223, 45);
            this.searchMemberTextBox.TabIndex = 7;
            // 
            // searchPic
            // 
            this.searchPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPic.Image = ((System.Drawing.Image)(resources.GetObject("searchPic.Image")));
            this.searchPic.Location = new System.Drawing.Point(301, 25);
            this.searchPic.Margin = new System.Windows.Forms.Padding(4);
            this.searchPic.Name = "searchPic";
            this.searchPic.Size = new System.Drawing.Size(38, 45);
            this.searchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPic.TabIndex = 6;
            this.searchPic.TabStop = false;
            this.searchPic.Click += new System.EventHandler(this.searchPic_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.DeleteLink);
            this.groupBox1.Controls.Add(this.updateLink);
            this.groupBox1.Controls.Add(this.genderTextBox);
            this.groupBox1.Controls.Add(this.contactNumTextbox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.postalTextBox);
            this.groupBox1.Controls.Add(this.memberBDPicker);
            this.groupBox1.Controls.Add(this.ICnumberTextBox);
            this.groupBox1.Controls.Add(this.memberIDTextBox);
            this.groupBox1.Controls.Add(this.memberNameTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(70, 345);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1136, 381);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information Details";
            // 
            // DeleteLink
            // 
            this.DeleteLink.AutoSize = true;
            this.DeleteLink.LinkColor = System.Drawing.Color.Blue;
            this.DeleteLink.Location = new System.Drawing.Point(846, 59);
            this.DeleteLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteLink.Name = "DeleteLink";
            this.DeleteLink.Size = new System.Drawing.Size(116, 39);
            this.DeleteLink.TabIndex = 90;
            this.DeleteLink.TabStop = true;
            this.DeleteLink.Text = "Delete";
            this.DeleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Delete_LinkClicked);
            // 
            // updateLink
            // 
            this.updateLink.AutoSize = true;
            this.updateLink.Location = new System.Drawing.Point(846, 21);
            this.updateLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.updateLink.Name = "updateLink";
            this.updateLink.Size = new System.Drawing.Size(127, 39);
            this.updateLink.TabIndex = 89;
            this.updateLink.TabStop = true;
            this.updateLink.Text = "Update";
            this.updateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.updateLink_LinkClicked);
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(577, 131);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(112, 46);
            this.genderTextBox.TabIndex = 88;
            // 
            // contactNumTextbox
            // 
            this.contactNumTextbox.Location = new System.Drawing.Point(211, 327);
            this.contactNumTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumTextbox.Name = "contactNumTextbox";
            this.contactNumTextbox.Size = new System.Drawing.Size(387, 46);
            this.contactNumTextbox.TabIndex = 87;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(210, 282);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(388, 46);
            this.emailTextBox.TabIndex = 86;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(763, 182);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(193, 46);
            this.countryTextBox.TabIndex = 85;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(210, 181);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(388, 90);
            this.addressTextBox.TabIndex = 84;
            // 
            // postalTextBox
            // 
            this.postalTextBox.Location = new System.Drawing.Point(765, 234);
            this.postalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.postalTextBox.Name = "postalTextBox";
            this.postalTextBox.Size = new System.Drawing.Size(193, 46);
            this.postalTextBox.TabIndex = 83;
            // 
            // memberBDPicker
            // 
            this.memberBDPicker.CustomFormat = "dd-MM-yyyy";
            this.memberBDPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.memberBDPicker.Location = new System.Drawing.Point(210, 127);
            this.memberBDPicker.Margin = new System.Windows.Forms.Padding(4);
            this.memberBDPicker.Name = "memberBDPicker";
            this.memberBDPicker.Size = new System.Drawing.Size(259, 46);
            this.memberBDPicker.TabIndex = 80;
            // 
            // ICnumberTextBox
            // 
            this.ICnumberTextBox.Location = new System.Drawing.Point(577, 34);
            this.ICnumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ICnumberTextBox.Name = "ICnumberTextBox";
            this.ICnumberTextBox.Size = new System.Drawing.Size(112, 46);
            this.ICnumberTextBox.TabIndex = 79;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(210, 37);
            this.memberIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.ReadOnly = true;
            this.memberIDTextBox.Size = new System.Drawing.Size(136, 46);
            this.memberIDTextBox.TabIndex = 78;
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.Location = new System.Drawing.Point(210, 84);
            this.memberNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.Size = new System.Drawing.Size(387, 46);
            this.memberNameTextBox.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(479, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 39);
            this.label11.TabIndex = 76;
            this.label11.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 39);
            this.label10.TabIndex = 75;
            this.label10.Text = "Email Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 321);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 39);
            this.label9.TabIndex = 74;
            this.label9.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 39);
            this.label7.TabIndex = 72;
            this.label7.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(605, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 39);
            this.label6.TabIndex = 71;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 39);
            this.label5.TabIndex = 70;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 39);
            this.label4.TabIndex = 69;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 39);
            this.label3.TabIndex = 68;
            this.label3.Text = "IC Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 39);
            this.label2.TabIndex = 67;
            this.label2.Text = "Member Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 66;
            this.label1.Text = "Member ID";
            // 
            // MemberInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1258, 787);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.memGridView);
            this.Controls.Add(this.addNewMemButton);
            this.Controls.Add(this.searchMemberTextBox);
            this.Controls.Add(this.searchPic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MemberInformationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MemberInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView memGridView;
        private System.Windows.Forms.Button addNewMemButton;
        private System.Windows.Forms.TextBox searchMemberTextBox;
        private System.Windows.Forms.PictureBox searchPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel DeleteLink;
        private System.Windows.Forms.LinkLabel updateLink;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox contactNumTextbox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox postalTextBox;
        private System.Windows.Forms.DateTimePicker memberBDPicker;
        private System.Windows.Forms.TextBox ICnumberTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox memberNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}