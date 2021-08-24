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
        public static bool checkHandler = false;

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
        private static string elevenstate = "Собствени/к/ци";
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
        public static bool warned;
        public StepTwo()
        {
            InitializeComponent();
            CompanyDB.Connect();
        }

        private void StepTwo_Load(object sender, EventArgs e)
        {
            MessageBox.Show("[⚠] ВАЖНО СЪОБЩЕНИЕ !! \r\n ПЪЛНОТО РЕДАКТИРАНЕ НА ПЕРСОНАЛА СЕ НАСТРОЙВА СЛЕД КАТО ПРИКЛЮЧИТЕ С КОНФИГУРАЦИЯТА НА СОФУТЕРА !! ", "[⚠] SalaryManagment WARNING");
            firstLabel.Text = firstState;
            secondLabel.Text = secondState;
            thirdLabel.Text = thirdState;
            fourthLabel.Text = fourthState;
            fifthLabel.Text = fifthState;
            sixthLabel.Text = sithxState;
            seventhLabel.Text = seventhState;
            eightLabel.Text = eightState;
            ninethLabel.Text = ninethhState;
            tenthLabel.Text = tenthstate;
            CompanyDB.Connect();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (firstBox.Text != "" && secondbox.Text != "" && thirdBox.Text != "" && fourthBox.Text != "" && fifthBox.Text != "" &&sixthBox.Text !="" &&seventhBox.Text != "" &&eightBox.Text !="" && ninethBox.Text !="" && tenthBox.Text !="")
            {
                API.firstName = firstBox.Text;
                API.secondName = secondbox.Text;
                API.thirdName = thirdBox.Text;
                API.egn = fourthBox.Text;
                API.phoneNum = fifthBox.Text;
                API.jobPosition = sixthBox.Text;
                API.monthlySalar = seventhBox.Text;
                API.pin = eightBox.Text;
                API.employeeNum = ninethBox.Text;
                API.companyName = tenthBox.Text;
                EventHandler.stepsCompleted = true;
            }
            if (EventHandler.stepsCompleted == true)
            {
                try
                {
                    CompanyDB.Connect();
                    StepThree stepThree = new StepThree();
                    this.Hide();
                    stepThree.ShowDialog();
                }
                catch (MySql.Data.MySqlClient.MySqlException Error)
                {
                    MessageBox.Show("Изглежда, че имате грешка в конфигуририрането на MySQL Връзката : ", Error.Message);
                }
            }
            else
            {
                EventHandler.stepsCompleted = false;
                MessageBox.Show("Моля, попълнете всички полета !", "V-DEVS Softwares");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
        }

        private void tenthBox_TextChanged(object sender, EventArgs e)
        {
            if(warned == false)
            {
                Messages.LegalCharacters();
                warned = true;
            }
            warned = true;
        }
    }
}
