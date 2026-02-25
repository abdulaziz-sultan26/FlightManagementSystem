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
    public partial class FORM_ADD_FLIGHT : Form
    {
        public string state = "add";
        BL.CLASS_ADD_FLIGHT CLASS_ADD_FLI = new BL.CLASS_ADD_FLIGHT();
        public FORM_ADD_FLIGHT()
        {
            InitializeComponent();

            COMP_FLIGHT_CAPTIN.DataSource = CLASS_ADD_FLI.GET_ALL_CAPTINS();
            COMP_FLIGHT_CAPTIN.DisplayMember = "EMPLOYEE_NAME";
            COMP_FLIGHT_CAPTIN.ValueMember = "EMPLOYEE_ID";

            COMP_AIRPORT_LEAVING.DataSource = CLASS_ADD_FLI.GET_ALL_AIRPORTS();
            COMP_AIRPORT_LEAVING.DisplayMember = "AIRPORT_NAME";
            COMP_AIRPORT_LEAVING.ValueMember = "AIRPORT_ID";

            COMP_AIRPORT_ARRIVAL.DataSource = CLASS_ADD_FLI.GET_ALL_AIRPORTS();
            COMP_AIRPORT_ARRIVAL.DisplayMember = "AIRPORT_NAME";
            COMP_AIRPORT_ARRIVAL.ValueMember = "AIRPORT_ID";

            COMB_FLIGHT_PLANE_NAME.DataSource = CLASS_ADD_FLI.GET_ALL_AIRPLANES();
            COMB_FLIGHT_PLANE_NAME.DisplayMember = "AIRPLANE_NAME";
            COMB_FLIGHT_PLANE_NAME.ValueMember = "AIRPLANE_ID";
        }

        private void btn_add_FLIGHT_Click(object sender, EventArgs e)
        {
            if (state=="add")
            {
                if (this.COMP_AIRPORT_ARRIVAL.Enabled == false)
                {
                    CLASS_ADD_FLI.ADD_FLIGHT(Convert.ToInt32(TXT_FLIGHT_ID.Text), COMP_LEAVING_TIME.Text, COMP_LEAVING_TIME.Text,
                                             Convert.ToInt32(COMB_FLIGHT_PLANE_NAME.SelectedValue),
                                             Convert.ToInt32(COMP_AIRPORT_LEAVING.SelectedValue), 
                                             Convert.ToInt32(COMP_FLIGHT_CAPTIN.SelectedValue));
                }
                else
                {
                    CLASS_ADD_FLI.ADD_FLIGHT(Convert.ToInt32(TXT_FLIGHT_ID.Text), COMP_LEAVING_TIME.Text, COMP_LEAVING_TIME.Text,
                                            Convert.ToInt32(COMB_FLIGHT_PLANE_NAME.SelectedValue),
                                            Convert.ToInt32(COMP_AIRPORT_ARRIVAL.SelectedValue),
                                            Convert.ToInt32(COMP_FLIGHT_CAPTIN.SelectedValue));
                }
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_FLIGHT_ID.Text = "";
            }
            else
            {
            }
            
        }

        private void DateTP_LEAVING_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_FLIGHT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXT_FLIGHT_ID_Validated(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = CLASS_ADD_FLI.VALIDATE_FLI_ID(Convert.ToInt32(TXT_FLIGHT_ID.Text));
            if (state == "add")
            {
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("الرقم " + TXT_FLIGHT_ID.Text + " رقم الرحلة موجود مسبقا, يرجى تغييره", " تحذير!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_FLIGHT_ID.Focus();
                    TXT_FLIGHT_ID.SelectionStart = 0;
                    TXT_FLIGHT_ID.SelectionLength = TXT_FLIGHT_ID.TextLength;
                }
            }
        }
    }
}
