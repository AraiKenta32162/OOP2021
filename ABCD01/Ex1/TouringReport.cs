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
    public partial class TouringReport : Form
    {
        BindingList<ToolingData> listTooling = new BindingList<ToolingData>();
        private static Tooling _toolingInstance;

        public static Tooling Form1Instance
        {
            get{return _toolingInstance; } set{ _toolingInstance = value;}
        }

        public string dtpDate
        {
            get{return dtpDate;} set{ dtpDate = value;}
        }

        public TouringReport()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Backbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public static implicit operator TouringReport(MaintenanceDetails v)
        //{
        //    throw new NotImplementedException();
        //}

        private void TouringReport_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202119DataSet1.Touring' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            dgvTouringData.Columns[5].Visible = false;

        }

        public void dgvTouringData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            //選択された行のデータを取得
            ToolingData selectedMc = listTooling[e.RowIndex];

            //取得したデータ項目を各コントロールへ設定
            _toolingInstance.dtpDate.Value = selectedMc.Date;
            _toolingInstance.tbAuthor.Text = selectedMc.Auther;
            _toolingInstance.Namecb.Text = selectedMc.McName;
            _toolingInstance.tbReport.Text = selectedMc.Report;
            _toolingInstance.pbPicture.Image = selectedMc.Picture;
        }
    }
}
