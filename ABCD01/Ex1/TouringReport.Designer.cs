﻿
namespace Ex1
{
    partial class TouringReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Backbt = new System.Windows.Forms.Button();
            this.Displaybt = new System.Windows.Forms.Button();
            this.McNamecb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(948, 492);
            this.dataGridView1.TabIndex = 19;
            // 
            // Backbt
            // 
            this.Backbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Backbt.Location = new System.Drawing.Point(863, 24);
            this.Backbt.Name = "Backbt";
            this.Backbt.Size = new System.Drawing.Size(92, 58);
            this.Backbt.TabIndex = 22;
            this.Backbt.Text = "戻る";
            this.Backbt.UseVisualStyleBackColor = true;
            this.Backbt.Click += new System.EventHandler(this.Backbt_Click);
            // 
            // Displaybt
            // 
            this.Displaybt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Displaybt.Location = new System.Drawing.Point(748, 24);
            this.Displaybt.Name = "Displaybt";
            this.Displaybt.Size = new System.Drawing.Size(94, 58);
            this.Displaybt.TabIndex = 23;
            this.Displaybt.Text = "表示";
            this.Displaybt.UseVisualStyleBackColor = true;
            // 
            // McNamecb
            // 
            this.McNamecb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.McNamecb.FormattingEnabled = true;
            this.McNamecb.Items.AddRange(new object[] {
            "ZRX1200r",
            "XL1200r",
            "ZZR250",
            "XV250ビラーゴ",
            "エリミネーター125"});
            this.McNamecb.Location = new System.Drawing.Point(112, 38);
            this.McNamecb.Name = "McNamecb";
            this.McNamecb.Size = new System.Drawing.Size(212, 32);
            this.McNamecb.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(24, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "車両名";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox1.Location = new System.Drawing.Point(339, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 31);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "全車表示";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TouringReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 610);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Backbt);
            this.Controls.Add(this.Displaybt);
            this.Controls.Add(this.McNamecb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TouringReport";
            this.Text = "TouringReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Backbt;
        private System.Windows.Forms.Button Displaybt;
        private System.Windows.Forms.ComboBox McNamecb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}