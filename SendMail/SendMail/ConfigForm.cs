using System;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;

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
            //cbSsl.Checked = true;
        }
        //OK
        private void btOk_Click(object sender, EventArgs e)
        {
            SettingResist();
            this.Close();
        }
        //適用
        private void btApply_Click(object sender, EventArgs e)
        {
            SettingResist();
        }
        //送信データ登録
        private void SettingResist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;

            //XMLファイルへ書き出し（シリアル化）
            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "    ",
            };

            using (var writer = XmlWriter.Create("mailsetting.xml", xws))
            {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }
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