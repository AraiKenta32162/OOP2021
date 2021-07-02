
namespace Exercise3 {
    partial class Form {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.button5_3_1 = new System.Windows.Forms.Button();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.button5_3_2 = new System.Windows.Forms.Button();
            this.TextBoxWordChenge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5_3_3 = new System.Windows.Forms.Button();
            this.TextBoxWordCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5_3_4 = new System.Windows.Forms.Button();
            this.TextBoxFourWord = new System.Windows.Forms.TextBox();
            this.button5_3_5 = new System.Windows.Forms.Button();
            this.TextBoxLinking = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputStrData = new System.Windows.Forms.TextBox();
            this.inputStrData = new System.Windows.Forms.TextBox();
            this.button5_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(53, 83);
            this.inputStrText.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(785, 34);
            this.inputStrText.TabIndex = 1;
            // 
            // button5_3_1
            // 
            this.button5_3_1.Location = new System.Drawing.Point(53, 154);
            this.button5_3_1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button5_3_1.Name = "button5_3_1";
            this.button5_3_1.Size = new System.Drawing.Size(179, 61);
            this.button5_3_1.TabIndex = 2;
            this.button5_3_1.Text = "空白をカウント";
            this.button5_3_1.UseVisualStyleBackColor = true;
            this.button5_3_1.Click += new System.EventHandler(this.button5_3_1_Click);
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(366, 168);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(223, 34);
            this.TextBoxSpaceCount.TabIndex = 3;
            // 
            // button5_3_2
            // 
            this.button5_3_2.Location = new System.Drawing.Point(53, 229);
            this.button5_3_2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.button5_3_2.Name = "button5_3_2";
            this.button5_3_2.Size = new System.Drawing.Size(179, 61);
            this.button5_3_2.TabIndex = 2;
            this.button5_3_2.Text = "big→small";
            this.button5_3_2.UseVisualStyleBackColor = true;
            this.button5_3_2.Click += new System.EventHandler(this.button5_3_2_Click);
            // 
            // TextBoxWordChenge
            // 
            this.TextBoxWordChenge.Location = new System.Drawing.Point(366, 243);
            this.TextBoxWordChenge.Name = "TextBoxWordChenge";
            this.TextBoxWordChenge.Size = new System.Drawing.Size(472, 34);
            this.TextBoxWordChenge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(289, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "空白は";
            // 
            // button5_3_3
            // 
            this.button5_3_3.Location = new System.Drawing.Point(53, 300);
            this.button5_3_3.Name = "button5_3_3";
            this.button5_3_3.Size = new System.Drawing.Size(179, 61);
            this.button5_3_3.TabIndex = 4;
            this.button5_3_3.Text = "単語数カウント";
            this.button5_3_3.UseVisualStyleBackColor = true;
            this.button5_3_3.Click += new System.EventHandler(this.button5_3_3_Click);
            // 
            // TextBoxWordCount
            // 
            this.TextBoxWordCount.Location = new System.Drawing.Point(366, 314);
            this.TextBoxWordCount.Name = "TextBoxWordCount";
            this.TextBoxWordCount.Size = new System.Drawing.Size(223, 34);
            this.TextBoxWordCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(289, 329);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "単語数は";
            // 
            // button5_3_4
            // 
            this.button5_3_4.Location = new System.Drawing.Point(53, 370);
            this.button5_3_4.Name = "button5_3_4";
            this.button5_3_4.Size = new System.Drawing.Size(179, 61);
            this.button5_3_4.TabIndex = 6;
            this.button5_3_4.Text = "4文字以下";
            this.button5_3_4.UseVisualStyleBackColor = true;
            this.button5_3_4.Click += new System.EventHandler(this.button5_3_4_Click);
            // 
            // TextBoxFourWord
            // 
            this.TextBoxFourWord.Location = new System.Drawing.Point(366, 384);
            this.TextBoxFourWord.Name = "TextBoxFourWord";
            this.TextBoxFourWord.Size = new System.Drawing.Size(225, 34);
            this.TextBoxFourWord.TabIndex = 7;
            // 
            // button5_3_5
            // 
            this.button5_3_5.Location = new System.Drawing.Point(53, 448);
            this.button5_3_5.Name = "button5_3_5";
            this.button5_3_5.Size = new System.Drawing.Size(179, 61);
            this.button5_3_5.TabIndex = 8;
            this.button5_3_5.Text = "5-3-5";
            this.button5_3_5.UseVisualStyleBackColor = true;
            this.button5_3_5.Click += new System.EventHandler(this.button5_3_5_Click);
            // 
            // TextBoxLinking
            // 
            this.TextBoxLinking.Location = new System.Drawing.Point(366, 462);
            this.TextBoxLinking.Name = "TextBoxLinking";
            this.TextBoxLinking.Size = new System.Drawing.Size(472, 34);
            this.TextBoxLinking.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(48, 569);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "問題5.4";
            // 
            // outputStrData
            // 
            this.outputStrData.Location = new System.Drawing.Point(366, 644);
            this.outputStrData.Multiline = true;
            this.outputStrData.Name = "outputStrData";
            this.outputStrData.Size = new System.Drawing.Size(472, 162);
            this.outputStrData.TabIndex = 10;
            // 
            // inputStrData
            // 
            this.inputStrData.Location = new System.Drawing.Point(53, 604);
            this.inputStrData.Name = "inputStrData";
            this.inputStrData.Size = new System.Drawing.Size(785, 34);
            this.inputStrData.TabIndex = 11;
            // 
            // button5_4
            // 
            this.button5_4.Location = new System.Drawing.Point(53, 669);
            this.button5_4.Name = "button5_4";
            this.button5_4.Size = new System.Drawing.Size(179, 61);
            this.button5_4.TabIndex = 12;
            this.button5_4.Text = "問題5.4";
            this.button5_4.UseVisualStyleBackColor = true;
            this.button5_4.Click += new System.EventHandler(this.button5_4_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 818);
            this.Controls.Add(this.button5_4);
            this.Controls.Add(this.inputStrData);
            this.Controls.Add(this.outputStrData);
            this.Controls.Add(this.TextBoxLinking);
            this.Controls.Add(this.button5_3_5);
            this.Controls.Add(this.TextBoxFourWord);
            this.Controls.Add(this.button5_3_4);
            this.Controls.Add(this.TextBoxWordCount);
            this.Controls.Add(this.button5_3_3);
            this.Controls.Add(this.TextBoxWordChenge);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.button5_3_2);
            this.Controls.Add(this.button5_3_1);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button button5_3_1;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.Button button5_3_2;
        private System.Windows.Forms.TextBox TextBoxWordChenge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5_3_3;
        private System.Windows.Forms.TextBox TextBoxWordCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5_3_4;
        private System.Windows.Forms.TextBox TextBoxFourWord;
        private System.Windows.Forms.Button button5_3_5;
        private System.Windows.Forms.TextBox TextBoxLinking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputStrData;
        private System.Windows.Forms.TextBox inputStrData;
        private System.Windows.Forms.Button button5_4;
    }
}

