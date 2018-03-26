namespace WindowsFormsApp1
{
    partial class MemberForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.Okbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.sembawangSportDataSet = new WindowsFormsApp1.SembawangSportDataSet1();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new WindowsFormsApp1.SembawangSportDataSet1TableAdapters.MembersTableAdapter();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.txtICNumber = new System.Windows.Forms.TextBox();
            this.ICNumberlbl = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.Countrylbl = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.PostalCodelbl = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.Genderlbl = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.PhoneNumberlbl = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.BookingTolbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.MemberNamelbl = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.MemberIDlbl = new System.Windows.Forms.Label();
            this.sembawangSportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sembawangSportDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MemberdataGridView = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sembawangSportDataSet1 = new WindowsFormsApp1.SembawangSportDataSet1();
            this.membersTableAdapter1 = new WindowsFormsApp1.SembawangSportDataSet1TableAdapters.MembersTableAdapter();
            this.searchPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(22, 28);
            this.txtMemberSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(76, 20);
            this.txtMemberSearch.TabIndex = 1;
            // 
            // Okbtn
            // 
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.Location = new System.Drawing.Point(155, 218);
            this.Okbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(67, 36);
            this.Okbtn.TabIndex = 15;
            this.Okbtn.Text = "Ok";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(278, 218);
            this.Cancelbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(68, 36);
            this.Cancelbtn.TabIndex = 16;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // sembawangSportDataSet
            // 
            this.sembawangSportDataSet.DataSetName = "SembawangSportDataSet";
            this.sembawangSportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.sembawangSportDataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.txtICNumber);
            this.grpMember.Controls.Add(this.ICNumberlbl);
            this.grpMember.Controls.Add(this.txtCountry);
            this.grpMember.Controls.Add(this.Cancelbtn);
            this.grpMember.Controls.Add(this.Countrylbl);
            this.grpMember.Controls.Add(this.Okbtn);
            this.grpMember.Controls.Add(this.txtPostalCode);
            this.grpMember.Controls.Add(this.PostalCodelbl);
            this.grpMember.Controls.Add(this.txtDOB);
            this.grpMember.Controls.Add(this.DOBlbl);
            this.grpMember.Controls.Add(this.Genderlbl);
            this.grpMember.Controls.Add(this.txtAddress);
            this.grpMember.Controls.Add(this.txtEmail);
            this.grpMember.Controls.Add(this.txtPhoneNumber);
            this.grpMember.Controls.Add(this.PhoneNumberlbl);
            this.grpMember.Controls.Add(this.txtGender);
            this.grpMember.Controls.Add(this.BookingTolbl);
            this.grpMember.Controls.Add(this.Emaillbl);
            this.grpMember.Controls.Add(this.txtMemberID);
            this.grpMember.Controls.Add(this.MemberNamelbl);
            this.grpMember.Controls.Add(this.txtMemberName);
            this.grpMember.Controls.Add(this.MemberIDlbl);
            this.grpMember.Location = new System.Drawing.Point(9, 175);
            this.grpMember.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpMember.Name = "grpMember";
            this.grpMember.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpMember.Size = new System.Drawing.Size(568, 265);
            this.grpMember.TabIndex = 17;
            this.grpMember.TabStop = false;
            // 
            // txtICNumber
            // 
            this.txtICNumber.Location = new System.Drawing.Point(316, 10);
            this.txtICNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtICNumber.Name = "txtICNumber";
            this.txtICNumber.ReadOnly = true;
            this.txtICNumber.Size = new System.Drawing.Size(66, 20);
            this.txtICNumber.TabIndex = 34;
            // 
            // ICNumberlbl
            // 
            this.ICNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICNumberlbl.Location = new System.Drawing.Point(214, 5);
            this.ICNumberlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ICNumberlbl.Name = "ICNumberlbl";
            this.ICNumberlbl.Size = new System.Drawing.Size(91, 32);
            this.ICNumberlbl.TabIndex = 33;
            this.ICNumberlbl.Text = "IC Number";
            this.ICNumberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(459, 185);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(66, 20);
            this.txtCountry.TabIndex = 32;
            // 
            // Countrylbl
            // 
            this.Countrylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countrylbl.Location = new System.Drawing.Point(383, 180);
            this.Countrylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Countrylbl.Name = "Countrylbl";
            this.Countrylbl.Size = new System.Drawing.Size(64, 32);
            this.Countrylbl.TabIndex = 31;
            this.Countrylbl.Text = "Country";
            this.Countrylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(459, 147);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.ReadOnly = true;
            this.txtPostalCode.Size = new System.Drawing.Size(56, 20);
            this.txtPostalCode.TabIndex = 30;
            // 
            // PostalCodelbl
            // 
            this.PostalCodelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodelbl.Location = new System.Drawing.Point(359, 140);
            this.PostalCodelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PostalCodelbl.Name = "PostalCodelbl";
            this.PostalCodelbl.Size = new System.Drawing.Size(98, 32);
            this.PostalCodelbl.TabIndex = 29;
            this.PostalCodelbl.Text = "Postal Code";
            this.PostalCodelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(348, 79);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(72, 20);
            this.txtDOB.TabIndex = 28;
            // 
            // DOBlbl
            // 
            this.DOBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlbl.Location = new System.Drawing.Point(232, 71);
            this.DOBlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(111, 29);
            this.DOBlbl.TabIndex = 27;
            this.DOBlbl.Text = "Date of Birth";
            this.DOBlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Genderlbl
            // 
            this.Genderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlbl.Location = new System.Drawing.Point(368, 32);
            this.Genderlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Genderlbl.Name = "Genderlbl";
            this.Genderlbl.Size = new System.Drawing.Size(69, 39);
            this.Genderlbl.TabIndex = 26;
            this.Genderlbl.Text = "Gender";
            this.Genderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(124, 148);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(233, 65);
            this.txtAddress.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 117);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(124, 79);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(105, 20);
            this.txtPhoneNumber.TabIndex = 23;
            // 
            // PhoneNumberlbl
            // 
            this.PhoneNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberlbl.Location = new System.Drawing.Point(4, 67);
            this.PhoneNumberlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumberlbl.Name = "PhoneNumberlbl";
            this.PhoneNumberlbl.Size = new System.Drawing.Size(115, 44);
            this.PhoneNumberlbl.TabIndex = 22;
            this.PhoneNumberlbl.Text = "Phone Number";
            this.PhoneNumberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(442, 44);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(51, 20);
            this.txtGender.TabIndex = 14;
            // 
            // BookingTolbl
            // 
            this.BookingTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTolbl.Location = new System.Drawing.Point(34, 142);
            this.BookingTolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookingTolbl.Name = "BookingTolbl";
            this.BookingTolbl.Size = new System.Drawing.Size(70, 29);
            this.BookingTolbl.TabIndex = 21;
            this.BookingTolbl.Text = "Address";
            this.BookingTolbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Emaillbl
            // 
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(3, 111);
            this.Emaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(112, 37);
            this.Emaillbl.TabIndex = 20;
            this.Emaillbl.Text = "Email Address";
            this.Emaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(126, 13);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(66, 20);
            this.txtMemberID.TabIndex = 17;
            // 
            // MemberNamelbl
            // 
            this.MemberNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNamelbl.Location = new System.Drawing.Point(3, 36);
            this.MemberNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberNamelbl.Name = "MemberNamelbl";
            this.MemberNamelbl.Size = new System.Drawing.Size(116, 36);
            this.MemberNamelbl.TabIndex = 18;
            this.MemberNamelbl.Text = "Member Name";
            this.MemberNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(124, 43);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(233, 20);
            this.txtMemberName.TabIndex = 15;
            // 
            // MemberIDlbl
            // 
            this.MemberIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDlbl.Location = new System.Drawing.Point(24, 7);
            this.MemberIDlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemberIDlbl.Name = "MemberIDlbl";
            this.MemberIDlbl.Size = new System.Drawing.Size(91, 32);
            this.MemberIDlbl.TabIndex = 16;
            this.MemberIDlbl.Text = "MemberID";
            this.MemberIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sembawangSportDataSetBindingSource
            // 
            this.sembawangSportDataSetBindingSource.DataSource = this.sembawangSportDataSet;
            this.sembawangSportDataSetBindingSource.Position = 0;
            // 
            // sembawangSportDataSetBindingSource1
            // 
            this.sembawangSportDataSetBindingSource1.DataSource = this.sembawangSportDataSet;
            this.sembawangSportDataSetBindingSource1.Position = 0;
            // 
            // MemberdataGridView
            // 
            this.MemberdataGridView.AutoGenerateColumns = false;
            this.MemberdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.iCNumberDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.contactTitleDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.MemberdataGridView.DataSource = this.membersBindingSource1;
            this.MemberdataGridView.Location = new System.Drawing.Point(9, 65);
            this.MemberdataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemberdataGridView.Name = "MemberdataGridView";
            this.MemberdataGridView.ReadOnly = true;
            this.MemberdataGridView.RowTemplate.Height = 24;
            this.MemberdataGridView.Size = new System.Drawing.Size(568, 107);
            this.MemberdataGridView.TabIndex = 18;
            this.MemberdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberdataGridView_CellClick_1);
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iCNumberDataGridViewTextBoxColumn
            // 
            this.iCNumberDataGridViewTextBoxColumn.DataPropertyName = "ICNumber";
            this.iCNumberDataGridViewTextBoxColumn.HeaderText = "ICNumber";
            this.iCNumberDataGridViewTextBoxColumn.Name = "iCNumberDataGridViewTextBoxColumn";
            this.iCNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            this.dateofBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            this.postcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactTitleDataGridViewTextBoxColumn
            // 
            this.contactTitleDataGridViewTextBoxColumn.DataPropertyName = "ContactTitle";
            this.contactTitleDataGridViewTextBoxColumn.HeaderText = "ContactTitle";
            this.contactTitleDataGridViewTextBoxColumn.Name = "contactTitleDataGridViewTextBoxColumn";
            this.contactTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membersBindingSource1
            // 
            this.membersBindingSource1.DataMember = "Members";
            this.membersBindingSource1.DataSource = this.sembawangSportDataSet1;
            // 
            // sembawangSportDataSet1
            // 
            this.sembawangSportDataSet1.DataSetName = "SembawangSportDataSet1";
            this.sembawangSportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter1
            // 
            this.membersTableAdapter1.ClearBeforeFill = true;
            // 
            // searchPic
            // 
            this.searchPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPic.Image = ((System.Drawing.Image)(resources.GetObject("searchPic.Image")));
            this.searchPic.Location = new System.Drawing.Point(104, 23);
            this.searchPic.Margin = new System.Windows.Forms.Padding(4);
            this.searchPic.Name = "searchPic";
            this.searchPic.Size = new System.Drawing.Size(32, 32);
            this.searchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPic.TabIndex = 19;
            this.searchPic.TabStop = false;
            this.searchPic.Click += new System.EventHandler(this.searchPic_Click);
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(620, 440);
            this.Controls.Add(this.searchPic);
            this.Controls.Add(this.MemberdataGridView);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.txtMemberSearch);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MemberForm";
            this.Text = "Select Member";
            this.Load += new System.EventHandler(this.MemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private SembawangSportDataSet1 sembawangSportDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private SembawangSportDataSet1TableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label PhoneNumberlbl;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label BookingTolbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label MemberNamelbl;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label MemberIDlbl;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label PostalCodelbl;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.Label Genderlbl;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label Countrylbl;
        private System.Windows.Forms.TextBox txtICNumber;
        private System.Windows.Forms.Label ICNumberlbl;
        private System.Windows.Forms.BindingSource sembawangSportDataSetBindingSource;
        private System.Windows.Forms.BindingSource sembawangSportDataSetBindingSource1;
        private System.Windows.Forms.DataGridView MemberdataGridView;
        private SembawangSportDataSet1 sembawangSportDataSet1;
        private System.Windows.Forms.BindingSource membersBindingSource1;
        private SembawangSportDataSet1TableAdapters.MembersTableAdapter membersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.PictureBox searchPic;
    }
}