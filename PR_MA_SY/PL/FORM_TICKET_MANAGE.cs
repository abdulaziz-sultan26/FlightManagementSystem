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
    public partial class FORM_TICKET_MANAGE : Form
    {

        private static FORM_TICKET_MANAGE frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_TICKET_MANAGE GetFORM_MAIN
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_TICKET_MANAGE();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }

        }

        BL.CLASS_ADD_TICKET CLS_ADD_TICK = new BL.CLASS_ADD_TICKET();

        public FORM_TICKET_MANAGE()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.DATA_GRID_VIEW_TICKET.DataSource = CLS_ADD_TICK.GET_ALL_TICKET();
        }

        private void TXT_BOX_FOR_SEARCHING_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CLS_ADD_TICK.SEARCHING_TICKET(TXT_BOX_SEARCH.Text);
            this.DATA_GRID_VIEW_TICKET.DataSource = dt;
        }

        private void BTN_EXIT_TICK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_ADD_TICK_Click(object sender, EventArgs e)
        {
            FORM_ADD_TICKET FORM = new FORM_ADD_TICKET();
            FORM.ShowDialog();
        }

        private void BTN_DELETE_TICK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من عملية الحذف؟؟","الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                CLS_ADD_TICK.DELETE_TICKET(Convert.ToInt32(this.DATA_GRID_VIEW_TICKET.CurrentRow.Cells[0].Value));
                MessageBox.Show("تمت عملية الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DATA_GRID_VIEW_TICKET.DataSource = CLS_ADD_TICK.GET_ALL_TICKET();

            }
            else
            {
                MessageBox.Show("تمت الغاءالحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BTN_EDIT_TICK_Click(object sender, EventArgs e)
        {
            FORM_ADD_TICKET FORM = new FORM_ADD_TICKET();
            FORM.TXT_TICKET_ID.Text = this.DATA_GRID_VIEW_TICKET.CurrentRow.Cells[0].Value.ToString();
            FORM.COMB_GET_PASS_NAME.Text = this.DATA_GRID_VIEW_TICKET.CurrentRow.Cells[1].Value.ToString();
            FORM.COMB_GET_FLIGHT_TIME.Text = this.DATA_GRID_VIEW_TICKET.CurrentRow.Cells[2].Value.ToString();
            FORM.COMB_SEATNUBER.Text = this.DATA_GRID_VIEW_TICKET.CurrentRow.Cells[3].Value.ToString();

            FORM.Text = "تحديث تذكرة"+ this.DATA_GRID_VIEW_TICKET.CurrentRow.Cells[1].Value.ToString();
            FORM.ADD_TICKET_BTN.Text = "تحديث";
            FORM.state = "تحديث";
            FORM.TXT_TICKET_ID.ReadOnly = true;
            FORM.ShowDialog();
        }

        private void BTN_PRINT_TICK_Click(object sender, EventArgs e)
        {
            // SINGLE_TICKET_REPORT الاعلان عن نسخة من الريبورت
            
            REPORTI_NG.SINGLE_TICKET_REPORT SINGLE_REPORT = new REPORTI_NG.SINGLE_TICKET_REPORT();
            SINGLE_REPORT.SetParameterValue("@TICK_ID", Convert.ToInt32(this.DATA_GRID_VIEW_TICKET.CurrentRow.Cells[0].Value.ToString()));

            //  FORM_TICKET_REPORT الاعلان عن نسخة من الفورم
            
            REPORTI_NG.FORM_REPORT FORMREPORT = new REPORTI_NG.FORM_REPORT();
            FORMREPORT.CRYSTALREPORT.ReportSource = SINGLE_REPORT;
            FORMREPORT.ShowDialog();
        }

        private void BTN_PRINTALL_TICK_Click(object sender, EventArgs e)
        {
            REPORTI_NG.ALL_TICKET_REPORT ALL_REPORT = new REPORTI_NG.ALL_TICKET_REPORT();

            REPORTI_NG.FORM_REPORT FORMREPORT = new REPORTI_NG.FORM_REPORT();

            FORMREPORT.CRYSTALREPORT.ReportSource = ALL_REPORT;
            FORMREPORT.ShowDialog();
        }
    }
}
