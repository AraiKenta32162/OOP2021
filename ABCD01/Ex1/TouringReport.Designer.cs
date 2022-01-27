
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
            this.components = new System.ComponentModel.Container();
            this.dgvTouringData = new System.Windows.Forms.DataGridView();
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
            this.infosys202119Touring = new Ex1.infosys202119DataSet1();
            this.Backbt = new System.Windows.Forms.Button();
            this.Displaybt = new System.Windows.Forms.Button();
            this.McNamecb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.touringTableAdapter = new Ex1.infosys202119DataSet1TableAdapters.TouringTableAdapter();
            this.tableAdapterManager = new Ex1.infosys202119DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTouringData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.touringBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202119Touring)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTouringData
            // 
            this.dgvTouringData.AutoGenerateColumns = false;
            this.dgvTouringData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTouringData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.autherDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dgvTouringData.DataSource = this.touringBindingSource;
            this.dgvTouringData.Location = new System.Drawing.Point(12, 106);
            this.dgvTouringData.Name = "dgvTouringData";
            this.dgvTouringData.RowTemplate.Height = 21;
            this.dgvTouringData.Size = new System.Drawing.Size(943, 492);
            this.dgvTouringData.TabIndex = 19;
            this.dgvTouringData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTouringData_CellContentClick);
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
            // infosys202119Touring
            // 
            this.infosys202119Touring.DataSetName = "infosys202119DataSet1";
            this.infosys202119Touring.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Backbt
            // 
            this.Backbt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Backbt.Location = new System.Drawing.Point(863, 25);
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
            this.Displaybt.Location = new System.Drawing.Point(748, 25);
            this.Displaybt.Name = "Displaybt";
            this.Displaybt.Size = new System.Drawing.Size(94, 58);
            this.Displaybt.TabIndex = 23;
            this.Displaybt.Text = "表示";
            this.Displaybt.UseVisualStyleBackColor = true;
            this.Displaybt.Click += new System.EventHandler(this.Displaybt_Click);
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
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // touringTableAdapter
            // 
            this.touringTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TouringTableAdapter = this.touringTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ex1.infosys202119DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TouringReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 610);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Backbt);
            this.Controls.Add(this.Displaybt);
            this.Controls.Add(this.McNamecb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTouringData);
            this.Name = "TouringReport";
            this.Text = "TouringReport";
            this.Load += new System.EventHandler(this.TouringReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTouringData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.touringBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202119Touring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Backbt;
        private System.Windows.Forms.Button Displaybt;
        private System.Windows.Forms.ComboBox McNamecb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource touringBindingSource;
        public infosys202119DataSet1TableAdapters.TouringTableAdapter touringTableAdapter;
        public infosys202119DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        public infosys202119DataSet1 infosys202119Touring;
        public System.Windows.Forms.DataGridView dgvTouringData;
    }
}