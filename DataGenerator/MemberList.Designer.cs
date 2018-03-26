namespace DataGenerator
{
    partial class MemberList
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
            this.MemListView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MemListView
            // 
            this.MemListView.ActiveViewIndex = -1;
            this.MemListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.MemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemListView.Location = new System.Drawing.Point(0, 0);
            this.MemListView.Name = "MemListView";
            this.MemListView.Size = new System.Drawing.Size(1676, 1015);
            this.MemListView.TabIndex = 0;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 1015);
            this.Controls.Add(this.MemListView);
            this.Name = "MemberList";
            this.Text = "MemberList";
            this.Load += new System.EventHandler(this.MemberList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MemListView;
    }
}