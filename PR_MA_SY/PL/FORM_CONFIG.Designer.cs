namespace PR_MA_SY.PL
{
    partial class FORM_CONFIG
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_btn_win = new System.Windows.Forms.RadioButton();
            this.radio_btn_sql = new System.Windows.Forms.RadioButton();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save_config = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السيرفر:";
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(172, 37);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(279, 41);
            this.txt_server.TabIndex = 1;
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(172, 84);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(279, 41);
            this.txt_db.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "قاعدة البانات:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "طريقة الدخول:";
            // 
            // radio_btn_win
            // 
            this.radio_btn_win.AutoSize = true;
            this.radio_btn_win.Checked = true;
            this.radio_btn_win.Location = new System.Drawing.Point(172, 163);
            this.radio_btn_win.Name = "radio_btn_win";
            this.radio_btn_win.Size = new System.Drawing.Size(247, 38);
            this.radio_btn_win.TabIndex = 5;
            this.radio_btn_win.TabStop = true;
            this.radio_btn_win.Text = "Windows Authentication";
            this.radio_btn_win.UseVisualStyleBackColor = true;
            this.radio_btn_win.CheckedChanged += new System.EventHandler(this.radio_btn_win_CheckedChanged);
            // 
            // radio_btn_sql
            // 
            this.radio_btn_sql.AutoSize = true;
            this.radio_btn_sql.Location = new System.Drawing.Point(172, 217);
            this.radio_btn_sql.Name = "radio_btn_sql";
            this.radio_btn_sql.Size = new System.Drawing.Size(267, 38);
            this.radio_btn_sql.TabIndex = 6;
            this.radio_btn_sql.Text = "SQL Server Authentication";
            this.radio_btn_sql.UseVisualStyleBackColor = true;
            this.radio_btn_sql.CheckedChanged += new System.EventHandler(this.radio_btn_sql_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(160, 336);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.ReadOnly = true;
            this.txt_pass.Size = new System.Drawing.Size(279, 41);
            this.txt_pass.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "كلمة المرور:";
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(160, 289);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.ReadOnly = true;
            this.txt_user_name.Size = new System.Drawing.Size(279, 41);
            this.txt_user_name.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المستخدم:";
            // 
            // btn_save_config
            // 
            this.btn_save_config.Location = new System.Drawing.Point(172, 432);
            this.btn_save_config.Name = "btn_save_config";
            this.btn_save_config.Size = new System.Drawing.Size(118, 53);
            this.btn_save_config.TabIndex = 11;
            this.btn_save_config.Text = "حفظ الاعدادات";
            this.btn_save_config.UseVisualStyleBackColor = true;
            this.btn_save_config.Click += new System.EventHandler(this.btn_save_config_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(321, 432);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(118, 53);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "الخروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FORM_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 558);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_save_config);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radio_btn_sql);
            this.Controls.Add(this.radio_btn_win);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_server);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "FORM_CONFIG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة التحكم في اعدادات الاتصال بالسيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_btn_win;
        private System.Windows.Forms.RadioButton radio_btn_sql;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_save_config;
        private System.Windows.Forms.Button btn_exit;
    }
}