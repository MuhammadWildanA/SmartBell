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
    public partial class dialogJadwal : Form
    {
        public event Action DataUpdated;
        private dashboard _dashboard;

        string sourceFilePath;
        string destinationFilePath;
        string fileName;
        string idRingtone;
        string getPath;
        public EventHandler update;
        public string idJadwal;
        public dialogJadwal(string id, dashboard dashboardInstance)
        {
            InitializeComponent();
            idJadwal = id;
            _dashboard = dashboardInstance;
            //MessageBox.Show(id);
        }

        private void dialogJadwal_Load(object sender, EventArgs e)
        {
            if (dashboard.conditionJadwal == false)
            {
            tampil();
                btnTambahData.Visible = false;
                return;
            }
            btnSimpan.Visible = false;

        }

        private void tampil()
        {
            try
            {

                koneksi.OpenConnection();

                OleDbDataAdapter da = new OleDbDataAdapter($"select waktu.id as id, waktu.nama, waktu.waktu, waktu.status, ringtone.id as id_ringtone,ringtone.path , ringtone.name as ringtone from waktu inner join ringtone on waktu.id_ringtone = ringtone.id where waktu.id = {idJadwal}", koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtNama.Text = ds.Tables[0].Rows[0]["nama"].ToString();
                    lblFile.Text = ds.Tables[0].Rows[0]["ringtone"].ToString();
                    idRingtone = ds.Tables[0].Rows[0]["id_ringtone"].ToString();
                    getPath = ds.Tables[0].Rows[0]["path"].ToString();
                    DateTime waktu;
                    if (!(DateTime.TryParse(ds.Tables[0].Rows[0]["waktu"].ToString(), out waktu)))
                    {
                        return;
                    }
                    txtWaktu.Text = waktu.ToString("HH:mm");
                }
                else
                {
                    txtNama.Text = "No data found";
                }



                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();

          //  new dashboard().test();
        }

        //for update statements
        private void btnSimpan_Click(object sender, EventArgs e)
        {

            //if(sourceFilePath == null) MessageBox.Show("kosong");
            // Normalize the input name (remove all spaces and convert to lowercase)
            string inputName = txtNama.Text.Replace(" ", "").ToLower();
            string inputWaktu = DateTime.Parse(txtWaktu.Text).ToString("HH:mm");

            // Check if the normalized name (without spaces) already exists in dashboard.dt
            foreach (DataRow row in dashboard.dt.Rows)
            {
                // Normalize the existing name (remove all spaces and convert to lowercase)
                string existingName = row["nama"].ToString().Replace(" ", "").ToLower();
                string existingWaktu = DateTime.Parse(row["waktu"].ToString()).ToString("HH:mm");
                if (existingName == inputName || existingWaktu == inputWaktu)
                {
                    MessageBox.Show("Error: Data dengan nama atau waktu yang sama sudah ada.");
                    return;
                }
            }

            try
            {
                koneksi.OpenConnection();
                int categoryId = 0;
                if (sourceFilePath != null)
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO ringtone (path,name) VALUES (?,?)", koneksi.conn);
                    command.Parameters.AddWithValue("?", destinationFilePath);
                    command.Parameters.AddWithValue("?", fileName);
                    command.ExecuteNonQuery();
                    File.Copy(sourceFilePath, Application.StartupPath + destinationFilePath);
                    string getIdQuery = "SELECT @@IDENTITY";
                    
                    using (OleDbCommand idCmd = new OleDbCommand(getIdQuery, koneksi.conn))
                    {
                        categoryId = Convert.ToInt32(idCmd.ExecuteScalar());
                    }
                }
                
                OleDbCommand cmd = new OleDbCommand($"UPDATE waktu SET nama = ?, waktu = ?{(sourceFilePath != null ? ", id_ringtone = ?" : "")} WHERE id = ?", koneksi.conn);

                cmd.Parameters.AddWithValue("?", txtNama.Text);
                cmd.Parameters.AddWithValue("?", DateTime.Parse(txtWaktu.Text));
                if (sourceFilePath != null)
                {
                    cmd.Parameters.AddWithValue("?", categoryId);
                }
                cmd.Parameters.AddWithValue("?", idJadwal);
                cmd.ExecuteNonQuery();
                koneksi.CloseConnection();

                if(sourceFilePath != null)
                {
                    koneksi.OpenConnection();
                    using (OleDbCommand dlt = new OleDbCommand("DELETE FROM ringtone WHERE id = ?", koneksi.conn))
                    {
                        dlt.Parameters.AddWithValue("?", idRingtone);
                        dlt.ExecuteNonQuery();
                        File.Delete(Application.StartupPath + getPath);
                    }
                    koneksi.CloseConnection();
                }
                DataUpdated?.Invoke();
                MessageBox.Show("Update Data Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ada error nih!" + ex);
            }
            finally
            {
                this.Close();
            }
           
        }

        //for insert statements
        private void btnTambahData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text) || !txtWaktu.MaskFull) { MessageBox.Show("nama jadwal atau waktu kosong"); return; }
            if (string.IsNullOrEmpty(fileName)) { MessageBox.Show("Pilih sound terlebih dahulu"); return; }

            // Normalize the input name (remove all spaces and convert to lowercase)
            string inputName = txtNama.Text.Replace(" ", "").ToLower();
            string inputWaktu = DateTime.Parse(txtWaktu.Text).ToString("HH:mm");

            // Check if the normalized name (without spaces) already exists in dashboard.dt
            foreach (DataRow row in dashboard.dt.Rows)
            {
                // Normalize the existing name (remove all spaces and convert to lowercase)
                string existingName = row["nama"].ToString().Replace(" ", "").ToLower();
                string existingWaktu = DateTime.Parse(row["waktu"].ToString()).ToString("HH:mm");
                if (existingName == inputName || existingWaktu == inputWaktu)
                {
                    MessageBox.Show("Error: Data dengan nama atau waktu yang sama sudah ada.");
                    return;
                }
            }

            try
            {
                koneksi.OpenConnection();
                OleDbCommand command = new OleDbCommand("INSERT INTO ringtone (path,name) VALUES (?,?)", koneksi.conn);
                command.Parameters.AddWithValue("?", destinationFilePath);
                command.Parameters.AddWithValue("?", fileName);
                command.ExecuteNonQuery();

                string getIdQuery = "SELECT @@IDENTITY";
                int categoryId;
                using (OleDbCommand idCmd = new OleDbCommand(getIdQuery, koneksi.conn))
                {
                    categoryId = Convert.ToInt32(idCmd.ExecuteScalar());
                }

                OleDbCommand cmd = new OleDbCommand("INSERT INTO waktu (nama, waktu, id_hari, id_ringtone, id_kategori) VALUES (?, ?, ?, ?, ?)", koneksi.conn);
                cmd.Parameters.AddWithValue("?", txtNama.Text);
                cmd.Parameters.AddWithValue("?", DateTime.Parse(txtWaktu.Text));
                cmd.Parameters.AddWithValue("?", dashboard.idHari);
                cmd.Parameters.AddWithValue("?", categoryId);
                cmd.Parameters.AddWithValue("?", dashboard.id);
                cmd.ExecuteNonQuery();



                koneksi.CloseConnection();
                File.Copy(sourceFilePath, Application.StartupPath + destinationFilePath);
                DataUpdated?.Invoke();
                MessageBox.Show("tambah data sukses");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file";
            openFileDialog.Filter = "Audio Files (*.mp3;*.wav)|*.mp3;*.wav";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mendapatkan path file yang dipilih
                sourceFilePath = openFileDialog.FileName;


                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceFilePath);
                // Tentukan folder tujuan
                string destinationFolder = @"\Resources\sound";

                // Pastikan folder tujuan ada
                if (!Directory.Exists(Application.StartupPath + destinationFolder))
                {
                    Directory.CreateDirectory(Application.StartupPath + destinationFolder);
                }

                // Tentukan path file tujuan
                destinationFilePath = Path.Combine(destinationFolder, uniqueFileName);
                lblFile.Text = Path.GetFileName(sourceFilePath);
                fileName = Path.GetFileName(sourceFilePath);
                
            }
        }
    }
}
