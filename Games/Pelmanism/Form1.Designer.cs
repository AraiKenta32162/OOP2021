
namespace Pelmanism
{
    partial class FormGame
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
            this.labelSec = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelGuidance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Location = new System.Drawing.Point(12, 9);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(47, 12);
            this.labelSec.TabIndex = 0;
            this.labelSec.Text = "0秒経過";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(190, 276);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // labelGuidance
            // 
            this.labelGuidance.AutoSize = true;
            this.labelGuidance.ForeColor = System.Drawing.Color.Red;
            this.labelGuidance.Location = new System.Drawing.Point(78, 9);
            this.labelGuidance.Name = "labelGuidance";
            this.labelGuidance.Size = new System.Drawing.Size(35, 12);
            this.labelGuidance.TabIndex = 2;
            this.labelGuidance.Text = "label1";
            // 
            // FormGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(459, 311);
            this.Controls.Add(this.labelGuidance);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelSec);
            this.Name = "FormGame";
            this.Text = "神経衰弱";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelGuidance;
    }
}

