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
    public partial class Tooling : Form
    {
        public Tooling()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Selection_screen s1 = new Selection_screen();
            //s1.Visible = true;
            this.Close();
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Setting.Set || String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("追加しました");
                return;
            }
        }
    }
}
