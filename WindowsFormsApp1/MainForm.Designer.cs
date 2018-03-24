namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.bookFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDTPicker = new System.Windows.Forms.DateTimePicker();
            this.previousDayButton = new System.Windows.Forms.Button();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.facilityTypeCombo = new System.Windows.Forms.ComboBox();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookFacilityToolStripMenuItem,
            this.memberInformationToolStripMenuItem,
            this.facilityInformationToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(774, 42);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // bookFacilityToolStripMenuItem
            // 
            this.bookFacilityToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookFacilityToolStripMenuItem.Name = "bookFacilityToolStripMenuItem";
            this.bookFacilityToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.bookFacilityToolStripMenuItem.Text = "Book Facility";
            // 
            // memberInformationToolStripMenuItem
            // 
            this.memberInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInformationToolStripMenuItem.Name = "memberInformationToolStripMenuItem";
            this.memberInformationToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.memberInformationToolStripMenuItem.Text = "Member Information";
            this.memberInformationToolStripMenuItem.Click += new System.EventHandler(this.memberInformationToolStripMenuItem_Click);
            // 
            // facilityInformationToolStripMenuItem
            // 
            this.facilityInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityInformationToolStripMenuItem.Name = "facilityInformationToolStripMenuItem";
            this.facilityInformationToolStripMenuItem.Size = new System.Drawing.Size(255, 38);
            this.facilityInformationToolStripMenuItem.Text = "Facility Information";
            // 
            // bookDTPicker
            // 
            this.bookDTPicker.AccessibleName = "Today";
            this.bookDTPicker.CustomFormat = "dd-MM-yyyy";
            this.bookDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookDTPicker.Location = new System.Drawing.Point(57, 59);
            this.bookDTPicker.Name = "bookDTPicker";
            this.bookDTPicker.Size = new System.Drawing.Size(153, 38);
            this.bookDTPicker.TabIndex = 2;
            // 
            // previousDayButton
            // 
            this.previousDayButton.Location = new System.Drawing.Point(27, 57);
            this.previousDayButton.Name = "previousDayButton";
            this.previousDayButton.Size = new System.Drawing.Size(27, 28);
            this.previousDayButton.TabIndex = 2;
            this.previousDayButton.Text = "<";
            this.previousDayButton.UseVisualStyleBackColor = true;
            // 
            // nextDayButton
            // 
            this.nextDayButton.Location = new System.Drawing.Point(213, 57);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(27, 28);
            this.nextDayButton.TabIndex = 3;
            this.nextDayButton.Text = ">";
            this.nextDayButton.UseVisualStyleBackColor = true;
            // 
            // facilityTypeCombo
            // 
            this.facilityTypeCombo.FormattingEnabled = true;
            this.facilityTypeCombo.Items.AddRange(new object[] {
            "Badminton Court",
            "Basketball Court",
            "Squash Court",
            "Tennis Court",
            "Table Tennis Court",
            "Seminar Rooms",
            "Dance Studio",
            "Multipurpose Hall"});
            this.facilityTypeCombo.Location = new System.Drawing.Point(267, 59);
            this.facilityTypeCombo.Name = "facilityTypeCombo";
            this.facilityTypeCombo.Size = new System.Drawing.Size(190, 39);
            this.facilityTypeCombo.TabIndex = 4;
            this.facilityTypeCombo.Text = "<-Select Facilities Type->";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.facilityTypeCombo);
            this.Controls.Add(this.nextDayButton);
            this.Controls.Add(this.previousDayButton);
            this.Controls.Add(this.bookDTPicker);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Sembawang Sports Center";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem bookFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityInformationToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker bookDTPicker;
        private System.Windows.Forms.Button previousDayButton;
        private System.Windows.Forms.Button nextDayButton;
        private System.Windows.Forms.ComboBox facilityTypeCombo;
    }
}

