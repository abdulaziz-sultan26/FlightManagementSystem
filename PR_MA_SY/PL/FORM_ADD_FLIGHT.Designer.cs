namespace PR_MA_SY.PL
{
    partial class FORM_ADD_FLIGHT
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
            this.GBOX_FLIGHT = new System.Windows.Forms.GroupBox();
            this.COMB_FLIGHT_PLANE_NAME = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.COMP_FLIGHT_CAPTIN = new System.Windows.Forms.ComboBox();
            this.COMP_LEAVING_TIME = new System.Windows.Forms.DateTimePicker();
            this.COMP_ARRIVAL_TIME = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancel_FLIGHT = new System.Windows.Forms.Button();
            this.btn_add_FLIGHT = new System.Windows.Forms.Button();
            this.COMP_AIRPORT_ARRIVAL = new System.Windows.Forms.ComboBox();
            this.COMP_AIRPORT_LEAVING = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_FLIGHT_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBOX_FLIGHT.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBOX_FLIGHT
            // 
            this.GBOX_FLIGHT.Controls.Add(this.COMB_FLIGHT_PLANE_NAME);
            this.GBOX_FLIGHT.Controls.Add(this.label6);
            this.GBOX_FLIGHT.Controls.Add(this.COMP_FLIGHT_CAPTIN);
            this.GBOX_FLIGHT.Controls.Add(this.COMP_LEAVING_TIME);
            this.GBOX_FLIGHT.Controls.Add(this.COMP_ARRIVAL_TIME);
            this.GBOX_FLIGHT.Controls.Add(this.label8);
            this.GBOX_FLIGHT.Controls.Add(this.btn_cancel_FLIGHT);
            this.GBOX_FLIGHT.Controls.Add(this.btn_add_FLIGHT);
            this.GBOX_FLIGHT.Controls.Add(this.COMP_AIRPORT_ARRIVAL);
            this.GBOX_FLIGHT.Controls.Add(this.COMP_AIRPORT_LEAVING);
            this.GBOX_FLIGHT.Controls.Add(this.label5);
            this.GBOX_FLIGHT.Controls.Add(this.label3);
            this.GBOX_FLIGHT.Controls.Add(this.label4);
            this.GBOX_FLIGHT.Controls.Add(this.label2);
            this.GBOX_FLIGHT.Controls.Add(this.TXT_FLIGHT_ID);
            this.GBOX_FLIGHT.Controls.Add(this.label1);
            this.GBOX_FLIGHT.ForeColor = System.Drawing.Color.Blue;
            this.GBOX_FLIGHT.Location = new System.Drawing.Point(12, 12);
            this.GBOX_FLIGHT.Name = "GBOX_FLIGHT";
            this.GBOX_FLIGHT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GBOX_FLIGHT.Size = new System.Drawing.Size(939, 308);
            this.GBOX_FLIGHT.TabIndex = 0;
            this.GBOX_FLIGHT.TabStop = false;
            this.GBOX_FLIGHT.Text = "اضافة رحلة جديدة";
            // 
            // COMB_FLIGHT_PLANE_NAME
            // 
            this.COMB_FLIGHT_PLANE_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMB_FLIGHT_PLANE_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMB_FLIGHT_PLANE_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMB_FLIGHT_PLANE_NAME.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMB_FLIGHT_PLANE_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMB_FLIGHT_PLANE_NAME.FormattingEnabled = true;
            this.COMB_FLIGHT_PLANE_NAME.Location = new System.Drawing.Point(497, 228);
            this.COMB_FLIGHT_PLANE_NAME.Margin = new System.Windows.Forms.Padding(4);
            this.COMB_FLIGHT_PLANE_NAME.Name = "COMB_FLIGHT_PLANE_NAME";
            this.COMB_FLIGHT_PLANE_NAME.Size = new System.Drawing.Size(260, 24);
            this.COMB_FLIGHT_PLANE_NAME.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSlateGray;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(765, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "اسم الطائرة:";
            // 
            // COMP_FLIGHT_CAPTIN
            // 
            this.COMP_FLIGHT_CAPTIN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMP_FLIGHT_CAPTIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMP_FLIGHT_CAPTIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_FLIGHT_CAPTIN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMP_FLIGHT_CAPTIN.FormattingEnabled = true;
            this.COMP_FLIGHT_CAPTIN.ItemHeight = 16;
            this.COMP_FLIGHT_CAPTIN.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.COMP_FLIGHT_CAPTIN.Location = new System.Drawing.Point(48, 71);
            this.COMP_FLIGHT_CAPTIN.Margin = new System.Windows.Forms.Padding(4);
            this.COMP_FLIGHT_CAPTIN.Name = "COMP_FLIGHT_CAPTIN";
            this.COMP_FLIGHT_CAPTIN.Size = new System.Drawing.Size(318, 24);
            this.COMP_FLIGHT_CAPTIN.TabIndex = 1;
            // 
            // COMP_LEAVING_TIME
            // 
            this.COMP_LEAVING_TIME.CustomFormat = "yyyy-MM-dd";
            this.COMP_LEAVING_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.COMP_LEAVING_TIME.Location = new System.Drawing.Point(48, 133);
            this.COMP_LEAVING_TIME.Name = "COMP_LEAVING_TIME";
            this.COMP_LEAVING_TIME.Size = new System.Drawing.Size(318, 24);
            this.COMP_LEAVING_TIME.TabIndex = 3;
            this.COMP_LEAVING_TIME.ValueChanged += new System.EventHandler(this.DateTP_LEAVING_ValueChanged);
            // 
            // COMP_ARRIVAL_TIME
            // 
            this.COMP_ARRIVAL_TIME.CustomFormat = "yyyy-MM-dd";
            this.COMP_ARRIVAL_TIME.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.COMP_ARRIVAL_TIME.Location = new System.Drawing.Point(497, 125);
            this.COMP_ARRIVAL_TIME.Name = "COMP_ARRIVAL_TIME";
            this.COMP_ARRIVAL_TIME.Size = new System.Drawing.Size(260, 24);
            this.COMP_ARRIVAL_TIME.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSlateGray;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(374, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 40;
            this.label8.Text = "قائد الرحلة:";
            // 
            // btn_cancel_FLIGHT
            // 
            this.btn_cancel_FLIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel_FLIGHT.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_cancel_FLIGHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_FLIGHT.Location = new System.Drawing.Point(209, 239);
            this.btn_cancel_FLIGHT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel_FLIGHT.Name = "btn_cancel_FLIGHT";
            this.btn_cancel_FLIGHT.Size = new System.Drawing.Size(142, 49);
            this.btn_cancel_FLIGHT.TabIndex = 8;
            this.btn_cancel_FLIGHT.Text = "الغاء";
            this.btn_cancel_FLIGHT.UseVisualStyleBackColor = false;
            this.btn_cancel_FLIGHT.Click += new System.EventHandler(this.btn_cancel_FLIGHT_Click);
            // 
            // btn_add_FLIGHT
            // 
            this.btn_add_FLIGHT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_FLIGHT.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_add_FLIGHT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_FLIGHT.Location = new System.Drawing.Point(48, 239);
            this.btn_add_FLIGHT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_FLIGHT.Name = "btn_add_FLIGHT";
            this.btn_add_FLIGHT.Size = new System.Drawing.Size(142, 49);
            this.btn_add_FLIGHT.TabIndex = 7;
            this.btn_add_FLIGHT.Text = "اضافة";
            this.btn_add_FLIGHT.UseVisualStyleBackColor = false;
            this.btn_add_FLIGHT.Click += new System.EventHandler(this.btn_add_FLIGHT_Click);
            // 
            // COMP_AIRPORT_ARRIVAL
            // 
            this.COMP_AIRPORT_ARRIVAL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMP_AIRPORT_ARRIVAL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMP_AIRPORT_ARRIVAL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_AIRPORT_ARRIVAL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMP_AIRPORT_ARRIVAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_AIRPORT_ARRIVAL.FormattingEnabled = true;
            this.COMP_AIRPORT_ARRIVAL.ItemHeight = 16;
            this.COMP_AIRPORT_ARRIVAL.Location = new System.Drawing.Point(48, 185);
            this.COMP_AIRPORT_ARRIVAL.Margin = new System.Windows.Forms.Padding(4);
            this.COMP_AIRPORT_ARRIVAL.Name = "COMP_AIRPORT_ARRIVAL";
            this.COMP_AIRPORT_ARRIVAL.Size = new System.Drawing.Size(318, 24);
            this.COMP_AIRPORT_ARRIVAL.TabIndex = 5;
            // 
            // COMP_AIRPORT_LEAVING
            // 
            this.COMP_AIRPORT_LEAVING.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.COMP_AIRPORT_LEAVING.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.COMP_AIRPORT_LEAVING.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.COMP_AIRPORT_LEAVING.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.COMP_AIRPORT_LEAVING.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMP_AIRPORT_LEAVING.FormattingEnabled = true;
            this.COMP_AIRPORT_LEAVING.Location = new System.Drawing.Point(497, 182);
            this.COMP_AIRPORT_LEAVING.Margin = new System.Windows.Forms.Padding(4);
            this.COMP_AIRPORT_LEAVING.Name = "COMP_AIRPORT_LEAVING";
            this.COMP_AIRPORT_LEAVING.Size = new System.Drawing.Size(260, 24);
            this.COMP_AIRPORT_LEAVING.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSlateGray;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "مطار الوصول:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "تاريخ المغادرة:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "وقت الرحلة:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "مطار الاقلاع:";
            // 
            // TXT_FLIGHT_ID
            // 
            this.TXT_FLIGHT_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_FLIGHT_ID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_FLIGHT_ID.Location = new System.Drawing.Point(497, 65);
            this.TXT_FLIGHT_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_FLIGHT_ID.Name = "TXT_FLIGHT_ID";
            this.TXT_FLIGHT_ID.Size = new System.Drawing.Size(260, 24);
            this.TXT_FLIGHT_ID.TabIndex = 0;
            this.TXT_FLIGHT_ID.Validated += new System.EventHandler(this.TXT_FLIGHT_ID_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(765, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "رقم الرحلة:";
            // 
            // FORM_ADD_FLIGHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(963, 334);
            this.Controls.Add(this.GBOX_FLIGHT);
            this.MaximizeBox = false;
            this.Name = "FORM_ADD_FLIGHT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رحلة جديدة";
            this.GBOX_FLIGHT.ResumeLayout(false);
            this.GBOX_FLIGHT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker COMP_LEAVING_TIME;
        private System.Windows.Forms.DateTimePicker COMP_ARRIVAL_TIME;
        private System.Windows.Forms.Button btn_cancel_FLIGHT;
        public System.Windows.Forms.Button btn_add_FLIGHT;
        public System.Windows.Forms.ComboBox COMP_AIRPORT_ARRIVAL;
        public System.Windows.Forms.ComboBox COMP_AIRPORT_LEAVING;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TXT_FLIGHT_ID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox COMP_FLIGHT_CAPTIN;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox GBOX_FLIGHT;
        public System.Windows.Forms.ComboBox COMB_FLIGHT_PLANE_NAME;
        public System.Windows.Forms.Label label6;
    }
}