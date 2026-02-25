using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_MA_SY.PL
{
    public partial class FORM_LOGIN : Form
    {
        BL.CLASS_LOGIN log = new BL.CLASS_LOGIN();
        public FORM_LOGIN()
        {
            
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txtID.Text, txtPWD.Text);
            if (Dt.Rows.Count > 0)
            {
                FORM_MAIN.GetFORM_MAIN.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                FORM_MAIN.GetFORM_MAIN.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                FORM_MAIN.GetFORM_MAIN.المسافرونToolStripMenuItem.Enabled = true;
                FORM_MAIN.GetFORM_MAIN.المستخدمونToolStripMenuItem.Enabled = true;
                FORM_MAIN.GetFORM_MAIN.المطاراتToolStripMenuItem.Enabled = true;
                FORM_MAIN.GetFORM_MAIN.الموظفونToolStripMenuItem.Enabled = true;
                FORM_MAIN.GetFORM_MAIN.الحجوزاتوالتذاكرToolStripMenuItem.Enabled = true;
                FORM_MAIN.GetFORM_MAIN.الرحلاتToolStripMenuItem.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login faild");
            }

        }
    }
}
