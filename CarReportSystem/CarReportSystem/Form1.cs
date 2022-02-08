using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class fmMain : Form
    {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain()
        {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //アプリケーション終了
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        //選択されているメーカーの列挙型を返す
        private CarReport.MakerGroup selectedGroup()
        {

            foreach (var rb in gbMaker.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuther(string author)
        {
            if (!cbAuthor.Items.Contains(author))
            {
                cbAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName)
        {
            if (!cbCarName.Items.Contains(carName))
            {
                cbCarName.Items.Add(carName);
            }
        }

        private void setMakerRadioButton(CarReport.MakerGroup mg)
        {
            switch (mg)
            {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                default:    //その他
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btUpDate_Click(object sender, EventArgs e)
        {
            if (dgvRegistData.CurrentRow == null) return;
            /*carReportDataGridView*/
            dgvRegistData.CurrentRow.Cells[1].Value = dtpDate.Value;    //日付
            dgvRegistData.CurrentRow.Cells[2].Value = cbAuthor.Text;    //記録者
            dgvRegistData.CurrentRow.Cells[3].Value = selectedGroup();  //メーカー
            dgvRegistData.CurrentRow.Cells[4].Value = cbCarName.Text;   //車名
            dgvRegistData.CurrentRow.Cells[5].Value = tbReport.Text;    //レポート
            dgvRegistData.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);  //画像

            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202119DataSet);

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202132DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202119DataSet.CarReport);

            for (int i = 0; i < dgvRegistData.RowCount; i++)
            {
                setCbAuther(dgvRegistData.CurrentRow.Cells[1].Value.ToString());
                setCbAuther(dgvRegistData.CurrentRow.Cells[3].Value.ToString());
            }

        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            dgvRegistData.Columns[0].Visible = false;
            dgvRegistData.Columns[1].HeaderText = "日付";
            dgvRegistData.Columns[2].HeaderText = "記録者";
            dgvRegistData.Columns[3].HeaderText = "メーカー";
            dgvRegistData.Columns[4].HeaderText = "車名";
            dgvRegistData.Columns[5].HeaderText = "レポート";
            //carReportDataGridView.Columns[6].HeaderText = "画像";
            dgvRegistData.Columns[6].Visible = false;
            ssErrerLavel.Text = "";
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvRegistData.CurrentRow == null) return;
            try
            {
                ssErrerLavel.Text = "";
                dtpDate.Value = (DateTime)dgvRegistData.CurrentRow.Cells[1].Value;                       //日付
                cbAuthor.Text = dgvRegistData.CurrentRow.Cells[2].Value.ToString();                      //記録者
                /***/
                //setMakerRadioButton((CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup)
                //, carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));                          //メーカー(文字列→列挙型)
                /***/
                cbCarName.Text = dgvRegistData.CurrentRow.Cells[4].Value.ToString();                     //車名
                tbReport.Text = dgvRegistData.CurrentRow.Cells[5].Value.ToString();                      //レポート

                var mk = (CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup),
                dgvRegistData.CurrentRow.Cells[3].Value.ToString());
                setMakerRadioButton(mk);
                pbPicture.Image = ByteArrayToImage((byte[])dgvRegistData.CurrentRow.Cells[6].Value);     //画像

            }
            catch (InvalidCastException)
            {
                pbPicture.Image = null;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                ssErrerLavel.Text = ex.Message;
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b)
        {

            Image img = null;
            if (b.Length > 0)
            {
                ImageConverter imgconv = new ImageConverter();
                img = (Image)imgconv.ConvertFrom(b);
            }
            return img;
        }
        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
            setMakerRadioButton(CarReport.MakerGroup.その他);
            pbPicture.Image = null;
        }
    }
}