using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_bell
{
    internal class koneksi
    {
        public static string path = System.IO.Path.Combine(Application.StartupPath, "db\\");
        public static OleDbConnection conn = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "smartBell.accdb");

        public static void OpenConnection()
        {
            //  MessageBox.Show("Database Path: " + pathdb + "optikrangga.accdb");

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
