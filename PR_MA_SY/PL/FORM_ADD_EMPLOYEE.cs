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
    public partial class FORM_ADD_EMPLOYEE : Form
    {
        public string state = "add";

        BL.CLASS_ADD_EMPLOYEE Class_add_employee = new BL.CLASS_ADD_EMPLOYEE();
        public FORM_ADD_EMPLOYEE()
        {
            InitializeComponent();
        }

        private void btn_cancel_employee_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            Class_add_employee.ADD_EMPLOYEE(Convert.ToInt32(TXT_EMPL_ID.Text), TXT_EMPL_NAME.Text, TXT_EMPL_JOB.Text, TXT_EMPL_PHON.Text,
                                            COMB_EMPL_GEN.SelectedItem.ToString(), Convert.ToInt32(TXT_EMPL_SAL.Text), COMB_EMPL_CNTRY.SelectedItem.ToString(),TXT_EMPL_EMAIL.Text);

            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TXT_EMPL_ID.Text = "";

        }

        private void TXT_EMPL_ID_Validated(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = Class_add_employee.VALIDATE_EMP_ID(Convert.ToInt32(TXT_EMPL_ID.Text));
            if (state == "add")
            {
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("الرقم " + TXT_EMPL_ID.Text + " رقم المسافر موجود مسبقا, يرجى تغييره", " تحذير!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_EMPL_ID.Focus();
                    TXT_EMPL_ID.SelectionStart = 0;
                    TXT_EMPL_ID.SelectionLength = TXT_EMPL_ID.TextLength;
                }
            }
        }
    }
}
