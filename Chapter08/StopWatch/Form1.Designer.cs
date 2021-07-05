
namespace StopWatch {
    partial class Form1 {
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
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btLap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(12, 9);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(178, 52);
            this.lbTimerDisp.TabIndex = 0;
            this.lbTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(18, 94);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(122, 62);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(167, 94);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(122, 62);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(18, 171);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(122, 62);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "ストップ";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btLap
            // 
            this.btLap.Location = new System.Drawing.Point(167, 171);
            this.btLap.Name = "btLap";
            this.btLap.Size = new System.Drawing.Size(122, 62);
            this.btLap.TabIndex = 1;
            this.btLap.Text = "ラップ→";
            this.btLap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 263);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btLap);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbTimerDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btLap;
    }
}

