
namespace Ex1
{
    partial class Selection_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selection_screen));
            this.Maintenancebt = new System.Windows.Forms.Button();
            this.Touringbt = new System.Windows.Forms.Button();
            this.Logbt = new System.Windows.Forms.Button();
            this.Reportbt = new System.Windows.Forms.Button();
            this.Closebt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Maintenancebt
            // 
            this.Maintenancebt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maintenancebt.BackgroundImage")));
            this.Maintenancebt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maintenancebt.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintenancebt.ForeColor = System.Drawing.Color.White;
            this.Maintenancebt.Location = new System.Drawing.Point(108, 126);
            this.Maintenancebt.Name = "Maintenancebt";
            this.Maintenancebt.Size = new System.Drawing.Size(210, 144);
            this.Maintenancebt.TabIndex = 1;
            this.Maintenancebt.Text = "Today\'s maintenance";
            this.Maintenancebt.UseVisualStyleBackColor = true;
            this.Maintenancebt.Click += new System.EventHandler(this.Maintenancebt_Click);
            // 
            // Touringbt
            // 
            this.Touringbt.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Touringbt.Location = new System.Drawing.Point(373, 126);
            this.Touringbt.Name = "Touringbt";
            this.Touringbt.Size = new System.Drawing.Size(210, 144);
            this.Touringbt.TabIndex = 2;
            this.Touringbt.Text = "Today\'s Touring";
            this.Touringbt.UseVisualStyleBackColor = true;
            this.Touringbt.Click += new System.EventHandler(this.Touringbt_Click);
            // 
            // Logbt
            // 
            this.Logbt.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logbt.Location = new System.Drawing.Point(139, 277);
            this.Logbt.Name = "Logbt";
            this.Logbt.Size = new System.Drawing.Size(150, 60);
            this.Logbt.TabIndex = 2;
            this.Logbt.Text = "Maintenance\r\nlog";
            this.Logbt.UseVisualStyleBackColor = true;
            this.Logbt.Click += new System.EventHandler(this.Logbt_Click);
            // 
            // Reportbt
            // 
            this.Reportbt.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportbt.Location = new System.Drawing.Point(406, 277);
            this.Reportbt.Name = "Reportbt";
            this.Reportbt.Size = new System.Drawing.Size(150, 60);
            this.Reportbt.TabIndex = 2;
            this.Reportbt.Text = "Touring\r\nReport\r\n";
            this.Reportbt.UseVisualStyleBackColor = true;
            this.Reportbt.Click += new System.EventHandler(this.Reportbt_Click);
            // 
            // Closebt
            // 
            this.Closebt.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Closebt.Location = new System.Drawing.Point(593, 398);
            this.Closebt.Name = "Closebt";
            this.Closebt.Size = new System.Drawing.Size(98, 40);
            this.Closebt.TabIndex = 3;
            this.Closebt.Text = "close";
            this.Closebt.UseVisualStyleBackColor = true;
            this.Closebt.Click += new System.EventHandler(this.Closebt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 120);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(15, 358);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(573, 79);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Topics";
            // 
            // Selection_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Closebt);
            this.Controls.Add(this.Reportbt);
            this.Controls.Add(this.Logbt);
            this.Controls.Add(this.Touringbt);
            this.Controls.Add(this.Maintenancebt);
            this.Name = "Selection_screen";
            this.Text = "Selection_screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Maintenancebt;
        private System.Windows.Forms.Button Touringbt;
        private System.Windows.Forms.Button Logbt;
        private System.Windows.Forms.Button Reportbt;
        private System.Windows.Forms.Button Closebt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}