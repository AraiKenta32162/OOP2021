﻿
namespace Ex1
{
    partial class Tooling
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.Distancetb = new System.Windows.Forms.TextBox();
            this.Destinationtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Peopletb = new System.Windows.Forms.TextBox();
            this.Costtb = new System.Windows.Forms.TextBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TouringAddbt = new System.Windows.Forms.Button();
            this.Namecb = new System.Windows.Forms.ComboBox();
            this.TouringClosebt = new System.Windows.Forms.Button();
            this.ofdPictureOpen = new System.Windows.Forms.OpenFileDialog();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            this.infosys202119Touring = new Ex1.infosys202119DataSet1();
            this.touringTableAdapter1 = new Ex1.infosys202119DataSet1TableAdapters.TouringTableAdapter();
            this.dgvTooling = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.touringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new Ex1.infosys202119DataSet1TableAdapters.TableAdapterManager();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ssErrerLavel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnewAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202119Touring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTooling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touringBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(13, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "目的地";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(-2, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "走行距離";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "車両名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "記入日";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(71, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(212, 22);
            this.dtpDate.TabIndex = 3;
            // 
            // Distancetb
            // 
            this.Distancetb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Distancetb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Distancetb.Location = new System.Drawing.Point(71, 101);
            this.Distancetb.Name = "Distancetb";
            this.Distancetb.Size = new System.Drawing.Size(212, 22);
            this.Distancetb.TabIndex = 13;
            // 
            // Destinationtb
            // 
            this.Destinationtb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Destinationtb.Location = new System.Drawing.Point(71, 132);
            this.Destinationtb.Name = "Destinationtb";
            this.Destinationtb.Size = new System.Drawing.Size(212, 22);
            this.Destinationtb.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(28, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "人数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(28, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "費用";
            // 
            // Peopletb
            // 
            this.Peopletb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Peopletb.Location = new System.Drawing.Point(71, 162);
            this.Peopletb.Name = "Peopletb";
            this.Peopletb.Size = new System.Drawing.Size(212, 22);
            this.Peopletb.TabIndex = 13;
            // 
            // Costtb
            // 
            this.Costtb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Costtb.Location = new System.Drawing.Point(71, 195);
            this.Costtb.Name = "Costtb";
            this.Costtb.Size = new System.Drawing.Size(212, 22);
            this.Costtb.TabIndex = 13;
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(300, 41);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(257, 176);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 14;
            this.pbPicture.TabStop = false;
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.Location = new System.Drawing.Point(455, 10);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(102, 25);
            this.btPictureDelete.TabIndex = 17;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            this.btPictureDelete.Click += new System.EventHandler(this.btPictureDelete_Click);
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(347, 10);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(102, 25);
            this.btPictureOpen.TabIndex = 16;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "画像";
            // 
            // TouringAddbt
            // 
            this.TouringAddbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TouringAddbt.Location = new System.Drawing.Point(374, 419);
            this.TouringAddbt.Name = "TouringAddbt";
            this.TouringAddbt.Size = new System.Drawing.Size(96, 38);
            this.TouringAddbt.TabIndex = 18;
            this.TouringAddbt.Text = "保存";
            this.TouringAddbt.UseVisualStyleBackColor = true;
            this.TouringAddbt.Click += new System.EventHandler(this.TouringAddbt_Click);
            // 
            // Namecb
            // 
            this.Namecb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Namecb.FormattingEnabled = true;
            this.Namecb.Items.AddRange(new object[] {
            "-----～1000cc-------",
            "GL1800ゴールドウィング",
            "CB1300Super Four",
            "CB1300Super ボルドール",
            "ZRX1200r",
            "XL1200r",
            "-----1000cc--------",
            "CBR1000RR-R",
            "------750cc--------",
            "NC750X",
            "CBR650R",
            "CB650R",
            "レブル500",
            "------400cc--------",
            "CB400SuperFour",
            "CBR400R",
            "GB350",
            "------250cc--------",
            "CBR250RR",
            "レブル250",
            "ZZR250",
            "XV250ビラーゴ",
            "エリミネーター125"});
            this.Namecb.Location = new System.Drawing.Point(71, 69);
            this.Namecb.Name = "Namecb";
            this.Namecb.Size = new System.Drawing.Size(212, 23);
            this.Namecb.TabIndex = 20;
            // 
            // TouringClosebt
            // 
            this.TouringClosebt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TouringClosebt.Location = new System.Drawing.Point(476, 421);
            this.TouringClosebt.Name = "TouringClosebt";
            this.TouringClosebt.Size = new System.Drawing.Size(81, 38);
            this.TouringClosebt.TabIndex = 21;
            this.TouringClosebt.Text = "戻る";
            this.TouringClosebt.UseVisualStyleBackColor = true;
            this.TouringClosebt.Click += new System.EventHandler(this.TouringClosebt_Click);
            // 
            // ofdPictureOpen
            // 
            this.ofdPictureOpen.FileName = "openFileDialog1";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAuthor.Location = new System.Drawing.Point(71, 41);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(212, 22);
            this.tbAuthor.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(13, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "記入者";
            // 
            // infosys202119Touring
            // 
            this.infosys202119Touring.DataSetName = "infosys202119DataSet1";
            this.infosys202119Touring.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // touringTableAdapter1
            // 
            this.touringTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvTooling
            // 
            this.dgvTooling.AutoGenerateColumns = false;
            this.dgvTooling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTooling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.autherDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dgvTooling.DataSource = this.touringBindingSource;
            this.dgvTooling.Location = new System.Drawing.Point(12, 223);
            this.dgvTooling.Name = "dgvTooling";
            this.dgvTooling.RowTemplate.Height = 21;
            this.dgvTooling.Size = new System.Drawing.Size(545, 191);
            this.dgvTooling.TabIndex = 24;
            this.dgvTooling.SelectionChanged += new System.EventHandler(this.dgvTooling_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // autherDataGridViewTextBoxColumn
            // 
            this.autherDataGridViewTextBoxColumn.DataPropertyName = "Auther";
            this.autherDataGridViewTextBoxColumn.HeaderText = "Auther";
            this.autherDataGridViewTextBoxColumn.Name = "autherDataGridViewTextBoxColumn";
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // peopleDataGridViewTextBoxColumn
            // 
            this.peopleDataGridViewTextBoxColumn.DataPropertyName = "People";
            this.peopleDataGridViewTextBoxColumn.HeaderText = "People";
            this.peopleDataGridViewTextBoxColumn.Name = "peopleDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // touringBindingSource
            // 
            this.touringBindingSource.DataMember = "Touring";
            this.touringBindingSource.DataSource = this.infosys202119Touring;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TouringTableAdapter = this.touringTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Ex1.infosys202119DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssErrerLavel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(569, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ssErrerLavel
            // 
            this.ssErrerLavel.Name = "ssErrerLavel";
            this.ssErrerLavel.Size = new System.Drawing.Size(118, 17);
            this.ssErrerLavel.Text = "toolStripStatusLabel1";
            // 
            // btnewAdd
            // 
            this.btnewAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnewAdd.Location = new System.Drawing.Point(16, 419);
            this.btnewAdd.Name = "btnewAdd";
            this.btnewAdd.Size = new System.Drawing.Size(125, 38);
            this.btnewAdd.TabIndex = 18;
            this.btnewAdd.Text = "新規追加";
            this.btnewAdd.UseVisualStyleBackColor = true;
            this.btnewAdd.Click += new System.EventHandler(this.btnewAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDelete.Location = new System.Drawing.Point(272, 419);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 38);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Tooling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvTooling);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TouringClosebt);
            this.Controls.Add(this.Namecb);
            this.Controls.Add(this.btnewAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.TouringAddbt);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.Costtb);
            this.Controls.Add(this.Destinationtb);
            this.Controls.Add(this.Peopletb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Distancetb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Name = "Tooling";
            this.Text = "Tooling";
            this.Load += new System.EventHandler(this.Tooling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202119Touring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTooling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touringBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button TouringAddbt;
        private System.Windows.Forms.Button TouringClosebt;
        private System.Windows.Forms.OpenFileDialog ofdPictureOpen;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbAuthor;
        public System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.TextBox Distancetb;
        public System.Windows.Forms.TextBox Destinationtb;
        public System.Windows.Forms.TextBox Peopletb;
        public System.Windows.Forms.TextBox Costtb;
        public System.Windows.Forms.ComboBox Namecb;
        public System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
        private infosys202119DataSet1 infosys202119Touring;
        private infosys202119DataSet1TableAdapters.TouringTableAdapter touringTableAdapter1;
        private System.Windows.Forms.DataGridView dgvTooling;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        public System.Windows.Forms.BindingSource touringBindingSource;
        private infosys202119DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ssErrerLavel;
        private System.Windows.Forms.Button btnewAdd;
        private System.Windows.Forms.Button btDelete;
    }
}