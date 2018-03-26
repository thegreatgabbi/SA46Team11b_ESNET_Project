namespace WindowsFormsApp1
{
    partial class FacilityAvailabilityForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacilityAvailabilityForm));
            this.bookDTPicker = new System.Windows.Forms.DateTimePicker();
            this.previousDayButton = new System.Windows.Forms.Button();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.facilityTypeCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookDTPicker
            // 
            this.bookDTPicker.AccessibleName = "Today";
            this.bookDTPicker.CustomFormat = "dd-MM-yyyy";
            this.bookDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookDTPicker.Location = new System.Drawing.Point(48, 12);
            this.bookDTPicker.Name = "bookDTPicker";
            this.bookDTPicker.Size = new System.Drawing.Size(144, 23);
            this.bookDTPicker.TabIndex = 2;
            this.bookDTPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bookDTPicker_KeyDown);
            this.bookDTPicker.Leave += new System.EventHandler(this.facilityTypeCombo_SelectedIndexChanged);
            // 
            // previousDayButton
            // 
            this.previousDayButton.Location = new System.Drawing.Point(12, 12);
            this.previousDayButton.Name = "previousDayButton";
            this.previousDayButton.Size = new System.Drawing.Size(24, 24);
            this.previousDayButton.TabIndex = 2;
            this.previousDayButton.Text = "<";
            this.previousDayButton.UseVisualStyleBackColor = true;
            this.previousDayButton.Click += new System.EventHandler(this.previousDayButton_Click);
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(204, 12);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(24, 24);
            this.nextDayButton.TabIndex = 3;
            this.nextDayButton.Text = ">";
            this.nextDayButton.UseVisualStyleBackColor = true;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // facilityTypeCombo
            // 
            this.facilityTypeCombo.FormattingEnabled = true;
            this.facilityTypeCombo.Location = new System.Drawing.Point(252, 12);
            this.facilityTypeCombo.Name = "facilityTypeCombo";
            this.facilityTypeCombo.Size = new System.Drawing.Size(288, 24);
            this.facilityTypeCombo.TabIndex = 4;
            this.facilityTypeCombo.Text = "- Select Facility Type -";
            this.facilityTypeCombo.SelectedIndexChanged += new System.EventHandler(this.facilityTypeCombo_SelectedIndexChanged);
            this.facilityTypeCombo.Click += new System.EventHandler(this.facilityTypeCombo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(972, 624);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(972, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FacilityAvailabilityForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.facilityTypeCombo);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.previousDayButton);
            this.Controls.Add(this.bookDTPicker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FacilityAvailabilityForm";
            this.Text = "Sembawang Sports Center";
            this.Load += new System.EventHandler(this.FacilityAvailabilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker bookDTPicker;
        private System.Windows.Forms.Button previousDayButton;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.ComboBox facilityTypeCombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

