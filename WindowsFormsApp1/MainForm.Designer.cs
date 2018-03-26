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
            this.bookingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookFacilityToolStripMenuItem,
            this.bookingInformationToolStripMenuItem,
            this.memberInformationToolStripMenuItem,
            this.facilityInformationToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(1202, 42);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenuStrip";
            // 
            // bookFacilityToolStripMenuItem
            // 
            this.bookFacilityToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookFacilityToolStripMenuItem.Name = "bookFacilityToolStripMenuItem";
            this.bookFacilityToolStripMenuItem.Size = new System.Drawing.Size(181, 35);
            this.bookFacilityToolStripMenuItem.Text = "Book Facility";
            // 
            // bookingInformationToolStripMenuItem
            // 
            this.bookingInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingInformationToolStripMenuItem.Name = "bookingInformationToolStripMenuItem";
            this.bookingInformationToolStripMenuItem.Size = new System.Drawing.Size(267, 35);
            this.bookingInformationToolStripMenuItem.Text = "Booking Information";
            this.bookingInformationToolStripMenuItem.Click += new System.EventHandler(this.bookingInformationToolStripMenuItem_Click);
            // 
            // memberInformationToolStripMenuItem
            // 
            this.memberInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberInformationToolStripMenuItem.Name = "memberInformationToolStripMenuItem";
            this.memberInformationToolStripMenuItem.Size = new System.Drawing.Size(267, 35);
            this.memberInformationToolStripMenuItem.Text = "Member Information";
            this.memberInformationToolStripMenuItem.Click += new System.EventHandler(this.memberInformationToolStripMenuItem_Click);
            // 
            // facilityInformationToolStripMenuItem
            // 
            this.facilityInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityInformationToolStripMenuItem.Name = "facilityInformationToolStripMenuItem";
            this.facilityInformationToolStripMenuItem.Size = new System.Drawing.Size(255, 35);
            this.facilityInformationToolStripMenuItem.Text = "Facility Information";
            this.facilityInformationToolStripMenuItem.Click += new System.EventHandler(this.facilityInformationToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1202, 729);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.ToolStripMenuItem bookingInformationToolStripMenuItem;
    }
}

