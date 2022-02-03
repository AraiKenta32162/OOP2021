using Ex1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Maintenance : Form
    {
        private Setting setting = Setting.getInstance();
        BindingList<Mc> listMS = new BindingList<Mc>();

        public Maintenance()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        

        private void Backbt_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void MaintenanceAddbt_Click(object sender, EventArgs e)
        {
            Namecb.Items.Add(Namecb.Text);
            cbAuthor.Items.Add(cbAuthor.Text);
        }

        private void setCbAuthor(object text)
        {
            
        }
        private void setCbCarName(object text)
        {
            
        }

        

        private Mc.MakerGroup selectedGroup()
        {

            foreach (var rb in gbMaker.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    return (Mc.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return Mc.MakerGroup.その他;
        }

        private void Namecb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Seibi_Load(object sender, EventArgs e)
        {

        }

        private void btnewAdd_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202119DataSet1.Touring' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.maintenanceTableAdapter1.Fill(this.infosys202119Maintenance.Maintenance);
            maintenanceTableAdapter1.Fill(infosys202119Maintenance.Maintenance);

            for (int i = 0; i < dgvMaintenance.RowCount; i++)
            {
                setCbAuthor(dgvMaintenance.CurrentRow.Cells[0].Value.ToString());
            }

            //新規レコードの追加
            DataRow newDrv = infosys202119Maintenance.Maintenance.NewRow();
            newDrv[0] = false;
            newDrv[1] = dtpDate.Value;
            newDrv[2] = cbAuthor.Text;
            newDrv[3] = cbAuthor.Text;
            newDrv[4] = Distancetb.Text;
            newDrv[5] = Destinationtb.Text;
            newDrv[6] = Peopletb.Text;
            newDrv[7] = Costtb.Text;
            newDrv[8] = pbPicture.Image;
            //データセットに新しいレコードを追加
            infosys202119Maintenance.Maintenance.Rows.Add(newDrv);
            //データベース更新
            maintenanceTableAdapter1.Update(infosys202119Maintenance.Maintenance);

            dtpDate.Value = DateTime.Now;
            tbAuthor.Text = "";
            cbAuthor.Text = "";
            Distancetb.Text = "";
            Destinationtb.Text = "";
            Peopletb.Text = "";
            Costtb.Text = "";
            pbPicture.Image = null;
        }
    }
}
