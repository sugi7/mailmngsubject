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

        /* アドレス情報読み出し */
        public System.Linq.IQueryable<AddressTable> AdrRead(string key)
        {
            
            DataClassesDataContext db = new DataClassesDataContext();

            var q = from s in db.AddressTable
                    where !s.削除日.HasValue && (s.使用者氏名.Contains(key) || s.ふりがな.Contains(key) || s.アドレス.Contains(key) || s.パスワード.Contains(key) || s.転送先.Contains(key) )
                    select s;

            return q;
        }

        public System.Linq.IQueryable<AddressTable> AdrRead()
        {

            DataClassesDataContext db = new DataClassesDataContext();

            var q = from s in db.AddressTable
                    where !s.削除日.HasValue
                    select s;

            return q;
        }

        public System.Linq.IQueryable<AddressTable> AdrRead(int id)
        {

            DataClassesDataContext db = new DataClassesDataContext();

            var q = from s in db.AddressTable
                    where !s.削除日.HasValue && s.Id == id
                    select s;

            return q;
        }

        /*  */
        public void dbUpdataAdrs(AddressTable AddData,int id)
        {

            DataClassesDataContext db = new DataClassesDataContext();

            var q = db.AddressTable.Single(x => x.Id == id);

            q.使用者氏名 = AddData.使用者氏名;
            q.アドレス = AddData.アドレス;
            q.ふりがな = AddData.ふりがな;
            q.パスワード = AddData.パスワード;
            q.転送先 = AddData.転送先;

            db.SubmitChanges();

        }

        /* 削除 */
        public void dbUpdataAdrs( int id)
        {

            DataClassesDataContext db = new DataClassesDataContext();

            var q = db.AddressTable.Single(x => x.Id == id);
            DateTime day = DateTime.Today;

            /* 登録日情報を設定 */
            q.削除日 = day.Date;

            db.SubmitChanges();

        }
        public void dbUpdataUser()
        {

            DataClassesDataContext db = new DataClassesDataContext();


            //            var q = from s in db.MailAddTable w
        }
    }

}