namespace DataGenerator
{
    partial class BookingReceipt
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
            this.crReceiptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crReceiptViewer
            // 
            this.crReceiptViewer.ActiveViewIndex = -1;
            this.crReceiptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crReceiptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crReceiptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crReceiptViewer.Location = new System.Drawing.Point(0, 0);
            this.crReceiptViewer.Name = "crReceiptViewer";
            this.crReceiptViewer.Size = new System.Drawing.Size(1589, 1042);
            this.crReceiptViewer.TabIndex = 0;
            // 
            // BookingReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 1042);
            this.Controls.Add(this.crReceiptViewer);
            this.Name = "BookingReceipt";
            this.Text = "BookingReceipt";
            this.Load += new System.EventHandler(this.BookingReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crReceiptViewer;
    }
}