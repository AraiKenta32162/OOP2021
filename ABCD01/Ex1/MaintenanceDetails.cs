using System;
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
    }
}
