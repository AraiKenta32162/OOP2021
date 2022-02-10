using System;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ex1
{
    public partial class MaintenanceDetails : Form
    {
        BindingList<Mc> listMaintenance = new BindingList<Mc>();
        private static Maintenance _maintenanceInstance;

        public static Maintenance Form1Instance
        {
            get { return _maintenanceInstance; }
            set { _maintenanceInstance = value; }
        }

        public MaintenanceDetails()
        {
            InitializeComponent();
            this.MaximizeBox = false;
         
        }
        
        private void MaintenanceDetails_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202119DataSet.Maintenance' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            dgvMaintenanceData.Columns[5].Visible = false;
        }

        private void Backbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Displaybt_Click(object sender, EventArgs e)
        {
            this.maintenanceTableAdapter.Fill(this.infosys202119Maintenance.Maintenance);
        }

        public void dgvMaintenanceData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            //選択された行のデータを取得
            Mc selectedMc = listMaintenance[e.RowIndex];

            //取得したデータ項目を各コントロールへ設定
            _maintenanceInstance.dtpDate.Value = selectedMc.Date;
            _maintenanceInstance.tbAuthor.Text = selectedMc.Auther;
            _maintenanceInstance.Namecb.Text = selectedMc.McName;
            _maintenanceInstance.Distancetb.Text = selectedMc.Distance;
            _maintenanceInstance.Exhausttb.Text = selectedMc.Exhaust;
            _maintenanceInstance.inspectiontb.Text = selectedMc.Inspection;
            _maintenanceInstance.gbMaker.Text = selectedMc.ToString();//makerDataGridViewTextBoxColumn
            _maintenanceInstance.cbOverview.Text = selectedMc.Outline;
            _maintenanceInstance.tbDetail.Text = selectedMc.Details;
        }
    }
}