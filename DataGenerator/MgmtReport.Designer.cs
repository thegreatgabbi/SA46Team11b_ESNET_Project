namespace DataGenerator
{
    partial class MgmtReport
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
            this.CRMgmtView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRMgmtView
            // 
            this.CRMgmtView.ActiveViewIndex = -1;
            this.CRMgmtView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRMgmtView.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRMgmtView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRMgmtView.Location = new System.Drawing.Point(0, 0);
            this.CRMgmtView.Name = "CRMgmtView";
            this.CRMgmtView.Size = new System.Drawing.Size(1867, 1211);
            this.CRMgmtView.TabIndex = 0;
            // 
            // MgmtReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1211);
            this.Controls.Add(this.CRMgmtView);
            this.Name = "MgmtReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "MgmtReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MgmtReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRMgmtView;
    }
}