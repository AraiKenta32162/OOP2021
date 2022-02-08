using Ex1.infosys202119DataSetTableAdapters;
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

            if (dgvMaintenance.CurrentRow == null) return;
            dgvMaintenance.Columns[0].Visible = false;
            dgvMaintenance.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvMaintenance.CurrentRow.Cells[2].Value = tbAuthor.Text;
            dgvMaintenance.CurrentRow.Cells[3].Value = Namecb.Text;
            dgvMaintenance.CurrentRow.Cells[4].Value = Distancetb.Text;
            dgvMaintenance.CurrentRow.Cells[5].Value = Exhausttb.Text;
            dgvMaintenance.CurrentRow.Cells[6].Value = inspectiontb.Text;
            dgvMaintenance.CurrentRow.Cells[7].Value = selectedGroup();
            dgvMaintenance.CurrentRow.Cells[8].Value = cbOverview.Text;
            dgvMaintenance.CurrentRow.Cells[9].Value = tbDetail.Text;

            MaintenanceTableAdapter regionTableAdapter =
                new MaintenanceTableAdapter();

            this.Validate();
            //TouringReport.tableAdapterManagertouringTableAdapter.Dispose();
            this.MaintenanceBS.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.infosys202119Maintenance);

            MessageBox.Show("保存しました。");
        }

        public void setTbAuthor(string author)
        {
            if (!tbAuthor.Text.Contains(author))
                tbAuthor.Text.Contains(author);
        }
        public void setNameCb(string text)
        {
            if (!Namecb.Items.Contains(text))
            {
                Namecb.Items.Add(text);
            }
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

        //private void Namecb_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

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
            newDrv[2] = tbAuthor.Text;
            newDrv[3] = Namecb.Text;
            newDrv[4] = Distancetb.Text;
            newDrv[5] = Exhausttb.Text;
            newDrv[6] = inspectiontb.Text;
            newDrv[7] = selectedGroup();
            newDrv[8] = cbOverview.Text;
            newDrv[9] = tbDetail.Text; 
            //データセットに新しいレコードを追加
            infosys202119Maintenance.Maintenance.Rows.Add(newDrv);
            //データベース更新
            maintenanceTableAdapter1.Update(infosys202119Maintenance.Maintenance);

            dtpDate.Value = DateTime.Now;
            tbAuthor.Text = "";
            Namecb.Text = "";
            Distancetb.Text = "";
            Exhausttb.Text = "";
            inspectiontb.Text = "";
            selectedGroup() ;
            cbOverview.Text = "";
            tbDetail.Text = "";
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            dgvMaintenance.Columns[0].Visible = false;
            dgvMaintenance.Columns[1].HeaderText = "日付";
            dgvMaintenance.Columns[2].HeaderText = "記録者";
            dgvMaintenance.Columns[3].HeaderText = "車両名";
            dgvMaintenance.Columns[4].HeaderText = "走行距離";
            dgvMaintenance.Columns[5].HeaderText = "排気量";
            dgvMaintenance.Columns[6].HeaderText = "車検日";
            dgvMaintenance.Columns[7].HeaderText = "メーカー名";
            dgvMaintenance.Columns[8].HeaderText = "整備概要";
            dgvMaintenance.Columns[9].HeaderText = "整備詳細";

            ssErrerLavel.Text = "";
            this.maintenanceTableAdapter1.Fill(this.infosys202119Maintenance.Maintenance);
        }

        private void dgvMaintenance_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaintenance.CurrentRow == null) return;
            try
            {
                dtpDate.Value = (DateTime)dgvMaintenance.CurrentRow.Cells[1].Value;//日付
                tbAuthor.Text = dgvMaintenance.CurrentRow.Cells[2].Value.ToString();
                //setMakerRadioButton((CarReport.MakerGroup)
                //    Enum.Parse(typeof(CarReport.MakerGroup),carReportDataGridView.CurrentRow.Cells[3].Value.ToString())
                //    );   // メーカー（文字列→　列挙型）

                //var mk = (Maintenance.MakerGroup)
                //    Enum.Parse(typeof(CarReport.MakerGroup), dgvMaintenance.CurrentRow.Cells[3].Value.ToString());
                //setMakerRadioButton(mk);

                Namecb.Text = dgvMaintenance.CurrentRow.Cells[3].Value.ToString();
                Distancetb.Text = dgvMaintenance.CurrentRow.Cells[4].Value.ToString();
                Destinationtb.Text = dgvMaintenance.CurrentRow.Cells[5].Value.ToString();
                Peopletb.Text = dgvMaintenance.CurrentRow.Cells[6].Value.ToString();
                Costtb.Text = dgvMaintenance.CurrentRow.Cells[7].Value.ToString();
                Costtb.Text = dgvMaintenance.CurrentRow.Cells[7].Value.ToString();
                ssErrerLavel.Text = "";
            }
            catch (InvalidCastException)
            {
                //pbPicture.Image = null;
            }
            catch (Exception ex)
            {
                ssErrerLavel.Text = ex.Message;
            }
        }
    }
}
