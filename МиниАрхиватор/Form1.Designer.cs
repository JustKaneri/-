namespace МиниАрхиватор
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnPuck = new System.Windows.Forms.Button();
            this.BtnUnPack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BtnPuck
            // 
            this.BtnPuck.Location = new System.Drawing.Point(96, 53);
            this.BtnPuck.Name = "BtnPuck";
            this.BtnPuck.Size = new System.Drawing.Size(167, 49);
            this.BtnPuck.TabIndex = 0;
            this.BtnPuck.Text = "Упаковать файл";
            this.BtnPuck.UseVisualStyleBackColor = true;
            // 
            // BtnUnPack
            // 
            this.BtnUnPack.Location = new System.Drawing.Point(96, 147);
            this.BtnUnPack.Name = "BtnUnPack";
            this.BtnUnPack.Size = new System.Drawing.Size(167, 48);
            this.BtnUnPack.TabIndex = 1;
            this.BtnUnPack.Text = "Расфпоковать файл";
            this.BtnUnPack.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Файлы архиватора (*.pack)|*.pack|Все файлы (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 237);
            this.Controls.Add(this.BtnUnPack);
            this.Controls.Add(this.BtnPuck);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Архиватор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPuck;
        private System.Windows.Forms.Button BtnUnPack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

