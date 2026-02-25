using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PR_MA_SY.BL
{
    class CLASS_LOGIN
    {


        public DataTable LOGIN(string ID, string PASSWORD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            // البارامترين @ID و @PWD لازم تكون اسمائهما نفس الاسماء التي في الاجراء المخزن

            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PASSWORD;

            /*DAL.Open();
             * وضعت فقط لفحص الاتصال , اي ان عملها زائد لان اسكيو ال ادابتور هو مكلف بفتح 
             * وغلق الاتصال لكن في حالة اسكيو ال كوماند نحتاج لغلق وفتح الاتصال بانفسنا
             */
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SPLogin", param);
            DAL.Close();
            return Dt;

        }

    }
}
