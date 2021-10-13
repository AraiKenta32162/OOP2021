using System;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings settings = Settings.getInstance();

        public ConfigForm()
        {
            InitializeComponent();
        }

        //デフォルト
        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.bSsl();//SSL
            tbSender.Text = settings.sMailAddr();//送信元
        }

        //OK
        private void btOk_Click(object sender, EventArgs e)
        {
            btApply_Click(sender, e);//適用ボタンの処理の呼び出し
            this.Close();
        }

        //適用
        private void btApply_Click(object sender, EventArgs e)
        {
            //settinfオブジェクトに入力データを渡して登録を行う
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text),
                                  tbUserName.Text, tbPass.Text, cbSsl.Checked);
        }

        //キャンセル
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //設定画面をロードすると一度だけ実行されるイベントハンドラ
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;
        }
    }
}
//32162@ojs.ac.jp