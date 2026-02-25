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
    public partial class FORM_ADD_TICKET : Form
    {
        public string state = "add";

        BL.CLASS_ADD_TICKET CLASS_ADD_TICK = new BL.CLASS_ADD_TICKET();
        public FORM_ADD_TICKET()
        {
            InitializeComponent();

            COMB_GET_PASS_NAME.DataSource = CLASS_ADD_TICK.GET_ALL_PASSENGER();
            COMB_GET_PASS_NAME.DisplayMember = "PASSENGER_NAME";
            COMB_GET_PASS_NAME.ValueMember = "PASSENGER_ID";

            COMB_GET_FLIGHT_TIME.DataSource = CLASS_ADD_TICK.GET_LEAVING_TIME();
            COMB_GET_FLIGHT_TIME.DisplayMember = "FLIGHT_TIME";
            COMB_GET_FLIGHT_TIME.ValueMember = "FLIGHT_ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CANCEL_TICKET_BTN_Click(object sender, EventArgs e)
        {
                MessageBox.Show("تمت الغاء الاضافة بنجاح", "عملية اضافة تذكرة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void ADD_TICKET_BTN_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
            
                CLASS_ADD_TICK.ADD_TICKET(Convert.ToInt32(TXT_TICKET_ID.Text), Convert.ToInt32(COMB_GET_PASS_NAME.SelectedValue), 
                                      Convert.ToInt32(COMB_GET_FLIGHT_TIME.SelectedValue), COMB_SEATNUBER.SelectedItem.ToString());

                MessageBox.Show("تمت الاضافة بنجاح", "عملية اضافة تذكرة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TXT_TICKET_ID.Text = "";
            }
            else
            {
                if (MessageBox.Show("هل تريد تعديل البيانات ؟ ", "التعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    CLASS_ADD_TICK.EDIT_TICKET(Convert.ToInt32(TXT_TICKET_ID.Text), Convert.ToInt32(COMB_GET_PASS_NAME.SelectedValue),
                                      Convert.ToInt32(COMB_GET_FLIGHT_TIME.SelectedValue), COMB_SEATNUBER.SelectedItem.ToString());

                    MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //FORM.DATA_GRID_VIEW_PASSENGERS.DataSource = CLS_ADD_PASS.GET_ALL_PASSENGERS();
                }
                else
                {
                    MessageBox.Show("تم الغاء التعديل  ", "التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            FORM_TICKET_MANAGE.GetFORM_MAIN.DATA_GRID_VIEW_TICKET.DataSource = CLASS_ADD_TICK.GET_ALL_TICKET();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TXT_TICKET_ID_Validated(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = CLASS_ADD_TICK.VALIDATE_TICK_ID(Convert.ToInt32(TXT_TICKET_ID.Text));
            if (state == "add")
            {
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("الرقم " + TXT_TICKET_ID.Text + " رقم التذكرة موجود مسبقا, يرجى تغييره", " تحذير!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_TICKET_ID.Focus();
                    TXT_TICKET_ID.SelectionStart = 0;
                    TXT_TICKET_ID.SelectionLength = TXT_TICKET_ID.TextLength;
                }
            }
        }
    }
}
