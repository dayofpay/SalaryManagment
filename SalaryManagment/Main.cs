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

namespace SalaryManagment
{
    public partial class Main : Form
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
        public Main()
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

        private void Main_Load(object sender, EventArgs e)
        {
            API.GetAVGMonthly();
            salaryAmmount.Text = API.avgMonthly.ToString();
            companyStats.Text = "Отчет за фирма" + CompanyDetails.companyName + ": ";
            CompanyDB.Connect();
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void check_Click(object sender, EventArgs e)
        {
            var yr = year.Text;
            var mn = monthCheck.Text;
            var cmpn = Properties.Settings.Default.companyName;
            using (MySqlCommand cmd4 = new MySqlCommand
("SELECT " + "*" + " FROM " + cmpn + "_reports_" + yr + " WHERE " + mn, CompanyDB.connection))
            {
                using (MySqlDataReader reader4 = cmd4.ExecuteReader())
                {
                    while (reader4.Read())
                    {
                        salaryAmmount.Text = reader4.GetString(0);
                    }
                    reader4.Close();
                }
            }
        }
    }
}
