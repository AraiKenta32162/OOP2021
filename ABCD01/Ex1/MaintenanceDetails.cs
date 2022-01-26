using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Ex1
{
    public partial class MaintenanceDetails : Form
    {        

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

            
        }

        private void MaintenanceDetails_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'infosys202119DataSet.Maintenance' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            dgvMaintenanceData.Columns[5].Visible = false;

        }
    }
}
