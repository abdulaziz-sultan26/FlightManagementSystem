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
    public partial class FORM_PASSENGER_MANAG : Form
    {
        private static FORM_PASSENGER_MANAG frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_PASSENGER_MANAG GetFORM_MAIN
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_PASSENGER_MANAG();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }

        }

        BL.CLASS_ADD_PASSENGER CLS_ADD_PASS = new BL.CLASS_ADD_PASSENGER();
        public FORM_PASSENGER_MANAG()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.DATA_GRID_VIEW_PASSENGER.DataSource=CLS_ADD_PASS.GET_ALL_PASSENGERS();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_BOX_FOR_SEARCHING_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CLS_ADD_PASS.SEARCHING_PASSENGER(TXT_BOX_FOR_SEARCHING.Text);
            this.DATA_GRID_VIEW_PASSENGER.DataSource=dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_ADD_PASS_Click(object sender, EventArgs e)
        {
            FORM_ADD_PASSENGER FRM = new FORM_ADD_PASSENGER();
            FRM.ShowDialog();

        }

        private void BTN_EXIT_PASS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_DELETE_PASS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العنصر المحدد ؟ ","الحذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                CLS_ADD_PASS.DELETE_PASSENGER(Convert.ToInt32(this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تم الحذف بنجاح ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DATA_GRID_VIEW_PASSENGER.DataSource = CLS_ADD_PASS.GET_ALL_PASSENGERS();
            }
            else
            {
                MessageBox.Show("تم الغاء الحذف  ", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_EDIT_PASS_Click(object sender, EventArgs e)
        {
            FORM_ADD_PASSENGER FORM=new FORM_ADD_PASSENGER();
            FORM.TXT_PASS_ID.Text =this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[0].Value.ToString();
            FORM.TXT_NAME.Text = this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[1].Value.ToString();
            FORM.TXT_ADDR.Text = this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[2].Value.ToString();
            FORM.COMB_CNTRY.SelectedItem = this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[3].Value.ToString();
            FORM.TXT_PHON.Text = this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[4].Value.ToString();
            FORM.COMB_GEN.SelectedItem = this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[5].Value.ToString();
            FORM.TXT_PASSP.Text = this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[6].Value.ToString();
            FORM.Text = " تعديل بيانات المسافر " + this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[1].Value.ToString();
            FORM.ADD_PASS_BTN.Text = "تعديل";
            FORM.state = "edit";
            FORM.TXT_PASS_ID.ReadOnly = true;
            FORM.ShowDialog();
        }

        private void BTN_PRINT_PASS_Click(object sender, EventArgs e)
        {
            REPORTI_NG.SINGLE_PASSENGER_REPORT REPORT = new REPORTI_NG.SINGLE_PASSENGER_REPORT();
            REPORT.SetParameterValue("@PASS_ID", Convert.ToInt32(this.DATA_GRID_VIEW_PASSENGER.CurrentRow.Cells[0].Value.ToString()));

            REPORTI_NG.FORM_REPORT FORM = new REPORTI_NG.FORM_REPORT();
            FORM.CRYSTALREPORT.ReportSource = REPORT;
            FORM.ShowDialog();
        }
    }
}
