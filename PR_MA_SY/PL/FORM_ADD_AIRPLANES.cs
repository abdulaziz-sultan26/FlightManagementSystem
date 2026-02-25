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
    public partial class FORM_ADD_AIRPLANES : Form
    {
        public string state = "add";

        BL.CLASS_ADD_AIRPLANE CLASS_ADD_AIRPLANE = new BL.CLASS_ADD_AIRPLANE();

        public FORM_ADD_AIRPLANES()
        {
            InitializeComponent();
        }

        private void btn_cancel_airplane_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_airplane_Click(object sender, EventArgs e)
        {
            CLASS_ADD_AIRPLANE.ADD_AIRPLANE(Convert.ToInt32(txt_airplane_id.Text), txt_airplane_model.Text,
                                             txt_airplane_manufacturer.Text, Convert.ToInt32(txt_airplane_seats.Text), txt_airplane_name.Text);
            MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_airplane_id.Text = "";
        }

        private void txt_airplane_id_Validated(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = CLASS_ADD_AIRPLANE.VALIDATE_AIRPLANE_ID(Convert.ToInt32(txt_airplane_id.Text));
            if (state == "add")
            {
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("الرقم " + txt_airplane_id.Text + " رقم الطائرة موجود مسبقا, يرجى تغييره", " تحذير!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_airplane_id.Focus();
                    txt_airplane_id.SelectionStart = 0;
                    txt_airplane_id.SelectionLength = txt_airplane_id.TextLength;
                }
            }
        }
    }
}
