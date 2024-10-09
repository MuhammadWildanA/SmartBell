using System;
using System.Data.OleDb;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace Dashboard_bell
{
    public partial class licence : Form
    {
        public licence()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void licence_Load(object sender, EventArgs e)
        {
            tbSerialNumber.Text = "";
        }

        private string GetMotherboardId()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                foreach (ManagementObject wmi_MB in searcher.Get())
                {
                    string product = wmi_MB["Product"]?.ToString();  // Nama atau model motherboard
                    string manufacturer = wmi_MB["Manufacturer"]?.ToString();  // Nama pabrikan motherboard

                    if (!string.IsNullOrEmpty(product) && !string.IsNullOrEmpty(manufacturer))
                    {
                        return manufacturer + product;
                    }
                    else
                    {
                        MessageBox.Show("Motherboard ID tidak tersedia atau kosong.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mengambil ID motherboard: " + ex.Message);
            }
            return string.Empty;
        }

        private string GetHardDiskId()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                foreach (ManagementObject wmi_HD in searcher.Get())
                {
                    return wmi_HD["SerialNumber"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error mengambil ID hard disk: " + ex.Message);
            }
            return string.Empty;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tbSerialNumber.Text = generateSerialNumber();

            if (!string.IsNullOrEmpty(tbSerialNumber.Text))
            {
                tbKey.Enabled = true;
                btnActive.Enabled = true;
            }
        }

        private string generateSerialNumber()
        {
            string motherBoardID = GetMotherboardId();
            string hardiskID = GetHardDiskId();

            // Jika salah satu ID kosong, tampilkan pesan error
            if (string.IsNullOrEmpty(motherBoardID) || string.IsNullOrEmpty(hardiskID))
            {
                MessageBox.Show("Motherboard ID atau Hard Disk ID tidak tersedia.");
                return string.Empty;
            }

            // Gabungkan ID motherboard dan hard disk dengan tanda |  | di antaranya
            string combinedID = motherBoardID + "|bell|" + hardiskID;

            // Balik string hasil gabungan
            char[] charArray = combinedID.ToCharArray();
            Array.Reverse(charArray);
            string reversedID = new string(charArray);

            // Ubah reversedID menjadi byte array
            byte[] bytes = Encoding.UTF8.GetBytes(reversedID);

            // Encode byte array ke Base64
            string serialNumber = Convert.ToBase64String(bytes);

            // Tampilkan hasil di TextBox Serial Number
            return serialNumber;
        }
        private string generateKey()
        {
            // Dapatkan Motherboard ID dan Hard Disk ID
            string motherBoardID = GetMotherboardId();
            string hardiskID = GetHardDiskId();

            // Jika salah satu ID kosong, tampilkan pesan error
            if (string.IsNullOrEmpty(motherBoardID) || string.IsNullOrEmpty(hardiskID))
            {
                MessageBox.Show("Motherboard ID atau Hard Disk ID tidak tersedia.");
                return string.Empty;
            }

            // Gabungkan ID motherboard dan hard disk dengan tanda |  | di antaranya
            string combinedID = motherBoardID + "|smartbell|" + hardiskID;

            // Balik string hasil gabungan
            char[] charArray = combinedID.ToCharArray();
            Array.Reverse(charArray);
            string reversedID = new string(charArray);

            // Ubah reversedID menjadi byte array
            byte[] bytes = Encoding.UTF8.GetBytes(reversedID);

            // Encode byte array ke Base64
            string key = Convert.ToBase64String(bytes);
            return key;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            string inputKey = tbKey.Text;
            try
            {
                koneksi.OpenConnection();

                string key = generateKey();

                if(inputKey != key) { MessageBox.Show("key tidak valid"); return; }

                string query = "INSERT INTO token (token) VALUES (?)";
                OleDbCommand command = new OleDbCommand(query, koneksi.conn);
                command.Parameters.AddWithValue("?", inputKey);
                command.ExecuteNonQuery();

                koneksi.CloseConnection();
                MessageBox.Show("Aplikasi telah diaktivasi!, jika aplikasi tertutup silahkan buka kembali", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tutup form activate dan buka form dashboard
                this.Hide();  // Sembunyikan form activate

                // Buka form dashboard
                dashboard dashboardForm = new dashboard();
                dashboardForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("gagal menyimpan key" + ex);
            }
        }

        public int verifyKey()
        {
            string key = generateKey();

            koneksi.OpenConnection();
            try
            {
                // Query untuk mengambil data dari kolom 'token' di tabel 'token'
                string query = "SELECT token FROM token";

                // Membuat command untuk menjalankan query
                OleDbCommand cmd = new OleDbCommand(query, koneksi.conn);

                // Membaca hasil query
                OleDbDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows) { return 0; }
                while (reader.Read())
                {
                    // Mendapatkan nilai dari kolom 'token'
                    string tokenValue = reader["token"].ToString();

                    if (key != tokenValue) { MessageBox.Show("Licence Key tidak valid"); return 1; }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                // Menutup koneksi ke database
                koneksi.CloseConnection();
            }
            return 2;
        }
    }


}
