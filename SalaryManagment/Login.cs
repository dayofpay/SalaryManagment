using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql;
using MySql.Data.MySqlClient;

namespace SalaryManagment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CompanyDB.DefaultConnection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            firmText.AppendText(Properties.Settings.Default.rememberCompany);
            numberTextBox.AppendText(Properties.Settings.Default.rememberEmployeeId);

            CompanyDB.DefaultConnection();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            CompanyDB.DefaultConnection();
            //var inval = int.Parse(numberTextBox.Text);
            //var convNum = Convert.ToInt32(inval);
            //var invalPin = int.Parse(pinCode.Text);
            //var convPin = Convert.ToInt32(invalPin);
            MySqlCommand myCMD = new MySqlCommand("SELECT * FROM " + firmText.Text + "_employeedata WHERE employeeNum = '" + numberTextBox.Text + "'" + "AND pin = '" + pinTextBox.Text + "'", CompanyDB.connection);
            MySqlDataReader myReader = myCMD.ExecuteReader();
            if (myReader.HasRows)
            {
                myReader.Read();
                statusLabel.Visible = true;
                statusLabel.Text = "Успешен вход, [" + myReader.GetString(5) + "] " + myReader.GetString(0);
                myReader.Close();
                continueButton.Visible = true;
                if(rememberCompany.Checked == true)
                {
                    Properties.Settings.Default.rememberCompany = firmText.Text;
                    Properties.Settings.Default.Save(); // <Settings.Default.HKEY_<bool:true> //
                }
                if (rememberEmployee.Checked == true)
                {
                    Properties.Settings.Default.rememberEmployeeId = numberTextBox.Text;
                    Properties.Settings.Default.Save(); // <Settings.Default.empId(string Empstr) //
                }
            }
            else
            {
                myReader.Close();
                statusLabel.Visible = true;
                statusLabel.Text = "Грешен ПИН или Номер на служител !";
                continueButton.Visible = false;
            }
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StartUP startUP = new StartUP();
            this.Hide();
            startUP.ShowDialog();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Main mainMenu = new Main();
            this.Hide();
            mainMenu.ShowDialog();
        }

        private void firmText_TextChanged(object sender, EventArgs e)
        {
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void rememberCompany_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

        }
    }
}
