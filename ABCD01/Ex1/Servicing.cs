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
    public partial class Seibi : Form
    {
        private Setting setting = Setting.getInstance();
        BindingList<Mc> listMS = new BindingList<Mc>();

        public Seibi()
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
            McNamecb.Items.Add(McNamecb.Text);
            Namecb.Items.Add(Namecb.Text);
        }

        private void setCbAuthor(object text)
        {
            
        }
        private void setCbCarName(object text)
        {
            
        }

        

        private Mc.MakerGroup selectedGroup()
        {

            foreach (var rb in groupBox1.Controls)
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
        
    }
}
