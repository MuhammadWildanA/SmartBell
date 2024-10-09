namespace Dashboard_bell
{
    partial class dialogJadwal
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWaktu = new System.Windows.Forms.MaskedTextBox();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTambahData = new Guna.UI2.WinForms.Guna2Button();
            this.lblNada = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(110, 40);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(280, 26);
            this.txtNama.TabIndex = 0;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(36, 45);
            this.lblJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(47, 20);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Judul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jam";
            // 
            // txtWaktu
            // 
            this.txtWaktu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWaktu.Location = new System.Drawing.Point(110, 106);
            this.txtWaktu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWaktu.Mask = "00:00";
            this.txtWaktu.Name = "txtWaktu";
            this.txtWaktu.Size = new System.Drawing.Size(280, 26);
            this.txtWaktu.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSimpan.Location = new System.Drawing.Point(366, 275);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(114, 45);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambahData
            // 
            this.btnTambahData.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnTambahData.BorderThickness = 1;
            this.btnTambahData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahData.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahData.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnTambahData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambahData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTambahData.Location = new System.Drawing.Point(366, 275);
            this.btnTambahData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(114, 45);
            this.btnTambahData.TabIndex = 9;
            this.btnTambahData.Text = "Tambah";
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // lblNada
            // 
            this.lblNada.AutoSize = true;
            this.lblNada.Location = new System.Drawing.Point(36, 169);
            this.lblNada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNada.Name = "lblNada";
            this.lblNada.Size = new System.Drawing.Size(47, 20);
            this.lblNada.TabIndex = 10;
            this.lblNada.Text = "Nada";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(110, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Pilih ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(232, 177);
            this.lblFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(0, 20);
            this.lblFile.TabIndex = 12;
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dialogJadwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(498, 338);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNada);
            this.Controls.Add(this.btnTambahData);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtWaktu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.txtNama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dialogJadwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aturJadwal";
            this.Load += new System.EventHandler(this.dialogJadwal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtWaktu;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnTambahData;
        private System.Windows.Forms.Label lblNada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFile;
    }
}