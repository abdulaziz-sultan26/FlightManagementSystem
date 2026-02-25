using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PR_MA_SY.BL
{
    internal class CLASS_ADD_TICKET
    {
        public DataTable GET_ALL_PASSENGER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PASSENGER", null);
            DAL.Close();
            return Dt;

        }

        public DataTable GET_LEAVING_TIME()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_LEAVING_TIME", null);
            DAL.Close();
            return Dt;

        }

        public void ADD_TICKET(int TICK_ID, int PASS_ID, int FLI_ID, string SEAT_NUM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@TICKET_ID", SqlDbType.Int);
            param[0].Value = TICK_ID;

            param[1] = new SqlParameter("@PASSENGER_ID", SqlDbType.Int);
            param[1].Value = PASS_ID;

            param[2] = new SqlParameter("@FLIGHT_ID", SqlDbType.Int);
            param[2].Value = FLI_ID;

            param[3] = new SqlParameter("@SEAT_NUMBER", SqlDbType.VarChar, 20);
            param[3].Value = SEAT_NUM;

            DAL.ExecuteCommand("ADD_TICKET", param);
            DAL.Close();
        }

        public DataTable GET_ALL_TICKET()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_TICKET", null);
            DAL.Close();
            return Dt;

        }

        public DataTable SEARCHING_TICKET(string TICK_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TICK_ID", SqlDbType.VarChar);
            param[0].Value = TICK_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCHING_TICKET", param);
            DAL.Close();
            return Dt;
        }

        public void DELETE_TICKET(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DELETE_TICKET", param);
            DAL.Close();
        }

        public void EDIT_TICKET(int TICKET_ID, int PASSENGER_ID, int FLIGHT_ID, string SEAT_NUMBER)
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


        public DataTable VALIDATE_TICK_ID(int TICKET_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@TICKET_ID", SqlDbType.Int);
            param[0].Value = TICKET_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VALIDATE_TICK_ID", param);
            DAL.Close();
            return Dt;
        }

    }
}
