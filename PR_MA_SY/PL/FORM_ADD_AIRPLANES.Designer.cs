namespace PR_MA_SY.PL
{
    partial class FORM_ADD_AIRPLANES
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
            this.btn_add_airplane = new System.Windows.Forms.Button();
            this.btn_cancel_airplane = new System.Windows.Forms.Button();
            this.txt_airplane_manufacturer = new System.Windows.Forms.TextBox();
            this.txt_airplane_model = new System.Windows.Forms.TextBox();
            this.txt_airplane_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_airplane_seats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_airplane_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add_airplane
            // 
            this.btn_add_airplane.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_add_airplane.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_airplane.ForeColor = System.Drawing.Color.Blue;
            this.btn_add_airplane.Location = new System.Drawing.Point(463, 213);
            this.btn_add_airplane.Name = "btn_add_airplane";
            this.btn_add_airplane.Size = new System.Drawing.Size(159, 35);
            this.btn_add_airplane.TabIndex = 5;
            this.btn_add_airplane.Text = "اضافة";
            this.btn_add_airplane.UseVisualStyleBackColor = false;
            this.btn_add_airplane.Click += new System.EventHandler(this.btn_add_airplane_Click);
            // 
            // btn_cancel_airplane
            // 
            this.btn_cancel_airplane.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_cancel_airplane.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_airplane.ForeColor = System.Drawing.Color.Blue;
            this.btn_cancel_airplane.Location = new System.Drawing.Point(287, 213);
            this.btn_cancel_airplane.Name = "btn_cancel_airplane";
            this.btn_cancel_airplane.Size = new System.Drawing.Size(159, 35);
            this.btn_cancel_airplane.TabIndex = 6;
            this.btn_cancel_airplane.Text = "الغاء";
            this.btn_cancel_airplane.UseVisualStyleBackColor = false;
            this.btn_cancel_airplane.Click += new System.EventHandler(this.btn_cancel_airplane_Click);
            // 
            // txt_airplane_manufacturer
            // 
            this.txt_airplane_manufacturer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_airplane_manufacturer.Location = new System.Drawing.Point(307, 155);
            this.txt_airplane_manufacturer.Name = "txt_airplane_manufacturer";
            this.txt_airplane_manufacturer.Size = new System.Drawing.Size(324, 24);
            this.txt_airplane_manufacturer.TabIndex = 4;
            // 
            // txt_airplane_model
            // 
            this.txt_airplane_model.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_airplane_model.Location = new System.Drawing.Point(197, 97);
            this.txt_airplane_model.Name = "txt_airplane_model";
            this.txt_airplane_model.Size = new System.Drawing.Size(179, 24);
            this.txt_airplane_model.TabIndex = 2;
            // 
            // txt_airplane_id
            // 
            this.txt_airplane_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_airplane_id.Location = new System.Drawing.Point(197, 42);
            this.txt_airplane_id.Name = "txt_airplane_id";
            this.txt_airplane_id.Size = new System.Drawing.Size(179, 24);
            this.txt_airplane_id.TabIndex = 0;
            this.txt_airplane_id.Validated += new System.EventHandler(this.txt_airplane_id_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(146, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "الشركة المصنعة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSlateGray;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(66, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "موديل الطائرة:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "رقم الطائرة:";
            // 
            // txt_airplane_seats
            // 
            this.txt_airplane_seats.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_airplane_seats.Location = new System.Drawing.Point(531, 97);
            this.txt_airplane_seats.Name = "txt_airplane_seats";
            this.txt_airplane_seats.Size = new System.Drawing.Size(179, 24);
            this.txt_airplane_seats.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSlateGray;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(408, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "عدد المقاعد:";
            // 
            // txt_airplane_name
            // 
            this.txt_airplane_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_airplane_name.Location = new System.Drawing.Point(531, 42);
            this.txt_airplane_name.Name = "txt_airplane_name";
            this.txt_airplane_name.Size = new System.Drawing.Size(179, 24);
            this.txt_airplane_name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSlateGray;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(408, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "اسم الطائرة:";
            // 
            // FORM_ADD_AIRPLANES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(747, 279);
            this.Controls.Add(this.txt_airplane_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_airplane_seats);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add_airplane);
            this.Controls.Add(this.btn_cancel_airplane);
            this.Controls.Add(this.txt_airplane_manufacturer);
            this.Controls.Add(this.txt_airplane_model);
            this.Controls.Add(this.txt_airplane_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FORM_ADD_AIRPLANES";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة طاىرة جديدة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_airplane;
        private System.Windows.Forms.Button btn_cancel_airplane;
        private System.Windows.Forms.TextBox txt_airplane_manufacturer;
        private System.Windows.Forms.TextBox txt_airplane_model;
        private System.Windows.Forms.TextBox txt_airplane_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_airplane_seats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_airplane_name;
        private System.Windows.Forms.Label label5;
    }
}