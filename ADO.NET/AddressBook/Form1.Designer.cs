
namespace AddressBook
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.btConnect = new System.Windows.Forms.Button();
            this.btNameFilter = new System.Windows.Forms.Button();
            this.tbNameSearch = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btBirthdayFilter = new System.Windows.Forms.Button();
            this.dtpBirthdaySearch = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202119DataSet = new AddressBook.infosys202119DataSet();
            this.personTableAdapter = new AddressBook.infosys202119DataSetTableAdapters.PersonTableAdapter();
            this.tableAdapterManager = new AddressBook.infosys202119DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202119DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // personDataGridView
            // 
            this.personDataGridView.AllowUserToAddRows = false;
            this.personDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personDataGridView.DataSource = this.personBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.personDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.personDataGridView.Location = new System.Drawing.Point(6, 153);
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.RowTemplate.Height = 21;
            this.personDataGridView.Size = new System.Drawing.Size(598, 192);
            this.personDataGridView.TabIndex = 1;
            this.personDataGridView.SelectionChanged += new System.EventHandler(this.personDataGridView_SelectionChanged);
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btConnect.Location = new System.Drawing.Point(6, 360);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(120, 35);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btNameFilter
            // 
            this.btNameFilter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btNameFilter.Location = new System.Drawing.Point(304, 360);
            this.btNameFilter.Name = "btNameFilter";
            this.btNameFilter.Size = new System.Drawing.Size(120, 35);
            this.btNameFilter.TabIndex = 3;
            this.btNameFilter.Text = "名前抽出";
            this.btNameFilter.UseVisualStyleBackColor = true;
            this.btNameFilter.Click += new System.EventHandler(this.btNameFilter_Click);
            // 
            // tbNameSearch
            // 
            this.tbNameSearch.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNameSearch.Location = new System.Drawing.Point(430, 367);
            this.tbNameSearch.Name = "tbNameSearch";
            this.tbNameSearch.Size = new System.Drawing.Size(174, 23);
            this.tbNameSearch.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(6, 401);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(120, 35);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "誕生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "電話番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "備考";
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(351, 35);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(253, 90);
            this.tbMemo.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(75, 65);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 8;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(75, 106);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(200, 19);
            this.tbTelephone.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(75, 17);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 19);
            this.tbName.TabIndex = 7;
            // 
            // btBirthdayFilter
            // 
            this.btBirthdayFilter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBirthdayFilter.Location = new System.Drawing.Point(304, 396);
            this.btBirthdayFilter.Name = "btBirthdayFilter";
            this.btBirthdayFilter.Size = new System.Drawing.Size(120, 35);
            this.btBirthdayFilter.TabIndex = 3;
            this.btBirthdayFilter.Text = "誕生日抽出";
            this.btBirthdayFilter.UseVisualStyleBackColor = true;
            this.btBirthdayFilter.Click += new System.EventHandler(this.btBirthdayFilter_Click);
            // 
            // dtpBirthdaySearch
            // 
            this.dtpBirthdaySearch.Location = new System.Drawing.Point(430, 405);
            this.dtpBirthdaySearch.Name = "dtpBirthdaySearch";
            this.dtpBirthdaySearch.Size = new System.Drawing.Size(174, 19);
            this.dtpBirthdaySearch.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn3.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telephone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Memo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Memo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.infosys202119DataSet;
            // 
            // infosys202119DataSet
            // 
            this.infosys202119DataSet.DataSetName = "infosys202119DataSet";
            this.infosys202119DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableAdapter = this.personTableAdapter;
            this.tableAdapterManager.UpdateOrder = AddressBook.infosys202119DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 443);
            this.Controls.Add(this.dtpBirthdaySearch);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbNameSearch);
            this.Controls.Add(this.btBirthdayFilter);
            this.Controls.Add(this.btNameFilter);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.personDataGridView);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202119DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202119DataSet infosys202119DataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private infosys202119DataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private infosys202119DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btNameFilter;
        private System.Windows.Forms.TextBox tbNameSearch;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btBirthdayFilter;
        private System.Windows.Forms.DateTimePicker dtpBirthdaySearch;
    }
}

