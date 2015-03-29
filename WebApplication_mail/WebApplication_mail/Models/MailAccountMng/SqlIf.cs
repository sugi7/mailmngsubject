using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication_mail.Models.MailAccountMng
{
    public class SqlIf
    {
        private static string basedir = AppDomain.CurrentDomain.BaseDirectory;
        private static string connect = "Data Source=(LocalDB)\v11.0;AttachDbFilename=/" + basedir + "Database1.mdf/;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        
        public void dbAddAdrs(MailAddTable2 AddData)
        {
            var db = new DataClasses1DataContext(connect);

            MailAddTable2 Add = new MailAddTable2();

            db.MailAddTable2.InsertOnSubmit(Add);
            db.SubmitChanges();
        }

        public void Read()
        {
            
            var db = new DataClasses1DataContext(connect);

//            var q = from s in db.MailAddTable w
        }

    }

}