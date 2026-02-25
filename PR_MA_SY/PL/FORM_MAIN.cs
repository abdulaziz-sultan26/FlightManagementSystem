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
    public partial class FORM_MAIN : Form
    {
        private static FORM_MAIN frm;
        static void frm_FormClosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_MAIN GetFORM_MAIN
        {
            get
            {
                if (frm==null)
                {
                    frm = new FORM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
            
        }
        public FORM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.المسافرونToolStripMenuItem.Enabled = false;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.المطاراتToolStripMenuItem.Enabled = false;
            this.الموظفونToolStripMenuItem.Enabled = false;
            this.الحجوزاتوالتذاكرToolStripMenuItem.Enabled = false;
            this.الرحلاتToolStripMenuItem.Enabled = false;
           
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_LOGIN fORM = new FORM_LOGIN();
            // لا تسمح بالتحكم الضغط على الفورم الخلفي للفورم الحالي الا بعد الخروج من الفورم الحالي ShowDialog
            fORM.ShowDialog();
        }

        private void اضافةمسافرجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_PASSENGER FORM = new FORM_ADD_PASSENGER();
            FORM.ShowDialog();
        }

        private void ادارةالمسافرونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_PASSENGER_MANAG FRM=new FORM_PASSENGER_MANAG();
            FRM.ShowDialog();
        }

        private void وجهةمطارجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_NEW_AIRPORT form = new FORM_ADD_NEW_AIRPORT();
            form.ShowDialog();
        }

        private void اضافةطارةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_AIRPLANES FORM1 = new FORM_ADD_AIRPLANES();
            FORM1.ShowDialog();
        }

        private void ادارةالطائراتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةموظفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_EMPLOYEE form = new FORM_ADD_EMPLOYEE();
            form.ShowDialog();
        }

        private void رحلةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_FLIGHT FORM = new FORM_ADD_FLIGHT();
            FORM.COMP_AIRPORT_LEAVING.Enabled = false;
            FORM.GBOX_FLIGHT.Text = "اضافة رحلة مغادرة";
            FORM.ShowDialog();
        }

        private void دخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_FLIGHT FORM = new FORM_ADD_FLIGHT();
            FORM.COMP_AIRPORT_ARRIVAL.Enabled = false;
            FORM.GBOX_FLIGHT.Text = "اضافة رحلةوصول";
            FORM.ShowDialog();
        }

        private void اضافةتذكرةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_TICKET ADD_TICKET = new FORM_ADD_TICKET();
            ADD_TICKET.ShowDialog();
        }

        private void ادارةالتذاكرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_TICKET_MANAGE TICKET_MANAGE = new FORM_TICKET_MANAGE();
            TICKET_MANAGE.ShowDialog();
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ADD_USER FORM = new FORM_ADD_USER();
            FORM.ShowDialog();
        }

        private void اعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_CONFIG FORM = new FORM_CONFIG();
            FORM.ShowDialog();
        }
    }
}
