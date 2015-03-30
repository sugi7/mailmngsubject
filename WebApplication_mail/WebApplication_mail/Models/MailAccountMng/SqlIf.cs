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

        /* 追加アドレス情報 */
        public void dbAddAdrs(AddressTable AddData)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            DateTime day = DateTime.Today;

            /* 登録日情報を設定 */
            AddData.登録日 = day.Date;

            db.AddressTable.InsertOnSubmit(AddData);
            db.SubmitChanges();
        }

        /* 追加ユーザ情報 */
        public void dbAddUser(UserTable AddData)
        {
            DataClassesDataContext db = new DataClassesDataContext();
            DateTime day = DateTime.Today;

            /* 登録日情報を設定 */
            AddData.登録日 = day.Date;

            db.UserTable.InsertOnSubmit(AddData);
            db.SubmitChanges();
        }

        /*  */
        public void Read()
        {

            DataClassesDataContext db = new DataClassesDataContext();

//            var q = from s in db.MailAddTable w
        }

        /*  */
        public void dbUpdataAdrs()
        {

            DataClassesDataContext db = new DataClassesDataContext();

            //            var q = from s in db.MailAddTable w
        }

        public void dbUpdataUser()
        {

            DataClassesDataContext db = new DataClassesDataContext();


            //            var q = from s in db.MailAddTable w
        }
    }

}