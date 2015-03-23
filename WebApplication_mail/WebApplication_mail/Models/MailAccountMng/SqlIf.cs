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
        private SqlConnection sqlCon;
        private SqlTransaction sqlTran;

        public void Open()
        {
            // 接続文字列を生成する
            string connectString = "Data Source=(LocalDB)/v11.0;AttachDbFilename=C:/Users/昌大/Documents/Visual Studio 2013/Projects/WebApplication_mail/WebApplication_mail/App_Data/Database1.mdf;Integrated Security=True";
            // SqlConnection の新しいインスタンスを生成する (接続文字列を指定)
            this.sqlCon = new System.Data.SqlClient.SqlConnection(connectString);

            // データベース接続を開く
            this.sqlCon.Open();

            //トランザクションの開始
            this.sqlTran = this.sqlCon.BeginTransaction();
        }

        public void Close()
        {
            //トランザクションをコミット
            if (this.sqlTran.Connection != null)
            {
                this.sqlTran.Commit();
                this.sqlTran.Dispose();
            }

            // データベース接続を閉じる 
            this.sqlCon.Close();
            this.sqlCon.Dispose();
        }


        public DataTable ReadTable1()
        {
            //クエリーの生成
            SqlCommand sqlCom = new SqlCommand();

            //クエリー送信先及びトランザクションの指定
            sqlCom.Connection = this.sqlCon;
            sqlCom.Transaction = this.sqlTran;

            //クエリー文の指定
            sqlCom.CommandText = "SELECT * FROM MailAddTable;";

            //データテーブルを作成するためのアダプタ
            SqlDataAdapter sqlAda = new SqlDataAdapter();
            sqlAda.SelectCommand = sqlCom;

            //dsにテーブルデータを代入
            DataTable ds = new DataTable();
            sqlAda.Fill(ds);

            //DataTableにも主キーを設定する
            ds.PrimaryKey = new DataColumn[] { ds.Columns["EMP_CODE"] };

            return ds;
        }

        public void RollBack() {
            this.sqlTran.Rollback();
            this.sqlTran.Dispose();
        }
    }

}