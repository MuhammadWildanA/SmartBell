namespace Dashboard_bell
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.combokategori = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnKelolaKategori = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.comboHari = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNamaSekolah = new System.Windows.Forms.Label();
            this.waktu1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTambahJadwal = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combokategori
            // 
            this.combokategori.FormattingEnabled = true;
            this.combokategori.Location = new System.Drawing.Point(238, 128);
            this.combokategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combokategori.Name = "combokategori";
            this.combokategori.Size = new System.Drawing.Size(271, 28);
            this.combokategori.TabIndex = 2;
            this.combokategori.SelectedIndexChanged += new System.EventHandler(this.combokategori_SelectedIndexChanged);
            this.combokategori.SelectedValueChanged += new System.EventHandler(this.combokategori_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Controls.Add(this.btnKelolaKategori);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.comboHari);
            this.panel2.Controls.Add(this.combokategori);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 294);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(238, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pilihan Hari";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pilihan Kategori";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(20, 75);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(195, 200);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnKelolaKategori
            // 
            this.btnKelolaKategori.AutoSize = true;
            this.btnKelolaKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnKelolaKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKelolaKategori.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelolaKategori.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKelolaKategori.Location = new System.Drawing.Point(520, 126);
            this.btnKelolaKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKelolaKategori.Name = "btnKelolaKategori";
            this.btnKelolaKategori.Size = new System.Drawing.Size(102, 52);
            this.btnKelolaKategori.TabIndex = 9;
            this.btnKelolaKategori.Text = "Kelola";
            this.btnKelolaKategori.UseVisualStyleBackColor = false;
            this.btnKelolaKategori.Click += new System.EventHandler(this.btnKelolaKategori_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateLabel.Location = new System.Drawing.Point(689, 228);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(250, 31);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "senin 20 januari 2025";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeLabel.Location = new System.Drawing.Point(733, 178);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(164, 45);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboHari
            // 
            this.comboHari.FormattingEnabled = true;
            this.comboHari.Location = new System.Drawing.Point(242, 226);
            this.comboHari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboHari.Name = "comboHari";
            this.comboHari.Size = new System.Drawing.Size(271, 28);
            this.comboHari.TabIndex = 4;
            this.comboHari.SelectedIndexChanged += new System.EventHandler(this.comboHari_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.panel3.Controls.Add(this.txtNamaSekolah);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 68);
            this.panel3.TabIndex = 12;
            // 
            // txtNamaSekolah
            // 
            this.txtNamaSekolah.BackColor = System.Drawing.Color.Transparent;
            this.txtNamaSekolah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNamaSekolah.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaSekolah.ForeColor = System.Drawing.SystemColors.Control;
            this.txtNamaSekolah.Location = new System.Drawing.Point(0, 0);
            this.txtNamaSekolah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtNamaSekolah.Name = "txtNamaSekolah";
            this.txtNamaSekolah.Size = new System.Drawing.Size(1028, 68);
            this.txtNamaSekolah.TabIndex = 2;
            this.txtNamaSekolah.Text = "Smart Bell";
            this.txtNamaSekolah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtNamaSekolah.Click += new System.EventHandler(this.txtNamaSekolah_Click);
            // 
            // waktu1
            // 
            this.waktu1.Tick += new System.EventHandler(this.waktu1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 294);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1028, 367);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.btnTambahJadwal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 661);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 65);
            this.panel1.TabIndex = 8;
            // 
            // btnTambahJadwal
            // 
            this.btnTambahJadwal.BackColor = System.Drawing.Color.Transparent;
            this.btnTambahJadwal.BorderRadius = 5;
            this.btnTambahJadwal.BorderThickness = 1;
            this.btnTambahJadwal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahJadwal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTambahJadwal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTambahJadwal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTambahJadwal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.btnTambahJadwal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambahJadwal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTambahJadwal.Location = new System.Drawing.Point(15, 14);
            this.btnTambahJadwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTambahJadwal.Name = "btnTambahJadwal";
            this.btnTambahJadwal.Size = new System.Drawing.Size(176, 37);
            this.btnTambahJadwal.TabIndex = 0;
            this.btnTambahJadwal.Text = "Tambah Jadwal";
            this.btnTambahJadwal.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 726);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1050, 782);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMART BELL";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox comboHari;
        private System.Windows.Forms.ComboBox combokategori;
        private System.Windows.Forms.Timer waktu1;
        private System.Windows.Forms.Button btnKelolaKategori;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNamaSekolah;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTambahJadwal;
        private System.Windows.Forms.Panel panel3;
    }
}