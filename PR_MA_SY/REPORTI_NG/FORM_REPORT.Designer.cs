namespace PR_MA_SY.REPORTI_NG
{
    partial class FORM_REPORT
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
            this.CRYSTALREPORT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRYSTALREPORT
            // 
            this.CRYSTALREPORT.ActiveViewIndex = -1;
            this.CRYSTALREPORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRYSTALREPORT.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRYSTALREPORT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRYSTALREPORT.Location = new System.Drawing.Point(0, 0);
            this.CRYSTALREPORT.Name = "CRYSTALREPORT";
            this.CRYSTALREPORT.Size = new System.Drawing.Size(759, 718);
            this.CRYSTALREPORT.TabIndex = 0;
            // 
            // FORM_REPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 718);
            this.Controls.Add(this.CRYSTALREPORT);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FORM_REPORT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة تقرير تذكرة";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer CRYSTALREPORT;
    }
}