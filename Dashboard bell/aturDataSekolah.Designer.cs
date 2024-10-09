namespace Dashboard_bell
{
    partial class aturDataSekolah
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
            this.lblFile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNada = new System.Windows.Forms.Label();
            this.btnSimpanData = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNamaSekolah = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(128, 90);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 13);
            this.lblFile.TabIndex = 22;
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(98, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Pilih ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNada
            // 
            this.lblNada.AutoSize = true;
            this.lblNada.Location = new System.Drawing.Point(19, 66);
            this.lblNada.Name = "lblNada";
            this.lblNada.Size = new System.Drawing.Size(73, 13);
            this.lblNada.TabIndex = 20;
            this.lblNada.Text = "Logo Sekolah";
            // 
            // btnSimpanData
            // 
            this.btnSimpanData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpanData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnSimpanData.BorderThickness = 1;
            this.btnSimpanData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpanData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpanData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpanData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpanData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpanData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnSimpanData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimpanData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSimpanData.Location = new System.Drawing.Point(244, 179);
            this.btnSimpanData.Name = "btnSimpanData";
            this.btnSimpanData.Size = new System.Drawing.Size(76, 29);
            this.btnSimpanData.TabIndex = 19;
            this.btnSimpanData.Text = "Simpan";
            this.btnSimpanData.Click += new System.EventHandler(this.btnSimpanData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama Sekolah";
            // 
            // tbNamaSekolah
            // 
            this.tbNamaSekolah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNamaSekolah.Location = new System.Drawing.Point(98, 26);
            this.tbNamaSekolah.Name = "tbNamaSekolah";
            this.tbNamaSekolah.Size = new System.Drawing.Size(187, 20);
            this.tbNamaSekolah.TabIndex = 13;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(22, 90);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 23;
            this.pbLogo.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // aturDataSekolah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(332, 220);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNada);
            this.Controls.Add(this.btnSimpanData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNamaSekolah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "aturDataSekolah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Nama dan Logo";
            this.Load += new System.EventHandler(this.aturDataSekolah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNada;
        private Guna.UI2.WinForms.Guna2Button btnSimpanData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamaSekolah;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}