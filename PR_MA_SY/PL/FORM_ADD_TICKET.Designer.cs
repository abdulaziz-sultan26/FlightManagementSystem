namespace PR_MA_SY.PL
{
    partial class FORM_ADD_TICKET
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
            this.CANCEL_TICKET_BTN = new System.Windows.Forms.Button();
            this.ADD_TICKET_BTN = new System.Windows.Forms.Button();
            this.COMB_GET_PASS_NAME = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.COMB_GET_FLIGHT_TIME = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.COMB_SEATNUBER = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_TICKET_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CANCEL_TICKET_BTN);
            this.groupBox1.Controls.Add(this.ADD_TICKET_BTN);
            this.groupBox1.Controls.Add(this.COMB_GET_PASS_NAME);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.COMB_GET_FLIGHT_TIME);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.COMB_SEATNUBER);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_TICKET_ID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حجز التذاكر";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CANCEL_TICKET_BTN
            // 
            this.CANCEL_TICKET_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CANCEL_TICKET_BTN.BackColor = System.Drawing.Color.LightSlateGray;
            this.CANCEL_TICKET_BTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL_TICKET_BTN.Location = new System.Drawing.Point(252, 148);
            this.CANCEL_TICKET_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.CANCEL_TICKET_BTN.Name = "CANCEL_TICKET_BTN";
            this.CANCEL_TICKET_BTN.Size = new System.Drawing.Size(218, 49);
            this.CANCEL_TICKET_BTN.TabIndex = 22;
            this.CANCEL_TICKET_BTN.Text = "الغاء";
            this.CANCEL_TICKET_BTN.UseVisualStyleBackColor = false;
            this.CANCEL_TICKET_BTN.Click += new System.EventHandler(this.CANCEL_TICKET_BTN_Click);
            // 
            // ADD_TICKET_BTN
            // 
            this.ADD_TICKET_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ADD_TICKET_BTN.BackColor = System.Drawing.Color.LightSlateGray;
            this.ADD_TICKET_BTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_TICKET_BTN.Location = new System.Drawing.Point(24, 148);
            this.ADD_TICKET_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.ADD_TICKET_BTN.Name = "ADD_TICKET_BTN";
            this.ADD_TICKET_BTN.Size = new System.Drawing.Size(218, 49);
            this.ADD_TICKET_BTN.TabIndex = 21;
            this.ADD_TICKET_BTN.Text = "اضافة";
            this.ADD_TICKET_BTN.UseVisualStyleBackColor = false;
            this.ADD_TICKET_BTN.Click += new System.EventHandler(this.ADD_TICKET_BTN_Click);
            // 
            // COMB_GET_PASS_NAME
            // 
            this.COMB_GET_PASS_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMB_GET_PASS_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMB_GET_PASS_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMB_GET_PASS_NAME.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMB_GET_PASS_NAME.FormattingEnabled = true;
            this.COMB_GET_PASS_NAME.Items.AddRange(new object[] {
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
            this.COMB_GET_PASS_NAME.Location = new System.Drawing.Point(364, 96);
            this.COMB_GET_PASS_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_GET_PASS_NAME.Name = "COMB_GET_PASS_NAME";
            this.COMB_GET_PASS_NAME.Size = new System.Drawing.Size(216, 24);
            this.COMB_GET_PASS_NAME.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "اسم المسافر:";
            // 
            // COMB_GET_FLIGHT_TIME
            // 
            this.COMB_GET_FLIGHT_TIME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMB_GET_FLIGHT_TIME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMB_GET_FLIGHT_TIME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMB_GET_FLIGHT_TIME.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMB_GET_FLIGHT_TIME.FormattingEnabled = true;
            this.COMB_GET_FLIGHT_TIME.Items.AddRange(new object[] {
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
            this.COMB_GET_FLIGHT_TIME.Location = new System.Drawing.Point(28, 92);
            this.COMB_GET_FLIGHT_TIME.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_GET_FLIGHT_TIME.Name = "COMB_GET_FLIGHT_TIME";
            this.COMB_GET_FLIGHT_TIME.Size = new System.Drawing.Size(216, 24);
            this.COMB_GET_FLIGHT_TIME.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "وقت الرحلة:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // COMB_SEATNUBER
            // 
            this.COMB_SEATNUBER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMB_SEATNUBER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMB_SEATNUBER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMB_SEATNUBER.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMB_SEATNUBER.FormattingEnabled = true;
            this.COMB_SEATNUBER.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.COMB_SEATNUBER.Location = new System.Drawing.Point(28, 43);
            this.COMB_SEATNUBER.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_SEATNUBER.Name = "COMB_SEATNUBER";
            this.COMB_SEATNUBER.Size = new System.Drawing.Size(216, 24);
            this.COMB_SEATNUBER.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "رقم المقعد:";
            // 
            // TXT_TICKET_ID
            // 
            this.TXT_TICKET_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_TICKET_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_TICKET_ID.Location = new System.Drawing.Point(364, 47);
            this.TXT_TICKET_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_TICKET_ID.Name = "TXT_TICKET_ID";
            this.TXT_TICKET_ID.Size = new System.Drawing.Size(216, 24);
            this.TXT_TICKET_ID.TabIndex = 7;
            this.TXT_TICKET_ID.Validated += new System.EventHandler(this.TXT_TICKET_ID_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "رقم التذكرة:";
            // 
            // FORM_ADD_TICKET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(716, 259);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FORM_ADD_TICKET";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قسم التذاكر";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox COMB_GET_FLIGHT_TIME;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox COMB_SEATNUBER;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TXT_TICKET_ID;
        public System.Windows.Forms.ComboBox COMB_GET_PASS_NAME;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CANCEL_TICKET_BTN;
        public System.Windows.Forms.Button ADD_TICKET_BTN;
        public System.Windows.Forms.Label label4;
    }
}