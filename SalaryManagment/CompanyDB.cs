using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace SalaryManagment
{

    class CompanyDB
    {
        public static MySqlConnection connection { get; set; }
        public static string server { get; set; }
        public static string database { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
        public static string port { get; set; }
        public static string connectionString { get; set; }
        public static string sslM { get; set; }
        public static string conString { get; set; }
        public static void Connect()
        {
            server = "localhost";
            database = "salarymanagment";
            user = "root";
            password = "";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);
            connection.Open();
        }
        public static void ExampleConnection()
        {
            var readServer = Properties.Settings.Default.server;
            var readDB = Properties.Settings.Default.database;
            var readUser = Properties.Settings.Default.username;
            var readPassowrd = Properties.Settings.Default.password;
            var readPort = Properties.Settings.Default.port;
            var readSSL = Properties.Settings.Default.ssl;
            Properties.Settings.Default.Save();
            var exampleConnectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", readServer,readPort,readUser,readPassowrd,readDB,readSSL);
            var connectMe = new MySqlConnection(exampleConnectionString);
            connectMe.Open();
        }
    }
}
