namespace PR_MA_SY.PL
{
    partial class FORM_PASSENGER_MANAG
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXT_BOX_FOR_SEARCHING = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DATA_GRID_VIEW_PASSENGER = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_ADD_PASS = new System.Windows.Forms.Button();
            this.BTN_EXIT_PASS = new System.Windows.Forms.Button();
            this.BTN_SAFE_PASS = new System.Windows.Forms.Button();
            this.BTN_PRINTALL_PASS = new System.Windows.Forms.Button();
            this.BTN_PRINT_PASS = new System.Windows.Forms.Button();
            this.BTN_DELETE_PASS = new System.Windows.Forms.Button();
            this.BTN_EDIT_PASS = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_GRID_VIEW_PASSENGER)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.TXT_BOX_FOR_SEARCHING);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1030, 682);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TXT_BOX_FOR_SEARCHING
            // 
            this.TXT_BOX_FOR_SEARCHING.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_BOX_FOR_SEARCHING.Location = new System.Drawing.Point(257, 26);
            this.TXT_BOX_FOR_SEARCHING.Name = "TXT_BOX_FOR_SEARCHING";
            this.TXT_BOX_FOR_SEARCHING.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_BOX_FOR_SEARCHING.Size = new System.Drawing.Size(338, 24);
            this.TXT_BOX_FOR_SEARCHING.TabIndex = 1;
            this.TXT_BOX_FOR_SEARCHING.TextChanged += new System.EventHandler(this.TXT_BOX_FOR_SEARCHING_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(601, 26);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "ابحث هنا :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DATA_GRID_VIEW_PASSENGER);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(15, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(990, 485);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة المسافرين";
            // 
            // DATA_GRID_VIEW_PASSENGER
            // 
            this.DATA_GRID_VIEW_PASSENGER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA_GRID_VIEW_PASSENGER.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.DATA_GRID_VIEW_PASSENGER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_GRID_VIEW_PASSENGER.Location = new System.Drawing.Point(23, 23);
            this.DATA_GRID_VIEW_PASSENGER.Name = "DATA_GRID_VIEW_PASSENGER";
            this.DATA_GRID_VIEW_PASSENGER.RowHeadersWidth = 51;
            this.DATA_GRID_VIEW_PASSENGER.RowTemplate.Height = 26;
            this.DATA_GRID_VIEW_PASSENGER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATA_GRID_VIEW_PASSENGER.Size = new System.Drawing.Size(943, 437);
            this.DATA_GRID_VIEW_PASSENGER.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_ADD_PASS);
            this.groupBox1.Controls.Add(this.BTN_EXIT_PASS);
            this.groupBox1.Controls.Add(this.BTN_SAFE_PASS);
            this.groupBox1.Controls.Add(this.BTN_PRINTALL_PASS);
            this.groupBox1.Controls.Add(this.BTN_PRINT_PASS);
            this.groupBox1.Controls.Add(this.BTN_DELETE_PASS);
            this.groupBox1.Controls.Add(this.BTN_EDIT_PASS);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(15, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(990, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات المتاحة";
            // 
            // BTN_ADD_PASS
            // 
            this.BTN_ADD_PASS.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_ADD_PASS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_PASS.ForeColor = System.Drawing.Color.Blue;
            this.BTN_ADD_PASS.Location = new System.Drawing.Point(761, 23);
            this.BTN_ADD_PASS.Name = "BTN_ADD_PASS";
            this.BTN_ADD_PASS.Size = new System.Drawing.Size(113, 39);
            this.BTN_ADD_PASS.TabIndex = 1;
            this.BTN_ADD_PASS.Text = "اضافة";
            this.BTN_ADD_PASS.UseVisualStyleBackColor = false;
            this.BTN_ADD_PASS.Click += new System.EventHandler(this.BTN_ADD_PASS_Click);
            // 
            // BTN_EXIT_PASS
            // 
            this.BTN_EXIT_PASS.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_EXIT_PASS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXIT_PASS.ForeColor = System.Drawing.Color.Blue;
            this.BTN_EXIT_PASS.Location = new System.Drawing.Point(47, 23);
            this.BTN_EXIT_PASS.Name = "BTN_EXIT_PASS";
            this.BTN_EXIT_PASS.Size = new System.Drawing.Size(113, 39);
            this.BTN_EXIT_PASS.TabIndex = 6;
            this.BTN_EXIT_PASS.Text = "خروج";
            this.BTN_EXIT_PASS.UseVisualStyleBackColor = false;
            this.BTN_EXIT_PASS.Click += new System.EventHandler(this.BTN_EXIT_PASS_Click);
            // 
            // BTN_SAFE_PASS
            // 
            this.BTN_SAFE_PASS.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_SAFE_PASS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SAFE_PASS.ForeColor = System.Drawing.Color.Blue;
            this.BTN_SAFE_PASS.Location = new System.Drawing.Point(166, 23);
            this.BTN_SAFE_PASS.Name = "BTN_SAFE_PASS";
            this.BTN_SAFE_PASS.Size = new System.Drawing.Size(113, 39);
            this.BTN_SAFE_PASS.TabIndex = 5;
            this.BTN_SAFE_PASS.Text = "حفظ";
            this.BTN_SAFE_PASS.UseVisualStyleBackColor = false;
            // 
            // BTN_PRINTALL_PASS
            // 
            this.BTN_PRINTALL_PASS.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_PRINTALL_PASS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRINTALL_PASS.ForeColor = System.Drawing.Color.Blue;
            this.BTN_PRINTALL_PASS.Location = new System.Drawing.Point(285, 23);
            this.BTN_PRINTALL_PASS.Name = "BTN_PRINTALL_PASS";
            this.BTN_PRINTALL_PASS.Size = new System.Drawing.Size(113, 39);
            this.BTN_PRINTALL_PASS.TabIndex = 4;
            this.BTN_PRINTALL_PASS.Text = "طباعة الكل";
            this.BTN_PRINTALL_PASS.UseVisualStyleBackColor = false;
            // 
            // BTN_PRINT_PASS
            // 
            this.BTN_PRINT_PASS.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_PRINT_PASS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRINT_PASS.ForeColor = System.Drawing.Color.Blue;
            this.BTN_PRINT_PASS.Location = new System.Drawing.Point(404, 23);
            this.BTN_PRINT_PASS.Name = "BTN_PRINT_PASS";
            this.BTN_PRINT_PASS.Size = new System.Drawing.Size(113, 39);
            this.BTN_PRINT_PASS.TabIndex = 3;
            this.BTN_PRINT_PASS.Text = "طباعة";
            this.BTN_PRINT_PASS.UseVisualStyleBackColor = false;
            this.BTN_PRINT_PASS.Click += new System.EventHandler(this.BTN_PRINT_PASS_Click);
            // 
            // BTN_DELETE_PASS
            // 
            this.BTN_DELETE_PASS.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_DELETE_PASS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_PASS.ForeColor = System.Drawing.Color.Blue;
            this.BTN_DELETE_PASS.Location = new System.Drawing.Point(523, 23);
            this.BTN_DELETE_PASS.Name = "BTN_DELETE_PASS";
            this.BTN_DELETE_PASS.Size = new System.Drawing.Size(113, 39);
            this.BTN_DELETE_PASS.TabIndex = 2;
            this.BTN_DELETE_PASS.Text = "حذف";
            this.BTN_DELETE_PASS.UseVisualStyleBackColor = false;
            this.BTN_DELETE_PASS.Click += new System.EventHandler(this.BTN_DELETE_PASS_Click);
            // 
            // BTN_EDIT_PASS
            // 
            this.BTN_EDIT_PASS.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_EDIT_PASS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EDIT_PASS.ForeColor = System.Drawing.Color.Blue;
            this.BTN_EDIT_PASS.Location = new System.Drawing.Point(642, 23);
            this.BTN_EDIT_PASS.Name = "BTN_EDIT_PASS";
            this.BTN_EDIT_PASS.Size = new System.Drawing.Size(113, 39);
            this.BTN_EDIT_PASS.TabIndex = 1;
            this.BTN_EDIT_PASS.Text = "تعديل";
            this.BTN_EDIT_PASS.UseVisualStyleBackColor = false;
            this.BTN_EDIT_PASS.Click += new System.EventHandler(this.BTN_EDIT_PASS_Click);
            // 
            // FORM_PASSENGER_MANAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1054, 706);
            this.Controls.Add(this.panel1);
            this.Name = "FORM_PASSENGER_MANAG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المسافرين";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATA_GRID_VIEW_PASSENGER)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_SAFE_PASS;
        private System.Windows.Forms.Button BTN_PRINTALL_PASS;
        private System.Windows.Forms.Button BTN_PRINT_PASS;
        private System.Windows.Forms.Button BTN_DELETE_PASS;
        private System.Windows.Forms.Button BTN_EDIT_PASS;
        private System.Windows.Forms.Button BTN_EXIT_PASS;
        private System.Windows.Forms.TextBox TXT_BOX_FOR_SEARCHING;
        private System.Windows.Forms.Button BTN_ADD_PASS;
        public System.Windows.Forms.DataGridView DATA_GRID_VIEW_PASSENGER;
    }
}