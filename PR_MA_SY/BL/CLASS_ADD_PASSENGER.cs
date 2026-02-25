using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PR_MA_SY.BL
{
    internal class CLASS_ADD_PASSENGER
    {

        public void ADD_PASSENGER(int PASS_ID, string PASS_NAME,string PASS_ADD, string PASS_CNTRY,
                                  string PASS_PHON, string PASS_GEN, string PASSPORT_NUM)
        {
            DAL.DataAccessLayer dal=new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@PASS_ID",SqlDbType.Int);
            param[0].Value = PASS_ID;

            param[1] = new SqlParameter("@PASS_NAME", SqlDbType.VarChar,50);
            param[1].Value = PASS_NAME;

            param[2] = new SqlParameter("@PASS_ADD", SqlDbType.VarChar,50);
            param[2].Value = PASS_ADD;

            param[3] = new SqlParameter("@PASS_CNTRY", SqlDbType.VarChar,20);
            param[3].Value= PASS_CNTRY;

            param[4] = new SqlParameter("@PASS_PHON", SqlDbType.VarChar,50);
            param[4].Value = PASS_PHON;

            param[5] = new SqlParameter("@PASS_GEN", SqlDbType.VarChar,10);
            param[5].Value = PASS_GEN;            

            param[6] = new SqlParameter("@PASSPORT_NUM", SqlDbType.VarChar,20);
            param[6].Value = PASSPORT_NUM;

            dal.ExecuteCommand("ADD_PASSENGER",param);
            dal.Close();

        }

        public DataTable VALIDATE_PASS_ID(int PASSENGER_ID)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@PASSENGER_ID", SqlDbType.Int);
            param[0].Value = PASSENGER_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("VALIDATE_PASS_ID", param);
            DAL.Close();
            return Dt;
        }


        public DataTable GET_ALL_PASSENGERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();          

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_PASSENGERS", null);
            DAL.Close();
            return Dt;
        }

        public DataTable SEARCHING_PASSENGER(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar);
            param[0].Value = ID;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SEARCHING_PASSENGER", param);
            DAL.Close();
            return Dt;
        }

        public void DELETE_PASSENGER(int ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            dal.ExecuteCommand("DELETE_PASSENGER", param);
            dal.Close();

        }

        public void EDIT_PASSENGER(int PASS_ID, string PASS_NAME, string PASS_ADD, string PASS_CNTRY,
                                 string PASS_PHON, string PASS_GEN, string PASSPORT_NUM)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@PASS_ID", SqlDbType.Int);
            param[0].Value = PASS_ID;

            param[1] = new SqlParameter("@PASS_NAME", SqlDbType.VarChar, 50);
            param[1].Value = PASS_NAME;

            param[2] = new SqlParameter("@PASS_ADD", SqlDbType.VarChar, 50);
            param[2].Value = PASS_ADD;

            param[3] = new SqlParameter("@PASS_CNTRY", SqlDbType.VarChar, 20);
            param[3].Value = PASS_CNTRY;

            param[4] = new SqlParameter("@PASS_PHON", SqlDbType.VarChar, 50);
            param[4].Value = PASS_PHON;

            param[5] = new SqlParameter("@PASS_GEN", SqlDbType.VarChar, 10);
            param[5].Value = PASS_GEN;

            param[6] = new SqlParameter("@PASSPORT_NUM", SqlDbType.VarChar, 20);
            param[6].Value = PASSPORT_NUM;

            dal.ExecuteCommand("EDIT_PASSENGER", param);
            dal.Close();

        }

    }
}
