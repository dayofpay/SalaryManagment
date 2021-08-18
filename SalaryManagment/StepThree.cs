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
    public partial class StepThree : Form
    {
        public static int currentState = 2;
        private static string firstState = "Име на фирма:";
        private static string secondState = "ЕИК/ПИК:";
        private static string thirdState = "Дата на регистрация:";
        private static string fourthState = "Седалище адрес:";
        private static string fifthState = "Предмет на дейност:";
        private static string sithxState = "Правна форма:";
        private static string seventhState = "Капитал размер:";
        private static string eightState = "Регистрация по ЗДДС (ДА/НЕ):";
        public static string companyName = "";
        public static string eik = "";
        public static string dateofRegister = "";
        public static string adress = "";
        public static string baseActivity = "";
        public static string form = "";
        public static string capital = "";
        public static string register = "";
        public StepThree()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (EventHandler.stepsCompanyCompleted == true)
            {
                LicenseCheck licenseCheck = new LicenseCheck();
                licenseCheck.ShowDialog();
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            label1.Text = companyName;
            MessageBox.Show(currentState.ToString());
            if (sourceBox.Text != "")
            {
                if (currentState >= 7)
                {
                    nextButton.Visible = true;
                    EventHandler.stepsCompanyCompleted = true;
                }
                statusLabel.Visible = true;
                for (int defaultnum = 1; defaultnum < 1; defaultnum++)
                {
                    currentState++;
                }
                {
                    if (currentState == 2)
                    {
                        mainLabel.Text = firstState;
                        companyName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(1);
                        statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 3)
                    {
                        mainLabel.Text = secondState;
                        eik = sourceBox.Text;
                        companyName = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(2);
                        statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 4)
                    {
                        mainLabel.Text = thirdState;
                        dateofRegister = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(3);
                        statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 5)
                    {
                        mainLabel.Text = fourthState;
                        adress = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(4);
                        statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 6)
                    {
                        mainLabel.Text = fifthState;
                        baseActivity = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(5);
                        statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 7)
                    {
                        mainLabel.Text = sithxState;
                        form = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(6);
                        statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 8)
                    {
                        mainLabel.Text = seventhState;
                        capital = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(7);
                        statusLabel.Text = "Успешно !";
                    }
                    if (currentState == 9)
                    {
                        mainLabel.Text = eightState;
                        register = sourceBox.Text;
                        sourceBox.Clear();
                        EventHandler.OnSuccess(8);
                        statusLabel.Text = "Успешно !";
                    }
                }
            }
        }

        private void StepThree_Load(object sender, EventArgs e)
        {
            mainLabel.Text = firstState;
            CompanyDB.Connect();
        }

        private void sourceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
