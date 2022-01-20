using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ex1
{
    public partial class MaintenanceDetails : Form
    {
        //public Selection_screen selection_Screen = new Selection_screen();

        public MaintenanceDetails()
        {
            InitializeComponent();
            this.MaximizeBox = false;
         
        }

        
        private void button3_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (ofdFileOpen.ShowDialog() == DialogResult.OK)
                {
                    //バイナリー形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read))
                    {
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listCarReport;
                    }

                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            foreach (var item in listCarReport)
            {
                setCbAuther(item.Auther);
                setCbCarName(item.CarName);
            }
            //for (int i=0;i < dgvRegistData.RowCount; i++) {
            //    setCbAuther(dgvRegistData.Rows[i].Cells[1].ToString());
            //    setCbCarName(dgvRegistData.Rows[i].Cells[3].ToString());
            //}
        
    }
}
