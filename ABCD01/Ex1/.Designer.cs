
namespace Ex1
{
    partial class Maintenance
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.rbKawasaki = new System.Windows.Forms.RadioButton();
            this.rbSuzuki = new System.Windows.Forms.RadioButton();
            this.rbYamaha = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.cbOverview = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDetail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaintenanceAddbt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Distancetb = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Namecb = new System.Windows.Forms.ComboBox();
            this.Backbt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.btnewAdd = new System.Windows.Forms.Button();
            this.maintenanceTableAdapter1 = new Ex1.infosys202119DataSetTableAdapters.MaintenanceTableAdapter();
            this.infosys202119Maintenance = new Ex1.infosys202119DataSet();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202119Maintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(71, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(212, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "記入日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "車両名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "メーカー名";
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbOthers);
            this.gbMaker.Controls.Add(this.rbKawasaki);
            this.gbMaker.Controls.Add(this.rbSuzuki);
            this.gbMaker.Controls.Add(this.rbYamaha);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbMaker.Location = new System.Drawing.Point(71, 123);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(434, 36);
            this.gbMaker.TabIndex = 3;
            this.gbMaker.TabStop = false;
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Location = new System.Drawing.Point(356, 12);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(63, 19);
            this.rbOthers.TabIndex = 4;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "その他";
            this.rbOthers.UseVisualStyleBackColor = true;
            // 
            // rbKawasaki
            // 
            this.rbKawasaki.AutoSize = true;
            this.rbKawasaki.Location = new System.Drawing.Point(256, 12);
            this.rbKawasaki.Name = "rbKawasaki";
            this.rbKawasaki.Size = new System.Drawing.Size(94, 19);
            this.rbKawasaki.TabIndex = 3;
            this.rbKawasaki.TabStop = true;
            this.rbKawasaki.Text = "KAWASAKI";
            this.rbKawasaki.UseVisualStyleBackColor = true;
            // 
            // rbSuzuki
            // 
            this.rbSuzuki.AutoSize = true;
            this.rbSuzuki.Location = new System.Drawing.Point(175, 12);
            this.rbSuzuki.Name = "rbSuzuki";
            this.rbSuzuki.Size = new System.Drawing.Size(75, 19);
            this.rbSuzuki.TabIndex = 2;
            this.rbSuzuki.TabStop = true;
            this.rbSuzuki.Text = "SUZUKI";
            this.rbSuzuki.UseVisualStyleBackColor = true;
            // 
            // rbYamaha
            // 
            this.rbYamaha.AutoSize = true;
            this.rbYamaha.Location = new System.Drawing.Point(87, 13);
            this.rbYamaha.Name = "rbYamaha";
            this.rbYamaha.Size = new System.Drawing.Size(82, 19);
            this.rbYamaha.TabIndex = 1;
            this.rbYamaha.TabStop = true;
            this.rbYamaha.Text = "YAMAHA";
            this.rbYamaha.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(6, 13);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(75, 19);
            this.rbHonda.TabIndex = 0;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "HONDA";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // cbOverview
            // 
            this.cbOverview.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbOverview.FormattingEnabled = true;
            this.cbOverview.Items.AddRange(new object[] {
            "オイル油脂類交換5000km/半年",
            "オイルフィルター交換/オイル交換2回ごと",
            "エンジン系統点検・整備",
            "動力伝達装置点検・整備",
            "ステアリング装置点検・整備",
            "ブレーキ装置点検・整備",
            "足廻り点検・整備",
            "電気・灯火類点検・整備",
            "外装点検・整備"});
            this.cbOverview.Location = new System.Drawing.Point(71, 165);
            this.cbOverview.Name = "cbOverview";
            this.cbOverview.Size = new System.Drawing.Size(306, 23);
            this.cbOverview.TabIndex = 4;
            this.cbOverview.Text = "エンジン点検・整備";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(3, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "整備概要";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(16, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "排気量";
            // 
            // tbDetail
            // 
            this.tbDetail.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDetail.Location = new System.Drawing.Point(12, 221);
            this.tbDetail.Multiline = true;
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.Size = new System.Drawing.Size(568, 157);
            this.tbDetail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(1, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "整備詳細";
            // 
            // MaintenanceAddbt
            // 
            this.MaintenanceAddbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaintenanceAddbt.Location = new System.Drawing.Point(499, 583);
            this.MaintenanceAddbt.Name = "MaintenanceAddbt";
            this.MaintenanceAddbt.Size = new System.Drawing.Size(81, 38);
            this.MaintenanceAddbt.TabIndex = 6;
            this.MaintenanceAddbt.Text = "追加";
            this.MaintenanceAddbt.UseVisualStyleBackColor = true;
            this.MaintenanceAddbt.Click += new System.EventHandler(this.MaintenanceAddbt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(297, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "走行距離";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(312, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "車検日";
            // 
            // Distancetb
            // 
            this.Distancetb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Distancetb.Location = new System.Drawing.Point(370, 62);
            this.Distancetb.Name = "Distancetb";
            this.Distancetb.Size = new System.Drawing.Size(212, 22);
            this.Distancetb.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(370, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox4.Location = new System.Drawing.Point(71, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 22);
            this.textBox4.TabIndex = 9;
            // 
            // Namecb
            // 
            this.Namecb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Namecb.FormattingEnabled = true;
            this.Namecb.Items.AddRange(new object[] {
            "ZRX1200r",
            "XL1200r",
            "ZZR250",
            "XV250ビラーゴ",
            "エリミネーター125"});
            this.Namecb.Location = new System.Drawing.Point(71, 64);
            this.Namecb.Name = "Namecb";
            this.Namecb.Size = new System.Drawing.Size(212, 23);
            this.Namecb.TabIndex = 10;
            this.Namecb.SelectedIndexChanged += new System.EventHandler(this.Namecb_SelectedIndexChanged);
            // 
            // Backbt
            // 
            this.Backbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Backbt.Location = new System.Drawing.Point(409, 583);
            this.Backbt.Name = "Backbt";
            this.Backbt.Size = new System.Drawing.Size(81, 38);
            this.Backbt.TabIndex = 6;
            this.Backbt.Text = "戻る";
            this.Backbt.UseVisualStyleBackColor = true;
            this.Backbt.Click += new System.EventHandler(this.Backbt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(312, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "記入者";
            // 
            // cbAuthor
            // 
            this.cbAuthor.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Items.AddRange(new object[] {
            "ZRX1200r",
            "XL1200r",
            "ZZR250",
            "XV250ビラーゴ",
            "エリミネーター125"});
            this.cbAuthor.Location = new System.Drawing.Point(370, 28);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(212, 23);
            this.cbAuthor.TabIndex = 11;
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Location = new System.Drawing.Point(12, 384);
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.RowTemplate.Height = 21;
            this.dgvMaintenance.Size = new System.Drawing.Size(568, 193);
            this.dgvMaintenance.TabIndex = 12;
            // 
            // btnewAdd
            // 
            this.btnewAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnewAdd.Location = new System.Drawing.Point(186, 583);
            this.btnewAdd.Name = "btnewAdd";
            this.btnewAdd.Size = new System.Drawing.Size(135, 38);
            this.btnewAdd.TabIndex = 6;
            this.btnewAdd.Text = "新規追加";
            this.btnewAdd.UseVisualStyleBackColor = true;
            this.btnewAdd.Click += new System.EventHandler(this.btnewAdd_Click);
            // 
            // maintenanceTableAdapter1
            // 
            this.maintenanceTableAdapter1.ClearBeforeFill = true;
            // 
            // infosys202119Maintenance
            // 
            this.infosys202119Maintenance.DataSetName = "infosys202119DataSet";
            this.infosys202119Maintenance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 627);
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.Namecb);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Distancetb);
            this.Controls.Add(this.btnewAdd);
            this.Controls.Add(this.Backbt);
            this.Controls.Add(this.MaintenanceAddbt);
            this.Controls.Add(this.tbDetail);
            this.Controls.Add(this.cbOverview);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Name = "Maintenance";
            this.Text = "整備";
            this.Load += new System.EventHandler(this.Seibi_Load);
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202119Maintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbYamaha;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.RadioButton rbKawasaki;
        private System.Windows.Forms.RadioButton rbSuzuki;
        private System.Windows.Forms.ComboBox cbOverview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MaintenanceAddbt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Distancetb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox Namecb;
        private System.Windows.Forms.Button Backbt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.Button btnewAdd;
        private infosys202119DataSetTableAdapters.MaintenanceTableAdapter maintenanceTableAdapter1;
        private infosys202119DataSet infosys202119Maintenance;
    }
}

