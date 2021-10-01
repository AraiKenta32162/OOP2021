using SendMail.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
        //キャンセル
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
