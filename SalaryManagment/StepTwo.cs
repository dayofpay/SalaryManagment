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
        public static string firstName;
        public static string secondName;
        public static string thirdName;
        public static string egn;
        public static string phoneNum;
        public static string jobPosition;
        public static string monthlySalar;
        public static string pin;
        public static string employeeNum;
        public static string companyName;
        public StepTwo()
        {
            InitializeComponent();
            CompanyDB.Connect();
        }

        private void StepTwo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("[⚠] ВАЖНО СЪОБЩЕНИЕ !! \r\n ПЪЛНОТО РЕДАКТИРАНЕ НА ПЕРСОНАЛА СЕ НАСТРОЙВА СЛЕД КАТО ПРИКЛЮЧИТЕ С КОНФИГУРАЦИЯТА НА СОФУТЕРА !! ", "[⚠] SalaryManagment WARNING");
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
                        firstName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(1);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 1)
                    {
                        mainLabel.Text = secondState;
                        secondName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(2);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 2)
                    {
                        mainLabel.Text = thirdState;
                        thirdName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(3);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 3)
                    {
                        mainLabel.Text = fourthState;
                        egn = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(4);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 4)
                    {
                        mainLabel.Text = fifthState;
                        phoneNum = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(5);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 5)
                    {
                        mainLabel.Text = sithxState;
                        jobPosition = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(6);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 6)
                    {
                        mainLabel.Text = seventhState;
                        monthlySalar = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(7);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 7)
                    {
                        mainLabel.Text = eightState;
                        pin = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(8);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 8)
                    {
                        mainLabel.Text = ninethhState;
                        employeeNum = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(9);
statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 9)
                    {
                        mainLabel.Text = tenthstate;
                        companyName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(10);
                        EventHandler.stepsCompleted = true;
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (EventHandler.stepsCompleted == true)
            {
                try
                {
                    CompanyDB.Connect();
                    StepThree stepThree = new StepThree();
                    this.Hide();
                    stepThree.ShowDialog();
                }
                catch(MySql.Data.MySqlClient.MySqlException Error)
                {
                    MessageBox.Show("Изглежда, че имате грешка в конфигуририрането на MySQL Връзката : ", Error.Message);
                }
            }
        }
    }
}
