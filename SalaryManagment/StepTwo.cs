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
        private static int currentState = 0;
        private static string DefaultLog = firstState;
        private static string firstState = "Име: ";
        private static string secondState = "През име:";
        private static string thirdState = "Фамилия";
        private static string fourthState = "EGN:";
        private static string fifthState = "Тел. Номер:";
        private static string sithxState = "Позиция:";
        private static string seventhState = "Месечна заплата:";
        private static string eightState = "ПИН КОД:";
        private static string ninethhState = "Номер на служител:";
        private static string tenthstate = "Име на компания: ";
        public StepTwo()
        {
            InitializeComponent();
            CompanyDB.Connect();
        }

        private void StepTwo_Load(object sender, EventArgs e)
        {
            mainLabel.Text = firstState;
            CompanyDB.Connect();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (sourceBox.Text != "")
            {
                if(currentState >= 9)
                {
                    nextButton.Visible = true;
                }
                statusLabel.Visible = true;
                for (int defaultNum = 0; defaultNum < 1; defaultNum++)
                {
                    currentState++;
                }
                {
                    if (currentState == 0)
                    {
                        mainLabel.Text = firstState;
                        API.firstName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(1);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 1)
                    {
                        mainLabel.Text = secondState;
                        API.secondName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(2);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 2)
                    {
                        mainLabel.Text = thirdState;
                        API.thirdName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(3);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 3)
                    {
                        mainLabel.Text = fourthState;
                        API.egn = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(4);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 4)
                    {
                        mainLabel.Text = fifthState;
                        API.phoneNum = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(5);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 5)
                    {
                        mainLabel.Text = sithxState;
                        API.jobPosition = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(6);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 6)
                    {
                        mainLabel.Text = seventhState;
                        API.monthlySalar = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(7);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 7)
                    {
                        mainLabel.Text = eightState;
                        API.pin = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(8);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 8)
                    {
                        mainLabel.Text = ninethhState;
                        API.employeeNum = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(9);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 9)
                    {
                        mainLabel.Text = tenthstate;
                        API.companyName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(10);
statusLabel.Text = "Успешно !";
                    }
                }
            }
            else
            {
                statusLabel.Text = "Грешка !";
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
