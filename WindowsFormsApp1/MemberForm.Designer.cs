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
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Okbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.sembawangSportDataSet = new WindowsFormsApp1.SembawangSportDataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new WindowsFormsApp1.SembawangSportDataSetTableAdapters.MembersTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembawangSportDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(29, 34);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(100, 22);
            this.txtMemberSearch.TabIndex = 1;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbtn.BackgroundImage")));
            this.Searchbtn.Location = new System.Drawing.Point(144, 28);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(52, 35);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            this.Searchbtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Searchbtn_KeyUp);
            this.Searchbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Searchbtn_MouseClick);
            // 
            // Okbtn
            // 
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.Location = new System.Drawing.Point(207, 269);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(89, 44);
            this.Okbtn.TabIndex = 15;
            this.Okbtn.Text = "Ok";
            this.Okbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.Location = new System.Drawing.Point(371, 269);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(91, 44);
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
            this.grpMember.Location = new System.Drawing.Point(12, 215);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(758, 326);
            this.grpMember.TabIndex = 17;
            this.grpMember.TabStop = false;
            // 
            // txtICNumber
            // 
            this.txtICNumber.Location = new System.Drawing.Point(421, 13);
            this.txtICNumber.Name = "txtICNumber";
            this.txtICNumber.ReadOnly = true;
            this.txtICNumber.Size = new System.Drawing.Size(87, 22);
            this.txtICNumber.TabIndex = 34;
            // 
            // ICNumberlbl
            // 
            this.ICNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICNumberlbl.Location = new System.Drawing.Point(285, 6);
            this.ICNumberlbl.Name = "ICNumberlbl";
            this.ICNumberlbl.Size = new System.Drawing.Size(121, 39);
            this.ICNumberlbl.TabIndex = 33;
            this.ICNumberlbl.Text = "IC Number";
            this.ICNumberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(612, 228);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(87, 22);
            this.txtCountry.TabIndex = 32;
            this.txtCountry.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Countrylbl
            // 
            this.Countrylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Countrylbl.Location = new System.Drawing.Point(511, 222);
            this.Countrylbl.Name = "Countrylbl";
            this.Countrylbl.Size = new System.Drawing.Size(86, 39);
            this.Countrylbl.TabIndex = 31;
            this.Countrylbl.Text = "Country";
            this.Countrylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Countrylbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(612, 181);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.ReadOnly = true;
            this.txtPostalCode.Size = new System.Drawing.Size(87, 22);
            this.txtPostalCode.TabIndex = 30;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PostalCodelbl
            // 
            this.PostalCodelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodelbl.Location = new System.Drawing.Point(479, 173);
            this.PostalCodelbl.Name = "PostalCodelbl";
            this.PostalCodelbl.Size = new System.Drawing.Size(130, 39);
            this.PostalCodelbl.TabIndex = 29;
            this.PostalCodelbl.Text = "Postal Code";
            this.PostalCodelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PostalCodelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(464, 97);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(122, 22);
            this.txtDOB.TabIndex = 28;
            // 
            // DOBlbl
            // 
            this.DOBlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlbl.Location = new System.Drawing.Point(310, 88);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(148, 35);
            this.DOBlbl.TabIndex = 27;
            this.DOBlbl.Text = "Date of Birth";
            this.DOBlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DOBlbl.Click += new System.EventHandler(this.DOBlbl_Click);
            // 
            // Genderlbl
            // 
            this.Genderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlbl.Location = new System.Drawing.Point(491, 39);
            this.Genderlbl.Name = "Genderlbl";
            this.Genderlbl.Size = new System.Drawing.Size(92, 48);
            this.Genderlbl.TabIndex = 26;
            this.Genderlbl.Text = "Gender";
            this.Genderlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(165, 182);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(309, 79);
            this.txtAddress.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(207, 22);
            this.txtEmail.TabIndex = 24;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(165, 97);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(139, 22);
            this.txtPhoneNumber.TabIndex = 23;
            // 
            // PhoneNumberlbl
            // 
            this.PhoneNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberlbl.Location = new System.Drawing.Point(6, 82);
            this.PhoneNumberlbl.Name = "PhoneNumberlbl";
            this.PhoneNumberlbl.Size = new System.Drawing.Size(153, 54);
            this.PhoneNumberlbl.TabIndex = 22;
            this.PhoneNumberlbl.Text = "Phone Number";
            this.PhoneNumberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(589, 54);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(67, 22);
            this.txtGender.TabIndex = 14;
            // 
            // BookingTolbl
            // 
            this.BookingTolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingTolbl.Location = new System.Drawing.Point(45, 175);
            this.BookingTolbl.Name = "BookingTolbl";
            this.BookingTolbl.Size = new System.Drawing.Size(94, 35);
            this.BookingTolbl.TabIndex = 21;
            this.BookingTolbl.Text = "Address";
            this.BookingTolbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BookingTolbl.Click += new System.EventHandler(this.BookingTolbl_Click);
            // 
            // Emaillbl
            // 
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(4, 136);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(150, 46);
            this.Emaillbl.TabIndex = 20;
            this.Emaillbl.Text = "Email Address";
            this.Emaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Emaillbl.Click += new System.EventHandler(this.Emaillbl_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(168, 16);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(87, 22);
            this.txtMemberID.TabIndex = 17;
            // 
            // MemberNamelbl
            // 
            this.MemberNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNamelbl.Location = new System.Drawing.Point(4, 44);
            this.MemberNamelbl.Name = "MemberNamelbl";
            this.MemberNamelbl.Size = new System.Drawing.Size(155, 45);
            this.MemberNamelbl.TabIndex = 18;
            this.MemberNamelbl.Text = "Member Name";
            this.MemberNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(165, 53);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(309, 22);
            this.txtMemberName.TabIndex = 15;
            this.txtMemberName.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // MemberIDlbl
            // 
            this.MemberIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDlbl.Location = new System.Drawing.Point(32, 9);
            this.MemberIDlbl.Name = "MemberIDlbl";
            this.MemberIDlbl.Size = new System.Drawing.Size(121, 39);
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
            this.MemberdataGridView.Location = new System.Drawing.Point(12, 80);
            this.MemberdataGridView.Name = "MemberdataGridView";
            this.MemberdataGridView.ReadOnly = true;
            this.MemberdataGridView.RowTemplate.Height = 24;
            this.MemberdataGridView.Size = new System.Drawing.Size(758, 132);
            this.MemberdataGridView.TabIndex = 18;
            this.MemberdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberdataGridView_CellClick_1);
            this.MemberdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberdataGridView_CellContentClick_1);
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
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.MemberdataGridView);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.txtMemberSearch);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private SembawangSportDataSet sembawangSportDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private SembawangSportDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label PhoneNumberlbl;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label BookingTolbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.TextBox txtMemberID;
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
    }
}