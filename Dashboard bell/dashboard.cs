using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Org.BouncyCastle.Asn1.Cmp;
using System.IO;
using WMPLib;
using System.Threading;

namespace Dashboard_bell
{
    public partial class dashboard : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public static string id;
        public static string idHari;
        public static string idHariSekarang;
        public static DataTable dt = new DataTable();
        DataTable dtmusic = new DataTable();
        public static bool conditionJadwal = true;
       
        public dashboard()
        {
            InitializeComponent();
            waktu1.Start();
        }
       
        private void dashboard_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true; // Enable scrolling
            flowLayoutPanel1.WrapContents = false; // Prevent wrapping, so controls flow in one direction
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown; // Controls flow from top to bottom
            flowLayoutPanel1.Controls.Clear();

            tampil(); // Mengisi ComboBox dengan data
        }

        public void tampil()
        {
            koneksi.OpenConnection();
            combokategori.SelectedIndexChanged -= combokategori_SelectedIndexChanged;
            comboHari.SelectedIndexChanged -= comboHari_SelectedIndexChanged;

            refreshEnv();

            OleDbDataAdapter adp2 = new OleDbDataAdapter("select * from kategori", koneksi.conn);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            combokategori.DataSource = dt2;
            combokategori.DisplayMember = "nama";
            combokategori.ValueMember = "id";
            //combokategori.Text = lastSelectedKategori;

            string lastSelectedCategory = Properties.Settings.Default.LastSelectedCategory;
            if (!string.IsNullOrEmpty(lastSelectedCategory))
            {
                combokategori.SelectedValue = lastSelectedCategory;
            }
            // combokategori.SelectedItem = 1;
            string selectedText = combokategori.Text;

            // Alternatively, if you want to directly get the "nama" field of the selected item:
            DataRowView selectedRow = combokategori.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                selectedText = selectedRow["nama"].ToString();
                id = combokategori.SelectedValue.ToString();
            }

            OleDbDataAdapter adp1 = new OleDbDataAdapter($"SELECT * FROM hari", koneksi.conn);
            DataTable dt1 = new DataTable();
            adp1.Fill(dt1);

            comboHari.DataSource = dt1;
            comboHari.DisplayMember = "hari";
            comboHari.ValueMember = "id";
            //comboHari.Text = "";
            comboHari.Enabled = true;

            // Set pilihan hari yang sekarang
            idHariSekarang = getHariSekarang();
            if (!string.IsNullOrEmpty(idHariSekarang))
            {
                comboHari.SelectedValue = idHariSekarang.ToString();
            }
            DataRowView selectedRowHari = comboHari.SelectedItem as DataRowView;
            if (selectedRowHari != null)
            {
                comboHari.Text = selectedRowHari["hari"].ToString();
                idHari = comboHari.SelectedValue.ToString();
            }
            //comboHari.Enabled = false;
            refresh();

            koneksi.CloseConnection();
            combokategori.SelectedIndexChanged += combokategori_SelectedIndexChanged;
            comboHari.SelectedIndexChanged += comboHari_SelectedIndexChanged;

            //btnTambahJadwal.Visible = false;
            
        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             
                if (combokategori.SelectedValue == null) { MessageBox.Show("value kategori = null"); return; }
                string idkategori = combokategori.SelectedValue.ToString();
                id = combokategori.SelectedValue.ToString();
                Properties.Settings.Default.LastSelectedCategory = combokategori.SelectedValue.ToString();
                Properties.Settings.Default.Save(); // Simpan perubahan

            refresh();
        }

        private void waktu1_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            dateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("id-ID"));

            
            if (dtmusic != null && dtmusic.Rows.Count > 0)
            {
                foreach (DataRow row in dtmusic.Rows)
                {
                    DateTime waktu;
                    if (DateTime.TryParse(row["waktu"].ToString(), out waktu))
                    {
                        if (waktu.ToString("HH:mm:ss") == timeNow.ToString("HH:mm:ss") && Convert.ToInt32(row["status"]) == 1)
                        {
                            play(Application.StartupPath + row["path"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal parsing waktu.");
                    }
                }
            }
            else
            {
                return;
            }

        }

        private void combokategori_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKelolaKategori_Click(object sender, EventArgs e)
        {
            new kelolaKategori().Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboHari_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTambahJadwal.Visible = true;
            // Pastikan untuk memeriksa apakah ada item yang dipilih
            if (comboHari.SelectedValue == null) { MessageBox.Show("value hari = null"); return; }
            idHari = comboHari.SelectedValue.ToString();
            //new testcoba().tampil();

            //if (ActiveMdiChild != null)
            //    ActiveMdiChild.Close();

            refresh();
           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var atrDataSekolah = new aturDataSekolah();
            atrDataSekolah.DataUpdated += DataSekolah_Update;
            atrDataSekolah.Show();
        }

       /* public void test()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panelJadwal.Visible = false;
            testcoba FormAktif = new testcoba();

            FormAktif.MdiParent = this;
            FormAktif.Show();
        }*/
        private void btnTambah_Click(object sender, EventArgs e)
        {
            //new dialogJadwal("1",this).Show();
            conditionJadwal = true;
            var dialog = new dialogJadwal("1", this);
            dialog.DataUpdated += Dialog_DataUpdated;
            dialog.Show();

        }

        public void refresh()
        {
            dt.Clear();
            flowLayoutPanel1.Controls.Clear();
            if (idHari != null)
            {
                koneksi.OpenConnection();

                OleDbDataAdapter adp = new OleDbDataAdapter($"select waktu.id as id, waktu.nama, waktu.waktu, waktu.status, ringtone.path, ringtone.name as ringtone from waktu inner join ringtone on waktu.id_ringtone = ringtone.id where id_hari = {idHari} and id_kategori = {id} ORDER BY waktu.id ASC", koneksi.conn);
                adp.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    flowLayoutPanel1.Controls.Add(new UserControl1(row["nama"].ToString(), row["waktu"].ToString(), row["ringtone"].ToString(), Convert.ToInt32(row["status"]), row["id"].ToString(), this, row["path"].ToString()));
                }
                koneksi.CloseConnection();

            }
            loadmusic();

        }
        //load bell berdasarkan hari
        public void loadmusic()
        {
            dtmusic.Clear();

            idHariSekarang = getHariSekarang();

            koneksi.OpenConnection();

            OleDbDataAdapter damusic = new OleDbDataAdapter($"select waktu.id as id, waktu.waktu, waktu.status, ringtone.path from waktu inner join ringtone on waktu.id_ringtone = ringtone.id where id_hari = {idHariSekarang} and id_kategori = {id}", koneksi.conn);
            damusic.Fill(dtmusic);

            if (dtmusic.Rows == null) { MessageBox.Show("data mosong"); };

            koneksi.CloseConnection();
        }

        public string getHariSekarang()
        {
            string hariSekarang = DateTime.Now.ToString("dddd", new CultureInfo("id-ID")).ToLower();
            string hariSekarangid;

            var hariMapping = new Dictionary<string, string>
            {
                { "senin", "1" },
                { "selasa", "2" },
                { "rabu", "3" },
                { "kamis", "4" },
                { "jumat", "5" },
                { "sabtu", "6" },
                { "minggu", "7" }
                // Tambahkan hari lainnya jika diperlukan
            };

            hariMapping.TryGetValue(hariSekarang, out hariSekarangid);
            return hariSekarangid;
        }

        public void refreshTg()
        {
            dt.Clear();
            if (idHari != null)
            {
                koneksi.OpenConnection();

                OleDbDataAdapter adp = new OleDbDataAdapter($"select waktu.id as id, waktu.nama, waktu.waktu, waktu.status, ringtone.path, ringtone.name as ringtone from waktu inner join ringtone on waktu.id_ringtone = ringtone.id where id_hari = {idHari} and id_kategori = {id} ORDER BY waktu.id ASC", koneksi.conn);
                adp.Fill(dt);

                koneksi.CloseConnection();

            }
        }

        public void refreshEnv()
        {
            OleDbDataAdapter adpEnv = new OleDbDataAdapter("select * from env", koneksi.conn);
            DataTable dtEnv = new DataTable();
            adpEnv.Fill(dtEnv);

            if (dtEnv.Rows.Count <= 0) { txtNamaSekolah.Text = "Nama Sekolah"; return; }
            txtNamaSekolah.Text = dtEnv.Rows[0]["nama_sekolah"].ToString();

            string pathLogo = Application.StartupPath + dtEnv.Rows[0]["path_logo"].ToString();


            if (File.Exists(pathLogo))
            {
                pbLogo.Image = Image.FromFile(pathLogo);
            }

        }

        private void DataSekolah_Update()
        {
            this.refreshEnv();
        }

        private void txtNamaSekolah_Click(object sender, EventArgs e)
        {
            var atrDataSekolah = new aturDataSekolah();
            atrDataSekolah.DataUpdated += DataSekolah_Update;
            atrDataSekolah.Show();
        }

        private void Dialog_DataUpdated()
        {
            refresh();
        }

        public void play(string url)
        {
            player.URL = Path.GetFullPath(url);
            if (player != null || !string.IsNullOrEmpty(player.URL))
            {
                player.controls.play();
                //MessageBox.Show(Path.GetFullPath(url));
            }
            else
            {
                MessageBox.Show("tidak bisa");
            }

        }

        
    }
}
