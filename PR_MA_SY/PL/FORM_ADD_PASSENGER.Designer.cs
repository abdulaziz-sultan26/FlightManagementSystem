namespace PR_MA_SY.PL
{
    partial class FORM_ADD_PASSENGER
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CANCEL_BTN = new System.Windows.Forms.Button();
            this.ADD_PASS_BTN = new System.Windows.Forms.Button();
            this.COMB_GEN = new System.Windows.Forms.ComboBox();
            this.COMB_CNTRY = new System.Windows.Forms.ComboBox();
            this.TXT_PASSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_PHON = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_ADDR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_PASS_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.CANCEL_BTN);
            this.groupBox1.Controls.Add(this.ADD_PASS_BTN);
            this.groupBox1.Controls.Add(this.COMB_GEN);
            this.groupBox1.Controls.Add(this.COMB_CNTRY);
            this.groupBox1.Controls.Add(this.TXT_PASSP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXT_PHON);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_ADDR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_NAME);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_PASS_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(923, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات مسافر جديد";
            // 
            // CANCEL_BTN
            // 
            this.CANCEL_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CANCEL_BTN.BackColor = System.Drawing.Color.LightSlateGray;
            this.CANCEL_BTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL_BTN.Location = new System.Drawing.Point(429, 302);
            this.CANCEL_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.CANCEL_BTN.Name = "CANCEL_BTN";
            this.CANCEL_BTN.Size = new System.Drawing.Size(218, 49);
            this.CANCEL_BTN.TabIndex = 20;
            this.CANCEL_BTN.Text = "الغاء";
            this.CANCEL_BTN.UseVisualStyleBackColor = false;
            this.CANCEL_BTN.Click += new System.EventHandler(this.CANCEL_BTN_Click);
            // 
            // ADD_PASS_BTN
            // 
            this.ADD_PASS_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADD_PASS_BTN.BackColor = System.Drawing.Color.LightSlateGray;
            this.ADD_PASS_BTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_PASS_BTN.Location = new System.Drawing.Point(201, 302);
            this.ADD_PASS_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.ADD_PASS_BTN.Name = "ADD_PASS_BTN";
            this.ADD_PASS_BTN.Size = new System.Drawing.Size(218, 49);
            this.ADD_PASS_BTN.TabIndex = 7;
            this.ADD_PASS_BTN.Text = "اضافة";
            this.ADD_PASS_BTN.UseVisualStyleBackColor = false;
            this.ADD_PASS_BTN.Click += new System.EventHandler(this.ADD_PASS_BTN_Click);
            // 
            // COMB_GEN
            // 
            this.COMB_GEN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMB_GEN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMB_GEN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMB_GEN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMB_GEN.FormattingEnabled = true;
            this.COMB_GEN.ItemHeight = 21;
            this.COMB_GEN.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.COMB_GEN.Location = new System.Drawing.Point(482, 247);
            this.COMB_GEN.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_GEN.Name = "COMB_GEN";
            this.COMB_GEN.Size = new System.Drawing.Size(252, 29);
            this.COMB_GEN.TabIndex = 17;
            this.COMB_GEN.SelectedIndexChanged += new System.EventHandler(this.COMB_GEN_SelectedIndexChanged);
            // 
            // COMB_CNTRY
            // 
            this.COMB_CNTRY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMB_CNTRY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMB_CNTRY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMB_CNTRY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMB_CNTRY.FormattingEnabled = true;
            this.COMB_CNTRY.Items.AddRange(new object[] {
            "اليمن",
            "اثيوبي",
            "الهند",
            "السعودية",
            "عمان",
            "البحرين",
            "الامارات",
            "قطر",
            "الكويت",
            "مصر",
            "اثيوبيا",
            "ارتيريا",
            "الصومال"});
            this.COMB_CNTRY.Location = new System.Drawing.Point(33, 146);
            this.COMB_CNTRY.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_CNTRY.Name = "COMB_CNTRY";
            this.COMB_CNTRY.Size = new System.Drawing.Size(310, 29);
            this.COMB_CNTRY.TabIndex = 3;
            this.COMB_CNTRY.SelectedIndexChanged += new System.EventHandler(this.COMB_CNTRY_SelectedIndexChanged);
            // 
            // TXT_PASSP
            // 
            this.TXT_PASSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_PASSP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_PASSP.Location = new System.Drawing.Point(33, 201);
            this.TXT_PASSP.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PASSP.Name = "TXT_PASSP";
            this.TXT_PASSP.Size = new System.Drawing.Size(310, 28);
            this.TXT_PASSP.TabIndex = 5;
            this.TXT_PASSP.TextChanged += new System.EventHandler(this.TXT_PASSP_TextChanged);
            this.TXT_PASSP.Validated += new System.EventHandler(this.TXT_PASSP_Validated);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSlateGray;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "رقم الجواز:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSlateGray;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(742, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "الجنس:";
            // 
            // TXT_PHON
            // 
            this.TXT_PHON.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_PHON.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_PHON.Location = new System.Drawing.Point(482, 197);
            this.TXT_PHON.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PHON.Name = "TXT_PHON";
            this.TXT_PHON.Size = new System.Drawing.Size(252, 28);
            this.TXT_PHON.TabIndex = 4;
            this.TXT_PHON.TextChanged += new System.EventHandler(this.TXT_PHON_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSlateGray;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(742, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "رقم الهاتف:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "الدولة:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXT_ADDR
            // 
            this.TXT_ADDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_ADDR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_ADDR.Location = new System.Drawing.Point(482, 138);
            this.TXT_ADDR.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ADDR.Name = "TXT_ADDR";
            this.TXT_ADDR.Size = new System.Drawing.Size(252, 28);
            this.TXT_ADDR.TabIndex = 2;
            this.TXT_ADDR.TextChanged += new System.EventHandler(this.TXT_ADDR_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(742, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "العنوان:";
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NAME.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_NAME.Location = new System.Drawing.Point(33, 84);
            this.TXT_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(310, 28);
            this.TXT_NAME.TabIndex = 1;
            this.TXT_NAME.TextChanged += new System.EventHandler(this.TXT_NAME_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم المسافر:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXT_PASS_ID
            // 
            this.TXT_PASS_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_PASS_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_PASS_ID.Location = new System.Drawing.Point(482, 80);
            this.TXT_PASS_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_PASS_ID.Name = "TXT_PASS_ID";
            this.TXT_PASS_ID.Size = new System.Drawing.Size(252, 28);
            this.TXT_PASS_ID.TabIndex = 0;
            this.TXT_PASS_ID.TextChanged += new System.EventHandler(this.TXT_PASS_ID_TextChanged);
            this.TXT_PASS_ID.Validated += new System.EventHandler(this.TXT_PASS_ID_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(742, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم المسافر:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // FORM_ADD_PASSENGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(949, 422);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FORM_ADD_PASSENGER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل بيانات مسافر جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CANCEL_BTN;
        public System.Windows.Forms.Button ADD_PASS_BTN;
        public System.Windows.Forms.ComboBox COMB_GEN;
        public System.Windows.Forms.ComboBox COMB_CNTRY;
        public System.Windows.Forms.TextBox TXT_PASSP;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TXT_PHON;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TXT_ADDR;
        public System.Windows.Forms.TextBox TXT_NAME;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TXT_PASS_ID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}