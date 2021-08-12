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
            CompanyDB.ExampleConnection();
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (salaryComboBox.Text == "1 Месец")
            {
                using (MySqlCommand cmd3 = new MySqlCommand
("SELECT " + API.monthNow + " FROM reports_" + DateTime.Now.Year.ToString(), connection))
                {
                    using (MySqlDataReader reader3 = cmd3.ExecuteReader())
                    {
                        while (reader3.Read())
                        {
                            salaryAmmount.Text = reader3.GetString(0);
                        }
                    }
                }
            }
            avgIncome.Text = "Месечен Доход за 1 Месец";
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
