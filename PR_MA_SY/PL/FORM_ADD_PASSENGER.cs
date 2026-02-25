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
    public partial class FORM_ADD_PASSENGER : Form
    {
        public string state = "add";
        BL.CLASS_ADD_PASSENGER CLS_ADD_PASS = new BL.CLASS_ADD_PASSENGER();
        //FORM_PASSENGER_MANAG FORM = new FORM_PASSENGER_MANAG();
        public FORM_ADD_PASSENGER()
        {
            InitializeComponent();
        }

        private void CANCEL_BTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ADD_PASS_BTN_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                CLS_ADD_PASS.ADD_PASSENGER(Convert.ToInt32(TXT_PASS_ID.Text), TXT_NAME.Text, TXT_ADDR.Text,
                                           COMB_CNTRY.SelectedItem.ToString(), TXT_PHON.Text, COMB_GEN.SelectedItem.ToString(), TXT_PASSP.Text);
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_PASS_ID.Text = "";
            }
            else
            {
                
                
                if (MessageBox.Show("هل تريد التعديل البيانات ؟ ", "التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    CLS_ADD_PASS.EDIT_PASSENGER(Convert.ToInt32(TXT_PASS_ID.Text), TXT_NAME.Text, TXT_ADDR.Text,
                                          COMB_CNTRY.SelectedItem.ToString(), TXT_PHON.Text, COMB_GEN.SelectedItem.ToString(), TXT_PASSP.Text);
                    MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                    //FORM.DATA_GRID_VIEW_PASSENGERS.DataSource = CLS_ADD_PASS.GET_ALL_PASSENGERS();
                }
                else
                {
                    MessageBox.Show("تم الغاء التعديل  ", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            FORM_PASSENGER_MANAG.GetFORM_MAIN.DATA_GRID_VIEW_PASSENGER.DataSource = CLS_ADD_PASS.GET_ALL_PASSENGERS();
        }

        private void TXT_ADDR_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_PASS_ID_Validated(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
           
            dataTable = CLS_ADD_PASS.VALIDATE_PASS_ID(Convert.ToInt32(TXT_PASS_ID.Text));
            if (state == "add")
            {
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("الرقم " + TXT_PASS_ID.Text + " رقم المسافر موجود مسبقا, يرجى تغييره", " تحذير!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_PASS_ID.Focus();
                    TXT_PASS_ID.SelectionStart = 0;
                    TXT_PASS_ID.SelectionLength = TXT_PASS_ID.TextLength;
                }
            }
        }

        private void TXT_PASSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TXT_PHON_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TXT_NAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TXT_PASS_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void COMB_GEN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void COMB_CNTRY_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TXT_PASSP_Validated(object sender, EventArgs e)
        {

        }
    }
}
