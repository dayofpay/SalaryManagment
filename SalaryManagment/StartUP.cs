using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormAnimation;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;

namespace SalaryManagment
{
    public partial class StartUP : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        private string conString;
        public StartUP()
        {

            InitializeComponent();
            server = "localhost";
            database = "salarymanagment";
            user = "root";
            password = "";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);
        }

        private void StartUP_Load(object sender, EventArgs e)
        {
            versionLabel.Text = "Версия V." + Properties.Settings.Default.currentVersion;
            companyName.Text = Properties.Settings.Default.companyName;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            // MessageBox.Show("Този бутон е деактивиран по подразбиране, свържете се с работодателя си за повече информация", "Employee Manager " + API.currentVersion);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
