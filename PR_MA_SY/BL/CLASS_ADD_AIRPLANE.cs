using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PR_MA_SY.BL
{
    internal class CLASS_ADD_AIRPLANE
    {

        public void ADD_AIRPLANE(int ID,string MODEL, string MANUFACTURER, int SEATS, string plane_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@AIR_ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@AIR_MODEL", SqlDbType.VarChar, 50);
            param[1].Value = MODEL;

            param[2] = new SqlParameter("@AIR_MANUF", SqlDbType.VarChar, 50);
            param[2].Value = MANUFACTURER;

            param[3] = new SqlParameter("@AIR_SEATS", SqlDbType.Int);
            param[3].Value = SEATS;

            param[4] = new SqlParameter("@AIR_NAME", SqlDbType.VarChar, 20);
            param[4].Value = plane_name;

            DAL.ExecuteCommand("ADD_AIRPLANE", param);
            DAL.Close();
        }

        public DataTable VALIDATE_AIRPLANE_ID(int AIRPLANE_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@AIRPLANE_ID", SqlDbType.Int);
            param[0].Value = AIRPLANE_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VALIDATE_AIRPLANE_ID", param);
            DAL.Close();
            return Dt;
        }

    }
}
