using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_bell
{
    public partial class aturDataSekolah : Form
    {
        public event Action DataUpdated;
        public string id;

        string sourceFilePath;
        string destinationFilePath;
        public aturDataSekolah()
        {
            InitializeComponent();
        }

        private void aturDataSekolah_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void tampil()
        {
            koneksi.OpenConnection();
            OleDbDataAdapter adpEnv = new OleDbDataAdapter("select * from env", koneksi.conn);
            DataTable dtEnv = new DataTable();
            adpEnv.Fill(dtEnv);

            if (dtEnv.Rows.Count <= 0) { tbNamaSekolah.Text = "Nama Sekolah"; return; }
            tbNamaSekolah.Text = dtEnv.Rows[0]["nama_sekolah"].ToString();
            id = dtEnv.Rows[0]["id"].ToString();

        }

        private void btnSimpanData_Click(object sender, EventArgs e)
        {
            bool sfp = false;
            if(tbNamaSekolah.Text == null || tbNamaSekolah.Text == "") { MessageBox.Show("nama sekolah tidak boleh kosong"); return; }
            try
            {
                koneksi.OpenConnection();
                String Queri = "UPDATE env SET nama_sekolah = ?";
                if (sourceFilePath != null)
                {
                    Queri += ", path_logo = ?";
                    sfp = true;
                }
                Queri += " WHERE id = ?";
                OleDbCommand cmd = new OleDbCommand(Queri, koneksi.conn);
                cmd.Parameters.AddWithValue("?", tbNamaSekolah.Text);
                if (sfp)
                {
                cmd.Parameters.AddWithValue("?", destinationFilePath);
                }
                cmd.Parameters.AddWithValue("?", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data");
                koneksi.CloseConnection();
                // Lakukan operasi lainnya sesuai kebutuhan
                // Misalnya menyalin file ke tujuan
                if(sfp)
                {
                    File.Copy(sourceFilePath, Application.StartupPath + destinationFilePath);
                }
                DataUpdated?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Gagal");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image file";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mendapatkan path file yang dipilih
                sourceFilePath = openFileDialog.FileName;

                pbLogo.Image = Image.FromFile(sourceFilePath);

                // Tentukan nama file yang unik
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceFilePath);

                // Tentukan folder tujuan
                string destinationFolder = @"\Resources\img"; 
                // Pastikan folder tujuan ada
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                // Tentukan path file tujuan
                destinationFilePath = Path.Combine(destinationFolder, uniqueFileName);
                lblFile.Text = Path.GetFileName(sourceFilePath);
            }
        }
    }
}
