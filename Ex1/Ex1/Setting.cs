using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Setting
    {
        private static Setting instance = null;

        //送信データが設定済み
        public static bool Set { get; private set; } = true;

        public int Name { get; set; }           //車両名
        public string displacement { get; set; }        //排気量
        public string MailAddr { get; set; }    //メールアドレス
        public string Pass { get; set; }        //パスワード
        public bool Ssl { get; set; }           //SSL

        //コンストラクタ
        private Setting()
        {

        }

        internal static Setting getInstance()
        {
            if (instance == null)
            {
                instance = new Setting();
                try
                {
                }
                //ファイルがない場合（初回起動時）
                catch (Exception)
                {
                    Set = false; //データ未設定
                }
            }
            return instance;
        }
    }
}
