namespace DataGenerator
{
    partial class crMember
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
            this.crMem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crMem
            // 
            this.crMem.ActiveViewIndex = -1;
            this.crMem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crMem.Cursor = System.Windows.Forms.Cursors.Default;
            this.crMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crMem.Location = new System.Drawing.Point(0, 0);
            this.crMem.Name = "crMem";
            this.crMem.Size = new System.Drawing.Size(2038, 1082);
            this.crMem.TabIndex = 0;
            // 
            // crMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2038, 1082);
            this.Controls.Add(this.crMem);
            this.Name = "crMember";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.crMember_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crMem;
    }
}

