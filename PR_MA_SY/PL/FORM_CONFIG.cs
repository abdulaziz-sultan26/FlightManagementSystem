using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_MA_SY.PL
{
    public partial class FORM_CONFIG : Form
    {
        public FORM_CONFIG()
        {
            InitializeComponent();
            txt_server.Text = Properties.Settings.Default.Server;
            txt_db.Text = Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                radio_btn_sql.Checked = true;

                txt_user_name.Text = Properties.Settings.Default.ID;
                txt_pass.Text = Properties.Settings.Default.Password;
            }
            else
            {
                radio_btn_win.Checked = true;
                txt_user_name.Clear();
                txt_pass.Clear();
                txt_user_name.ReadOnly = true; 
                txt_pass.ReadOnly = true;
            }
            
            
        }

        private void btn_save_config_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txt_server.Text;
            Properties.Settings.Default.Database = txt_db.Text;
            Properties.Settings.Default.Mode = radio_btn_sql.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.ID = txt_user_name.Text;
            Properties.Settings.Default.Password = txt_pass.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("تمت الحفظ بنجاح", " حفظ الاعدادات", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radio_btn_sql_CheckedChanged(object sender, EventArgs e)
        {
            //في حالة قام المستخدم بادخال معلومات الاتصال من خلال اس كيو ال سيرفر يتم الغاء تفعيل القراءة فقط 

            txt_user_name.ReadOnly = false;
            txt_pass.ReadOnly = false;
        }

        private void radio_btn_win_CheckedChanged(object sender, EventArgs e)
        {
            txt_user_name.ReadOnly = true;
            txt_pass.ReadOnly = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
  
}
