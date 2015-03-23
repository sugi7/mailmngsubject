using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication_mail.Models.MailAccountMng
{

    public class MailAdd
    {
        public string A;

        public string Name
        {
            get
            {
                return A;
            }
        }

        public void a()
        {
            SqlIf db = new SqlIf();

            /* データベースオープン */
            db.Open();

            DataTable datatable1 = db.ReadTable1();
            A = datatable1.Rows[0][0].ToString();

            db.Close();
        }
    }
}