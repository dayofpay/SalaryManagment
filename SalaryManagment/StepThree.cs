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
        public static string ninethState = "Собственик/ци:";
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
            if (firstBox.Text != "" && secondbox.Text != "" && thirdBox.Text != "" && fourthBox.Text != "" && fifthBox.Text != "" && sixthBox.Text != "" && seventhBox.Text != "" && eightBox.Text != "" && ninethBox.Text != "")
            {
                CompanyDetails.companyName = firstBox.Text;
                CompanyDetails.eik = secondbox.Text;
                CompanyDetails.dateofRegister = thirdBox.Text;
                CompanyDetails.adress = fourthBox.Text;
                CompanyDetails.baseActivity = fifthBox.Text;
                CompanyDetails.form = sixthBox.Text;
                CompanyDetails.capital = seventhBox.Text;
                CompanyDetails.register = eightBox.Text;
                CompanyDetails.owners = ninethBox.Text;
                EventHandler.stepsCompanyCompleted = true;
            }
            if (EventHandler.stepsCompanyCompleted == true)
            {
                LicenseCheck licenseCheck = new LicenseCheck();
                licenseCheck.ShowDialog();
            }
            else
            {
                EventHandler.stepsCompleted = false;
                MessageBox.Show("Моля, попълнете всички полета !", "V-DEVS Softwares");
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
        }

        private void StepThree_Load(object sender, EventArgs e)
        {
            firstLabel.Text = firstState;
            secondLabel.Text = secondState;
            thirdLabel.Text = thirdState;
            fourthLabel.Text = fourthState;
            fifthLabel.Text = fifthState;
            sixthLabel.Text = sithxState;
            seventhLabel.Text = seventhState;
            eightLabel.Text = eightState;
            ninethLabel.Text = ninethState;
            CompanyDB.Connect();
        }

        private void sourceBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
