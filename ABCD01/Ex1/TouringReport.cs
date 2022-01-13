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
        public TouringReport()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static implicit operator TouringReport(MaintenanceDetails v)
        {
            throw new NotImplementedException();
        }
    }
}
