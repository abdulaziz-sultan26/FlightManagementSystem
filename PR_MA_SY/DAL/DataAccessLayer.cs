using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace PR_MA_SY.DAL
{
    class DataAccessLayer
    {


        SqlConnection sqlconnection;

        public DataAccessLayer()
        {
            string mode = Properties.Settings.Default.Mode;
            if (mode == "SQL")
            {
                sqlconnection = new SqlConnection(@"Data Source =" + Properties.Settings.Default.Server +
                    "; Initial Catalog" + Properties.Settings.Default.Database +
                    "; Integrated Security= false; User ID= " + Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password +"" );
            }
            else
            {
                sqlconnection = new SqlConnection(@"Data Source =" + Properties.Settings.Default.Server +
                    "; Initial Catalog=" + Properties.Settings.Default.Database + "; Integrated Security= true ");
            }
            

        }

        //Method to open the connection
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //Method to close the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }

        }

        // Method to read data from database

        // DataTable is one table, but DataSet is a group of tables;

        // يمكننا من اجراء التعديل والاضافة والحذف ExecuteCommandال
        // يمكننا من اجراء استعادة البيانات وجلبها من قاعدة البيانات  SelectDataال 

        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        // Method to inert,update, and delete data from database\

        // يمكننا من اجراء التعديل والاضافة والحذف ExecuteCommandال 
        // يمكننا من اجراء استعادة البيانات وجلبها من قاعدة البيانات SelectDataال 
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }

    }
}
