namespace PR_MA_SY.PL
{
    partial class FORM_TICKET_MANAGE
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
            this.TXT_BOX_SEARCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DATA_GRID_VIEW_TICKET = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_ADD_TICK = new System.Windows.Forms.Button();
            this.BTN_EXIT_TICK = new System.Windows.Forms.Button();
            this.BTN_SAFE_TICK = new System.Windows.Forms.Button();
            this.BTN_PRINTALL_TICK = new System.Windows.Forms.Button();
            this.BTN_PRINT_TICK = new System.Windows.Forms.Button();
            this.BTN_DELETE_TICK = new System.Windows.Forms.Button();
            this.BTN_EDIT_TICK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_GRID_VIEW_TICKET)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.TXT_BOX_SEARCH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1030, 682);
            this.panel1.TabIndex = 1;
            // 
            // TXT_BOX_SEARCH
            // 
            this.TXT_BOX_SEARCH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TXT_BOX_SEARCH.Location = new System.Drawing.Point(181, 26);
            this.TXT_BOX_SEARCH.Name = "TXT_BOX_SEARCH";
            this.TXT_BOX_SEARCH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXT_BOX_SEARCH.Size = new System.Drawing.Size(414, 24);
            this.TXT_BOX_SEARCH.TabIndex = 0;
            this.TXT_BOX_SEARCH.TextChanged += new System.EventHandler(this.TXT_BOX_FOR_SEARCHING_TextChanged);
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
            this.groupBox2.Controls.Add(this.DATA_GRID_VIEW_TICKET);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(15, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(990, 485);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة التذاكر";
            // 
            // DATA_GRID_VIEW_TICKET
            // 
            this.DATA_GRID_VIEW_TICKET.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA_GRID_VIEW_TICKET.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.DATA_GRID_VIEW_TICKET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_GRID_VIEW_TICKET.Location = new System.Drawing.Point(23, 31);
            this.DATA_GRID_VIEW_TICKET.Name = "DATA_GRID_VIEW_TICKET";
            this.DATA_GRID_VIEW_TICKET.RowHeadersWidth = 51;
            this.DATA_GRID_VIEW_TICKET.RowTemplate.Height = 26;
            this.DATA_GRID_VIEW_TICKET.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATA_GRID_VIEW_TICKET.Size = new System.Drawing.Size(943, 429);
            this.DATA_GRID_VIEW_TICKET.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_ADD_TICK);
            this.groupBox1.Controls.Add(this.BTN_EXIT_TICK);
            this.groupBox1.Controls.Add(this.BTN_SAFE_TICK);
            this.groupBox1.Controls.Add(this.BTN_PRINTALL_TICK);
            this.groupBox1.Controls.Add(this.BTN_PRINT_TICK);
            this.groupBox1.Controls.Add(this.BTN_DELETE_TICK);
            this.groupBox1.Controls.Add(this.BTN_EDIT_TICK);
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
            // BTN_ADD_TICK
            // 
            this.BTN_ADD_TICK.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_ADD_TICK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ADD_TICK.ForeColor = System.Drawing.Color.Blue;
            this.BTN_ADD_TICK.Location = new System.Drawing.Point(748, 31);
            this.BTN_ADD_TICK.Name = "BTN_ADD_TICK";
            this.BTN_ADD_TICK.Size = new System.Drawing.Size(113, 39);
            this.BTN_ADD_TICK.TabIndex = 1;
            this.BTN_ADD_TICK.Text = "اضافة";
            this.BTN_ADD_TICK.UseVisualStyleBackColor = false;
            this.BTN_ADD_TICK.Click += new System.EventHandler(this.BTN_ADD_TICK_Click);
            // 
            // BTN_EXIT_TICK
            // 
            this.BTN_EXIT_TICK.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_EXIT_TICK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXIT_TICK.ForeColor = System.Drawing.Color.Blue;
            this.BTN_EXIT_TICK.Location = new System.Drawing.Point(23, 31);
            this.BTN_EXIT_TICK.Name = "BTN_EXIT_TICK";
            this.BTN_EXIT_TICK.Size = new System.Drawing.Size(113, 39);
            this.BTN_EXIT_TICK.TabIndex = 7;
            this.BTN_EXIT_TICK.Text = "خروج";
            this.BTN_EXIT_TICK.UseVisualStyleBackColor = false;
            this.BTN_EXIT_TICK.Click += new System.EventHandler(this.BTN_EXIT_TICK_Click);
            // 
            // BTN_SAFE_TICK
            // 
            this.BTN_SAFE_TICK.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_SAFE_TICK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SAFE_TICK.ForeColor = System.Drawing.Color.Blue;
            this.BTN_SAFE_TICK.Location = new System.Drawing.Point(142, 31);
            this.BTN_SAFE_TICK.Name = "BTN_SAFE_TICK";
            this.BTN_SAFE_TICK.Size = new System.Drawing.Size(113, 39);
            this.BTN_SAFE_TICK.TabIndex = 6;
            this.BTN_SAFE_TICK.Text = "حفظ";
            this.BTN_SAFE_TICK.UseVisualStyleBackColor = false;
            // 
            // BTN_PRINTALL_TICK
            // 
            this.BTN_PRINTALL_TICK.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_PRINTALL_TICK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRINTALL_TICK.ForeColor = System.Drawing.Color.Blue;
            this.BTN_PRINTALL_TICK.Location = new System.Drawing.Point(261, 31);
            this.BTN_PRINTALL_TICK.Name = "BTN_PRINTALL_TICK";
            this.BTN_PRINTALL_TICK.Size = new System.Drawing.Size(113, 39);
            this.BTN_PRINTALL_TICK.TabIndex = 5;
            this.BTN_PRINTALL_TICK.Text = "طباعة الكل";
            this.BTN_PRINTALL_TICK.UseVisualStyleBackColor = false;
            this.BTN_PRINTALL_TICK.Click += new System.EventHandler(this.BTN_PRINTALL_TICK_Click);
            // 
            // BTN_PRINT_TICK
            // 
            this.BTN_PRINT_TICK.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_PRINT_TICK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRINT_TICK.ForeColor = System.Drawing.Color.Blue;
            this.BTN_PRINT_TICK.Location = new System.Drawing.Point(380, 31);
            this.BTN_PRINT_TICK.Name = "BTN_PRINT_TICK";
            this.BTN_PRINT_TICK.Size = new System.Drawing.Size(113, 39);
            this.BTN_PRINT_TICK.TabIndex = 4;
            this.BTN_PRINT_TICK.Text = "طباعة";
            this.BTN_PRINT_TICK.UseVisualStyleBackColor = false;
            this.BTN_PRINT_TICK.Click += new System.EventHandler(this.BTN_PRINT_TICK_Click);
            // 
            // BTN_DELETE_TICK
            // 
            this.BTN_DELETE_TICK.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_DELETE_TICK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DELETE_TICK.ForeColor = System.Drawing.Color.Blue;
            this.BTN_DELETE_TICK.Location = new System.Drawing.Point(499, 31);
            this.BTN_DELETE_TICK.Name = "BTN_DELETE_TICK";
            this.BTN_DELETE_TICK.Size = new System.Drawing.Size(113, 39);
            this.BTN_DELETE_TICK.TabIndex = 3;
            this.BTN_DELETE_TICK.Text = "حذف";
            this.BTN_DELETE_TICK.UseVisualStyleBackColor = false;
            this.BTN_DELETE_TICK.Click += new System.EventHandler(this.BTN_DELETE_TICK_Click);
            // 
            // BTN_EDIT_TICK
            // 
            this.BTN_EDIT_TICK.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTN_EDIT_TICK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EDIT_TICK.ForeColor = System.Drawing.Color.Blue;
            this.BTN_EDIT_TICK.Location = new System.Drawing.Point(629, 31);
            this.BTN_EDIT_TICK.Name = "BTN_EDIT_TICK";
            this.BTN_EDIT_TICK.Size = new System.Drawing.Size(113, 39);
            this.BTN_EDIT_TICK.TabIndex = 2;
            this.BTN_EDIT_TICK.Text = "تعديل";
            this.BTN_EDIT_TICK.UseVisualStyleBackColor = false;
            this.BTN_EDIT_TICK.Click += new System.EventHandler(this.BTN_EDIT_TICK_Click);
            // 
            // FORM_TICKET_MANAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1049, 703);
            this.Controls.Add(this.panel1);
            this.Name = "FORM_TICKET_MANAGE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة التذاكر";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATA_GRID_VIEW_TICKET)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXT_BOX_SEARCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView DATA_GRID_VIEW_TICKET;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_ADD_TICK;
        private System.Windows.Forms.Button BTN_EXIT_TICK;
        private System.Windows.Forms.Button BTN_SAFE_TICK;
        private System.Windows.Forms.Button BTN_PRINTALL_TICK;
        private System.Windows.Forms.Button BTN_PRINT_TICK;
        private System.Windows.Forms.Button BTN_DELETE_TICK;
        private System.Windows.Forms.Button BTN_EDIT_TICK;
    }
}