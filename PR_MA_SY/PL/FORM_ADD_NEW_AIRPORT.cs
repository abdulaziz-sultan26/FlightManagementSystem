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
    public partial class FORM_ADD_NEW_AIRPORT : Form
    {
        public string state = "add";

        BL.CLASS_ADD_AIR CLASS_ADD_AIR = new BL.CLASS_ADD_AIR();
        public FORM_ADD_NEW_AIRPORT()
        {
            InitializeComponent();
        }

        private void btn_add_airport_Click(object sender, EventArgs e)
        {
            CLASS_ADD_AIR.ADD_AIRPORT(Convert.ToInt32(txt_air_id.Text), txt_air_name.Text, txt_air_location.Text);

            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_air_id.Text = "";
        }

        private void btn_cancel_airport_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_air_id_Validated(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = CLASS_ADD_AIR.VALIDATE_AIRPORT_ID(Convert.ToInt32(txt_air_id.Text));
            if (state == "add")
            {
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("الرقم " + txt_air_id.Text + " رقم المطار موجود مسبقا, يرجى تغييره", " تحذير!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_air_id.Focus();
                    txt_air_id.SelectionStart = 0;
                    txt_air_id.SelectionLength = txt_air_id.TextLength;
                }
            }
        }
    }
}
