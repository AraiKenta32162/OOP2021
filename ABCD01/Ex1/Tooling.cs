using Ex1.infosys202119DataSet1TableAdapters;
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

namespace Ex1
{
    public partial class Tooling : Form
    {
        BindingList<ToolingData> listTooling = new BindingList<ToolingData>();
        private static TouringReport TouringReport;

        public static TouringReport Form1Instance
        {
            get { return TouringReport; }
            set { TouringReport = value; }
        }

        public Tooling()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Tooling_Load(object sender, EventArgs e)
        {
            dgvTooling.Columns[0].Visible = false;
            dgvTooling.Columns[1].HeaderText = "日付";  //"ID";    
            dgvTooling.Columns[2].HeaderText = "記録者";
            dgvTooling.Columns[3].HeaderText = "車両名";
            dgvTooling.Columns[4].HeaderText = "距離";  
            dgvTooling.Columns[5].HeaderText = "目的地";
            dgvTooling.Columns[6].HeaderText = "人数";  
            dgvTooling.Columns[7].HeaderText = "費用";
            dgvTooling.Columns[8].HeaderText = "写真";

         
            ssErrerLavel.Text = "";
            //carReportDataGridView.Columns[6].Visible = false;

            // dgvRegistData.Columns[5].Visible = false;
            this.touringTableAdapter1.Fill(this.infosys202119Touring.Touring);
        }

        private void TouringClosebt_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK){
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        private void TouringReport_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202119DataSet1.Touring' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.touringTableAdapter1.Fill(this.infosys202119Touring.Touring);

            for (int i = 0; i < dgvTooling.RowCount; i++)
            {
                setTbAuthor(dgvTooling.CurrentRow.Cells[0].Value.ToString());                
            }
            TouringReport.touringTableAdapter.Fill(this.infosys202119Touring.Touring);
        }

        public void TouringAddbt_Click(object sender, EventArgs e)
        {
            //同じ言葉が保存されてしまう。
            Namecb.Items.Add(Namecb.Text);
            
            if (dgvTooling.CurrentRow == null) return;
            dgvTooling.CurrentRow.Cells[1].Value = dtpDate.Text;//日付
            dgvTooling.CurrentRow.Cells[2].Value = tbAuthor.Text;
            dgvTooling.CurrentRow.Cells[3].Value = Namecb.Text;
            dgvTooling.CurrentRow.Cells[4].Value = Distancetb.Text;
            dgvTooling.CurrentRow.Cells[5].Value = Destinationtb.Text;
            dgvTooling.CurrentRow.Cells[6].Value = Peopletb.Text;
            dgvTooling.CurrentRow.Cells[7].Value = Costtb.Text;
            dgvTooling.CurrentRow.Cells[8].Value = ImageToByteArray(pbPicture.Image);

            infosys202119DataSet1TableAdapters.TouringTableAdapter regionTableAdapter = 
                new infosys202119DataSet1TableAdapters.TouringTableAdapter();

            regionTableAdapter.Insert(/*5, "NorthWestern"*/);

            this.Validate();
            //TouringReport./*tableAdapterManager*/touringTableAdapter.Dispose();
            this.touringBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.infosys202119Touring);
            
            MessageBox.Show("保存しました。");
        }

        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        public static Image ByteArrayToImage(byte[] b)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        public void setTbAuthor(string author)
        {
            if (!tbAuthor.Text.Contains(author))
                tbAuthor.Text.Contains(author);
        }

        public void setNameCb(string text)
        {
            if (!Namecb.Items.Contains(text)){
                Namecb.Items.Add(text);
            }
        }
        private void dgvTooling_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTooling.CurrentRow == null) return;
            try
            {
                dtpDate.Value = (DateTime)dgvTooling.CurrentRow.Cells[1].Value;//日付
                tbAuthor.Text = dgvTooling.CurrentRow.Cells[2].Value.ToString();
                //setMakerRadioButton((CarReport.MakerGroup)
                //    Enum.Parse(typeof(CarReport.MakerGroup),carReportDataGridView.CurrentRow.Cells[3].Value.ToString())
                //    );   // メーカー（文字列→　列挙型）

                //var mk = (CarReport.MakerGroup)
                //    Enum.Parse(typeof(CarReport.MakerGroup), dgvTooling.CurrentRow.Cells[3].Value.ToString());
                //setMakerRadioButton(mk);
                Namecb.Text = dgvTooling.CurrentRow.Cells[3].Value.ToString();
                Distancetb.Text = dgvTooling.CurrentRow.Cells[4].Value.ToString();
                Destinationtb.Text = dgvTooling.CurrentRow.Cells[5].Value.ToString();
                Peopletb.Text = dgvTooling.CurrentRow.Cells[6].Value.ToString();
                Costtb.Text = dgvTooling.CurrentRow.Cells[7].Value.ToString();
                pbPicture.Image = ByteArrayToImage((byte[])dgvTooling.CurrentRow.Cells[8].Value);
                ssErrerLavel.Text = "";
            }
            catch (InvalidCastException)
            {
                pbPicture.Image = null;
            }
            catch (Exception ex)
            {
                ssErrerLavel.Text = ex.Message;
            }
        }
    }
}
