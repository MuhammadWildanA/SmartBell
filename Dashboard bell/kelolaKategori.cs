using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_bell
{
    public partial class kelolaKategori : Form
    {
        public string id;
        public kelolaKategori()
        {
            InitializeComponent();
        }

        private void kelolaKategori_Load(object sender, EventArgs e)
        {
            tampil();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void tampil()
        {
            try
            {
                //MessageBox.Show("Ini Muncul Saat Form dipanggil");

                koneksi.OpenConnection(); //ini membuka koneksi database

                //ini digunakan untuk mengambil data di tabel siswa

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM `kategori` WHERE `ID` NOT IN (31)", koneksi.conn);

                //membuat objek Dasa Set Baru
                DataSet ds = new DataSet();

                //ini digunakan untuk mengisi dataset dari Data Adapter
                da.Fill(ds);

                //Mengisi DataGrid Siswa dengan DataSet
                dg_kategori.DataSource = ds.Tables[0];
                dg_kategori.Columns["id"].Visible = false;
                koneksi.CloseConnection();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new dashboard().Show();
            this.Close();
        }

        private void Clear()
        {
            txtKategori.Text = "";

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            btnInsert.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            string[] jadwal = new string[] { "Jam Pertama", "Jam Kedua", "Jam Ketiga", "Jam Keempat", "Istirahat Pertama" ,"Jam Kelima", "Jam Keenam", "Istirahat Kedua", "Jam Ketujuh", "Jam Kedelapan", "Jam Kesembilan", "Jam Pulang" };
            int[] defaultIDringtone = new int[] {20,21,22,23,29,24,53,56,55,27,54,52 };
            string[] waktu = new string[] { "07:00", "07:45", "08:30", "09:15", "10:00", "10:15", "11:00", "11:45", "12:15", "13:00", "13:45", "14:30" };
            if (txtKategori.Text == null || txtKategori.Text == "") { MessageBox.Show("kategori kosong"); return; }
            try
            {

                btnInsert.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                koneksi.OpenConnection();

                // Validasi apakah kategori sudah ada
                string checkQuery = "SELECT COUNT(*) FROM kategori WHERE nama = ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, koneksi.conn))
                {
                    checkCmd.Parameters.AddWithValue("?", txtKategori.Text);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Nama kategori sudah ada, silakan gunakan nama lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Step 1: Insert the category and get its ID
                string categoryQuery = "INSERT INTO kategori (nama) VALUES (?)";
                using (OleDbCommand categoryCmd = new OleDbCommand(categoryQuery, koneksi.conn))
                {
                    // Use parameterized query
                    categoryCmd.Parameters.AddWithValue("?", txtKategori.Text);
                    categoryCmd.ExecuteNonQuery();
                }

                // Retrieve the ID of the newly inserted category
                string getIdQuery = "SELECT @@IDENTITY";
                int categoryId;
                using (OleDbCommand idCmd = new OleDbCommand(getIdQuery, koneksi.conn))
                {
                    categoryId = Convert.ToInt32(idCmd.ExecuteScalar());
                }

                for (int i = 1; i <= 7; i++)
                {
                    for(int j = 0; j < jadwal.Length; j++)
                    {
                        koneksi.OpenConnection();
                        string dayQuery = "INSERT INTO waktu (nama, waktu, id_hari, id_ringtone, id_kategori) VALUES (?, ?, ?, ?, ?)";
                        using (OleDbCommand dayCmd = new OleDbCommand(dayQuery, koneksi.conn))
                        {
                            // Use parameterized query
                            dayCmd.Parameters.AddWithValue("?", jadwal[j]);
                            dayCmd.Parameters.AddWithValue("?", DateTime.Parse(waktu[j]));
                            dayCmd.Parameters.AddWithValue("?", i);
                            dayCmd.Parameters.AddWithValue("?", defaultIDringtone[j]);
                            dayCmd.Parameters.AddWithValue("?", categoryId);
                            dayCmd.ExecuteNonQuery();
                        }
                        koneksi.CloseConnection();
                    }
                }

                MessageBox.Show("Berhasil Simpan Data Kategori dan Hari");
            }
            catch (Exception ex)
            {
                // Log the exception message for debugging
                MessageBox.Show("Tambah Data Gagal: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                koneksi.CloseConnection();
                btnInsert.Enabled = true;
            }

            // Call methods to display and clear data
            tampil();
            Clear();
        }

       


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtKategori.Text == null || txtKategori.Text == "") { MessageBox.Show("kategori kosong"); return; }
            try
            { 
                koneksi.OpenConnection();

                // Validasi apakah kategori dengan nama yang sama sudah ada, kecuali kategori dengan ID saat ini
                string checkQuery = "SELECT COUNT(*) FROM kategori WHERE nama = ? AND id <> ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, koneksi.conn))
                {
                    checkCmd.Parameters.AddWithValue("?", txtKategori.Text);
                    checkCmd.Parameters.AddWithValue("?", id); // Kategori ID saat ini
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Nama kategori sudah ada, silakan gunakan nama lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                String Queri = "UPDATE kategori SET nama = ? WHERE id = ?";
                OleDbCommand cmd = new OleDbCommand(Queri, koneksi.conn);
                cmd.Parameters.AddWithValue("?", txtKategori.Text);
                cmd.Parameters.AddWithValue("?", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Kategori");
                koneksi.CloseConnection();
                tampil();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Gagal" + ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin akan menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
            koneksi.OpenConnection();
            String Queri = "DELETE FROM kategori WHERE  `id`= ?";
            OleDbCommand cmd = new OleDbCommand(Queri, koneksi.conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Hapus Data Kategori");
            koneksi.CloseConnection();
            tampil();
            Clear();
            }
        }

        private void dg_kategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            btnInsert.Enabled = false;

            int baris = dg_kategori.CurrentCell.RowIndex;
            id = dg_kategori.Rows[baris].Cells[0].Value.ToString();
            txtKategori.Text = dg_kategori.Rows[baris].Cells[1].Value.ToString();
        }

        private void kelolaKategori_FormClosed(object sender, FormClosedEventArgs e)
        {
            new dashboard().Show();
        }

        private void dg_kategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
