using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PR_MA_SY.BL
{
    internal class CLASS_ADD_FLIGHT
    {
        public DataTable GET_ALL_AIRPORTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_AIRPORTS", null);
            DAL.Close();
            return Dt;

        }

        public DataTable GET_ALL_CAPTINS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_CAPTINS", null);
            DAL.Close();
            return Dt;

        }

        public DataTable GET_ALL_AIRPLANES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_AIRPLANES", null);
            DAL.Close();
            return Dt;

        }


        public void ADD_FLIGHT(int ID, string LEAV_TIME, string ARRIV_TIME, int PLANE_ID, int AIRPORT_ID, int EMPLOYEE_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
         
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@FLI_ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@LEAVING_TIME", SqlDbType.VarChar, 50);
            param[1].Value = LEAV_TIME;

            param[2] = new SqlParameter("@ARRIVAL_TIME", SqlDbType.VarChar, 50);
            param[2].Value = ARRIV_TIME;

            param[3] = new SqlParameter("@AIRPLANE_ID", SqlDbType.Int);
            param[3].Value = PLANE_ID;

            param[4] = new SqlParameter("@AIRPORT_ID", SqlDbType.Int);
            param[4].Value = AIRPORT_ID;

            param[5] = new SqlParameter("@EMPLOYEE_ID", SqlDbType.Int);
            param[5].Value = EMPLOYEE_ID;

            DAL.ExecuteCommand("ADD_FLIGHT", param);
            DAL.Close();
        }

        public DataTable VALIDATE_FLI_ID(int FLIGHT_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@FLIGHT_ID", SqlDbType.Int);
            param[0].Value = FLIGHT_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VALIDATE_FLI_ID", param);
            DAL.Close();
            return Dt;
        }

        public void EDIT_TICKET(int TICKET_ID, int PASSENGER_ID,int FLIGHT_ID,string SEAT_NUMBER)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@TICKET_ID", SqlDbType.Int);
            param[0].Value = TICKET_ID;

            param[1] = new SqlParameter("@PASSENGER_ID", SqlDbType.Int);
            param[1].Value = PASSENGER_ID;

            param[2] = new SqlParameter("@FLIGHT_ID", SqlDbType.Int);
            param[2].Value = FLIGHT_ID;

            param[3] = new SqlParameter("@SEAT_NUMBER", SqlDbType.VarChar, 20);
            param[3].Value = SEAT_NUMBER;

            dal.ExecuteCommand("EDIT_TICKET", param);
            dal.Close();

        }

    }
}
