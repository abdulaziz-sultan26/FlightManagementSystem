using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PR_MA_SY.BL
{
    internal class CLASS_ADD_EMPLOYEE
    {
        
        public void ADD_EMPLOYEE(int EMPL_ID, string EMPL_NAME, string EMPL_JOB,string EMPL_PHONE,
                                    string EMPL_GEN,int EMPL_SAL,string EMPL_NAT,string EMPL_MAIL)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@EMPL_ID", SqlDbType.Int);
            param[0].Value = EMPL_ID;

            param[1] = new SqlParameter("@EMPL_NAME", SqlDbType.VarChar, 50);
            param[1].Value = EMPL_NAME;

            param[2] = new SqlParameter("@EMPL_JOB", SqlDbType.VarChar, 20);
            param[2].Value = EMPL_JOB;

            param[3] = new SqlParameter("@EMPL_PHONE", SqlDbType.VarChar, 20);
            param[3].Value = EMPL_PHONE;

            param[4] = new SqlParameter("@EMPL_GEN", SqlDbType.VarChar, 10);
            param[4].Value = EMPL_GEN;

            param[5] = new SqlParameter("@EMPL_SAL", SqlDbType.Int);
            param[5].Value = EMPL_SAL;

            param[6] = new SqlParameter("@EMPL_NAT", SqlDbType.VarChar, 50);
            param[6].Value = EMPL_NAT;

            param[7] = new SqlParameter("@EMPL_MAIL", SqlDbType.VarChar, 50);
            param[7].Value = EMPL_MAIL;


            dal.ExecuteCommand("ADD_EMPLOYEE", param);
            dal.Close();

        }

        public DataTable VALIDATE_EMP_ID(int EMPLOYEE_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@EMPLOYEE_ID", SqlDbType.Int);
            param[0].Value = EMPLOYEE_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VALIDATE_EMP_ID", param);
            DAL.Close();
            return Dt;
        }

    }
}
