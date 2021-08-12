using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagment
{
    public partial class StepTwo : Form
    {
        public StepTwo()
        {
            InitializeComponent();
            CompanyDB.Connect();
        }

        private void StepTwo_Load(object sender, EventArgs e)
        {
            CompanyDB.Connect();
            var a = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM default_employeedata",CompanyDB.connection);
            a.ExecuteScalar();
            using (MySql.Data.MySqlClient.MySqlDataReader reader = a.ExecuteReader())
            {
                while (reader.Read())
                {
                    this.guna2DataGridView1.Rows.Add(reader.GetString(0), reader.GetString(5));
                }
            }
        }
    }
}
