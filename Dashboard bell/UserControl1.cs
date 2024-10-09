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
    public partial class UserControl1 : UserControl
    {
        string namaJadwal;
        string jamJadwal;
        string laguJadwal;
        int conditionJadwal;
        public string idJadwal;
        string filepath;

        private dashboard _dashboard;

        //mengambil file dashboard
        //public static Form ParentFormReference { get; set; }

        public UserControl1(string nama, string jam, string lagu, int condition, string id, dashboard dashboardInstance, string path)
        {
            InitializeComponent();
            

            tbNama.Text = nama;
            tbJam.Text = DateTime.Parse(jam).ToString("HH:mm");
            lbNada.Text = lagu;
            idJadwal = id;
            _dashboard = dashboardInstance;
            filepath = path;
            if (condition == 0){tgCon.Checked = false;}
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dashboard.conditionJadwal = false;
            var dialog = new dialogJadwal(idJadwal, _dashboard);
            dialog.DataUpdated += Dialog_DataUpdated;
            dialog.Show();
            //new dialogJadwal(idJadwal, _dashboard).Show();
            //_dashboard.Refresh();
            //if (ParentFormReference != null)
            //{
            //    ParentFormReference.Hide();
            //}

        }

        private void Dialog_DataUpdated()
        {
            _dashboard.refresh();
        }

        private void tgCon_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!tgCon.Checked)
                {
                    koneksi.OpenConnection();
                    String Queri = "UPDATE waktu SET status = ? WHERE  `id`= ?";
                    OleDbCommand cmd = new OleDbCommand(Queri, koneksi.conn);
                    cmd.Parameters.AddWithValue("?", 0);
                    cmd.Parameters.AddWithValue("?", idJadwal);
                    cmd.ExecuteNonQuery();
                    koneksi.CloseConnection();
                }
                else
                {
                    koneksi.OpenConnection();
                    String qury = "UPDATE waktu SET status = ? WHERE  `id`= ?";
                    OleDbCommand cmdd = new OleDbCommand(qury, koneksi.conn);
                    cmdd.Parameters.AddWithValue("?", 1);
                    cmdd.Parameters.AddWithValue("?", idJadwal);
                    cmdd.ExecuteNonQuery();
                    koneksi.CloseConnection();
                }
            }catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        // for delete statements
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin akan menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) { return; }
            try
            {
                // Membuka koneksi
                koneksi.OpenConnection();

                // Hapus data dari tabel 'waktu'
                string deleteWaktuQuery = "DELETE FROM waktu WHERE `id`= ?";
                OleDbCommand cmdWaktu = new OleDbCommand(deleteWaktuQuery, koneksi.conn);
                cmdWaktu.Parameters.AddWithValue("?", idJadwal);
                cmdWaktu.ExecuteNonQuery();

                // Hapus data dari tabel 'ringtone' jika filepath bukan dari 'Default'
                //if (!filepath.StartsWith(@"Resources\sound\Default"))
                //{
                //    string deleteRingtoneQuery = "DELETE FROM ringtone WHERE `path` = ?";
                //    OleDbCommand cmdRingtone = new OleDbCommand(deleteRingtoneQuery, koneksi.conn);
                //    cmdRingtone.Parameters.AddWithValue("?", filepath);
                //    cmdRingtone.ExecuteNonQuery();

                //    // Menggabungkan path dan menghapus file
                //    string fileToDelete = Path.Combine(Application.StartupPath, filepath);
                //    if (File.Exists(fileToDelete))
                //    {
                //        File.Delete(fileToDelete);
                //    }
                //    else
                //    {
                //        MessageBox.Show("File tidak ditemukan: " + fileToDelete);
                //    }
                //}
                string fullFilePath = Application.StartupPath + filepath;
                if (!fullFilePath.StartsWith(Path.Combine(Application.StartupPath, @"Resources\sound\Default")))
                {
                    OleDbCommand command = new OleDbCommand("DELETE FROM ringtone WHERE path = ?", koneksi.conn);
                    command.Parameters.AddWithValue("?", filepath);
                    command.ExecuteNonQuery();

                    File.Delete(Application.StartupPath + filepath);
                }

                MessageBox.Show("Berhasil Hapus Data jadwal");
                _dashboard.refresh();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi kesalahan
                MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Pastikan koneksi ditutup, baik terjadi error ataupun tidak
                koneksi.CloseConnection();
            }

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string fullFilePath = Application.StartupPath + filepath;
            if(!File.Exists(fullFilePath)) { MessageBox.Show("tidak dapat menemukan file"); return; }
            _dashboard.play(fullFilePath);
        }

        private void tgCon_Click(object sender, EventArgs e)
        {
            _dashboard.refreshTg();
        }

        private void tbJam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
