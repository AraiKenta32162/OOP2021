using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
         /*   // ラジオボタン１がチェックされているか？
            if (radioButton1.Checked)
                //Text.Show(radioButton1.Text);

            // ラジオボタン２がチェックされているか？
            if (radioButton2.Checked)
                //MessageBox.Show(radioButton2.Text);*/
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Selection_screen s1 = new Selection_screen();
            s1.Visible = true;
            this.Close();
        }


       
    }
}
