using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PR_MA_SY.BL
{
    internal class CLASS_ADD_AIR
    {
        public void ADD_AIRPORT(int AIR_ID, String AIR_NAME, String AIR_LOC)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@AIR_ID", SqlDbType.Int);
            param[0].Value = AIR_ID;

            param[1] = new SqlParameter("@AIR_NAME", SqlDbType.VarChar, 50);
            param[1].Value = AIR_NAME;

            param[2] = new SqlParameter("@AIR_LOC", SqlDbType.VarChar, 50);
            param[2].Value = AIR_LOC;

            dal.ExecuteCommand("ADD_AIRPORT", param);
            dal.Close();

        }

        public DataTable VALIDATE_AIRPORT_ID(int AIRPORT_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@AIRPORT_ID", SqlDbType.Int);
            param[0].Value = AIRPORT_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VALIDATE_AIRPORT_ID", param);
            DAL.Close();
            return Dt;
        }

    }
}
