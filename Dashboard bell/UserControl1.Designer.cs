namespace Dashboard_bell
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tgCon = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnPlay = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbJam = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNada = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tgCon
            // 
            this.tgCon.Checked = true;
            this.tgCon.CheckedState.BorderColor = System.Drawing.Color.DarkCyan;
            this.tgCon.CheckedState.FillColor = System.Drawing.Color.DarkCyan;
            this.tgCon.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgCon.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgCon.Location = new System.Drawing.Point(595, 7);
            this.tgCon.Name = "tgCon";
            this.tgCon.Size = new System.Drawing.Size(35, 20);
            this.tgCon.TabIndex = 24;
            this.tgCon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgCon.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgCon.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgCon.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tgCon.CheckedChanged += new System.EventHandler(this.tgCon_CheckedChanged);
            this.tgCon.Click += new System.EventHandler(this.tgCon_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(524, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(65, 29);
            this.btnPlay.TabIndex = 23;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(287, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "Atur";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbJam
            // 
            this.tbJam.AutoSize = true;
            this.tbJam.BorderColor = System.Drawing.Color.Black;
            this.tbJam.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbJam.DefaultText = "00:00:00";
            this.tbJam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbJam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbJam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbJam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbJam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.tbJam.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.tbJam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbJam.ForeColor = System.Drawing.Color.Black;
            this.tbJam.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbJam.Location = new System.Drawing.Point(199, 3);
            this.tbJam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbJam.Name = "tbJam";
            this.tbJam.PasswordChar = '\0';
            this.tbJam.PlaceholderText = "";
            this.tbJam.ReadOnly = true;
            this.tbJam.SelectedText = "";
            this.tbJam.Size = new System.Drawing.Size(81, 29);
            this.tbJam.TabIndex = 21;
            this.tbJam.TextChanged += new System.EventHandler(this.tbJam_TextChanged);
            // 
            // tbNama
            // 
            this.tbNama.AutoSize = true;
            this.tbNama.BorderColor = System.Drawing.Color.Black;
            this.tbNama.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbNama.DefaultText = "Jam Ke 1";
            this.tbNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.tbNama.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.tbNama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbNama.ForeColor = System.Drawing.Color.Black;
            this.tbNama.HoverState.BorderColor = System.Drawing.Color.Black;
            this.tbNama.Location = new System.Drawing.Point(4, 3);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNama.Name = "tbNama";
            this.tbNama.PasswordChar = '\0';
            this.tbNama.PlaceholderText = "";
            this.tbNama.ReadOnly = true;
            this.tbNama.SelectedText = "";
            this.tbNama.Size = new System.Drawing.Size(187, 29);
            this.tbNama.TabIndex = 20;
            // 
            // lbNada
            // 
            this.lbNada.Location = new System.Drawing.Point(407, 11);
            this.lbNada.Name = "lbNada";
            this.lbNada.Size = new System.Drawing.Size(111, 16);
            this.lbNada.TabIndex = 25;
            this.lbNada.Text = "default.mp3";
            this.lbNada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(52)))), ((int)(((byte)(110)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(343, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNada);
            this.Controls.Add(this.tgCon);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbJam);
            this.Controls.Add(this.tbNama);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(640, 37);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ToggleSwitch tgCon;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button3;
        private Guna.UI2.WinForms.Guna2TextBox tbJam;
        private Guna.UI2.WinForms.Guna2TextBox tbNama;
        private System.Windows.Forms.Label lbNada;
        private System.Windows.Forms.Button button1;
    }
}
