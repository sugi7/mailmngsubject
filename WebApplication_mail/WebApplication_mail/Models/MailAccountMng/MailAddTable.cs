//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication_mail.Models.MailAccountMng
{
    using System;
    using System.Collections.Generic;
    
    public partial class MailAddTable
    {
        public int Id { get; set; }
        public string 使用者氏名 { get; set; }
        public string ふりがな { get; set; }
        public string アドレス { get; set; }
        public string パスワード { get; set; }
        public string 登録日 { get; set; }
        public string 削除日 { get; set; }
    }
}
