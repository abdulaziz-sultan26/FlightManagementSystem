namespace PR_MA_SY.PL
{
    partial class FORM_ADD_NEW_AIRPORT
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_air_name = new System.Windows.Forms.TextBox();
            this.txt_air_id = new System.Windows.Forms.TextBox();
            this.txt_air_location = new System.Windows.Forms.TextBox();
            this.btn_cancel_airport = new System.Windows.Forms.Button();
            this.btn_add_airport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(86, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المطار:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(96, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "رقم المطار:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(86, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "موقع المطار:";
            // 
            // txt_air_name
            // 
            this.txt_air_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_air_name.Location = new System.Drawing.Point(213, 26);
            this.txt_air_name.Name = "txt_air_name";
            this.txt_air_name.Size = new System.Drawing.Size(318, 24);
            this.txt_air_name.TabIndex = 0;
            // 
            // txt_air_id
            // 
            this.txt_air_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_air_id.Location = new System.Drawing.Point(213, 82);
            this.txt_air_id.Name = "txt_air_id";
            this.txt_air_id.Size = new System.Drawing.Size(318, 24);
            this.txt_air_id.TabIndex = 1;
            this.txt_air_id.Validated += new System.EventHandler(this.txt_air_id_Validated);
            // 
            // txt_air_location
            // 
            this.txt_air_location.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_air_location.Location = new System.Drawing.Point(213, 141);
            this.txt_air_location.Name = "txt_air_location";
            this.txt_air_location.Size = new System.Drawing.Size(318, 24);
            this.txt_air_location.TabIndex = 2;
            // 
            // btn_cancel_airport
            // 
            this.btn_cancel_airport.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_cancel_airport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_airport.ForeColor = System.Drawing.Color.Blue;
            this.btn_cancel_airport.Location = new System.Drawing.Point(277, 193);
            this.btn_cancel_airport.Name = "btn_cancel_airport";
            this.btn_cancel_airport.Size = new System.Drawing.Size(159, 43);
            this.btn_cancel_airport.TabIndex = 4;
            this.btn_cancel_airport.Text = "الغاء";
            this.btn_cancel_airport.UseVisualStyleBackColor = false;
            this.btn_cancel_airport.Click += new System.EventHandler(this.btn_cancel_airport_Click);
            // 
            // btn_add_airport
            // 
            this.btn_add_airport.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_add_airport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_airport.ForeColor = System.Drawing.Color.Blue;
            this.btn_add_airport.Location = new System.Drawing.Point(451, 193);
            this.btn_add_airport.Name = "btn_add_airport";
            this.btn_add_airport.Size = new System.Drawing.Size(159, 43);
            this.btn_add_airport.TabIndex = 3;
            this.btn_add_airport.Text = "اضافة";
            this.btn_add_airport.UseVisualStyleBackColor = false;
            this.btn_add_airport.Click += new System.EventHandler(this.btn_add_airport_Click);
            // 
            // FORM_ADD_NEW_AIRPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(634, 275);
            this.Controls.Add(this.btn_add_airport);
            this.Controls.Add(this.btn_cancel_airport);
            this.Controls.Add(this.txt_air_location);
            this.Controls.Add(this.txt_air_id);
            this.Controls.Add(this.txt_air_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FORM_ADD_NEW_AIRPORT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مطار جديد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_air_name;
        private System.Windows.Forms.TextBox txt_air_id;
        private System.Windows.Forms.TextBox txt_air_location;
        private System.Windows.Forms.Button btn_cancel_airport;
        private System.Windows.Forms.Button btn_add_airport;
    }
}