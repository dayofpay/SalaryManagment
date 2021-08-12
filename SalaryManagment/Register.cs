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
    public partial class Register : Form
    {
        private int viewMenu = 0;
        private bool stepOneCompleted = false;
        private bool stepTwoComplteted = false;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void openConnection_Click(object sender, EventArgs e)
        {
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBox1.Text != "" && guna2TextBox4.Text != "")
                {
                    stepOneCompleted = true;
                    statusLabel.Visible = true;
                    statusLabel.Text = "Стъпка 1 - Изпълнена !";
                    Properties.Settings.Default.server = guna2TextBox1.Text;
                    Properties.Settings.Default.port = guna2TextBox2.Text;
                    Properties.Settings.Default.password = guna2TextBox3.Text;
                    Properties.Settings.Default.username = guna2TextBox4.Text;
                    Properties.Settings.Default.Save();
                    StepTwo stepTwo = new StepTwo();
                    this.Hide();
                    stepTwo.ShowDialog();
                }
                else
                {
                    statusLabel.Visible = true;
                    statusLabel.Text = "Моля, попълнете всички полета !";
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException error)
            {
                statusLabel.Visible = true;
                statusLabel.Text = "Грешка !";
                MessageBox.Show(error.ToString());
            }
        }
    }
}