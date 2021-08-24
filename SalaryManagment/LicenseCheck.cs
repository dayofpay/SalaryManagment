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
    public partial class LicenseCheck : Form
    {
        public static string licenseCode;
        public LicenseCheck()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            licenseCode = serial1.Text + serial2.Text + serial3.Text + serial4.Text;
            if (licenseCode == "1234123412341234")
            {
                try
                {
                    MessageBox.Show("Вие успешно потвърдихте своят лиценз, приятно използване на програмата :)", "V-DEVS.EU");
                    MySqlCommand myCMD = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_companydata" + " LIKE default_companydata", CompanyDB.connection);
                    MySqlCommand myCMD2 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_employeedata" + " LIKE default_employeedata", CompanyDB.connection);
                    MySqlCommand myCMD3 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_salarydata" + " LIKE default_salarydata", CompanyDB.connection);
                    MySqlCommand myCMD26 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_productdetails" + " LIKE default_productdetails", CompanyDB.connection);
                    MySqlCommand myCMD4 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2021" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD5 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2022" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD6 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2023" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD7 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2024" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD8 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2025" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD9 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2026" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD10 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2027" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD11 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2028" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD12 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2029" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD13 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_orders_2030" + " LIKE orders_2021", CompanyDB.connection);
                    MySqlCommand myCMD14 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2021" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD15 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2022" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD16 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2023" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD17 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2024" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD18 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2025" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD19 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2026" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD20 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2027" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD21 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2028" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD22 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2029" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD23 = new MySqlCommand("CREATE TABLE " + CompanyDetails.companyName + "_reports_2030" + " LIKE reports_2021", CompanyDB.connection);
                    MySqlCommand myCMD24 = new MySqlCommand("INSERT INTO " + CompanyDetails.companyName + "_employeedata(firstName,secondName,thirdName,EGN,phoneNumber,jobPosition,monthlySalary,penalties,pin,employeeNum,companyName)VALUES('" + API.firstName + "'" + "," + "'" + API.secondName + "'" + "," + "'" + API.thirdName + "'" + "," + "'" + API.egn + "'" + "," + "'" + API.phoneNum + "'" + "," + "'" + API.jobPosition + "'" + "," + "'" + API.monthlySalar + "'" + "," + "'" + "0" + "'" + "," + "'" + API.pin + "'" + "," + "'" + API.employeeNum + "'" + "," + "'" + API.companyName + "'" + ")", CompanyDB.connection);
                    MySqlCommand myCMD25 = new MySqlCommand("INSERT INTO " + CompanyDetails.companyName + "_companydata(companyName,companyRegisterDate,companyDescription,companyOwner,companyEmployees,companyAddress,companyBulStat)VALUES('" + CompanyDetails.companyName + "'" + "," + "'" + CompanyDetails.dateofRegister + "'" + "," + "'" + CompanyDetails.baseActivity + "'" + "," + "'" + CompanyDetails.owners + "'" + "," + "'" + "1" + "'" + "," + "'" + CompanyDetails.adress + "'" + "," + "'" + CompanyDetails.eik + "'" + ")", CompanyDB.connection);
                    myCMD.ExecuteScalar();
                    myCMD2.ExecuteScalar();
                    myCMD3.ExecuteScalar();
                    myCMD4.ExecuteScalar();
                    myCMD5.ExecuteScalar();
                    myCMD6.ExecuteScalar();
                    myCMD7.ExecuteScalar();
                    myCMD8.ExecuteScalar();
                    myCMD9.ExecuteScalar();
                    myCMD10.ExecuteScalar();
                    myCMD11.ExecuteScalar();
                    myCMD12.ExecuteScalar();
                    myCMD13.ExecuteScalar();
                    myCMD14.ExecuteScalar();
                    myCMD15.ExecuteScalar();
                    myCMD16.ExecuteScalar();
                    myCMD17.ExecuteScalar();
                    myCMD18.ExecuteScalar();
                    myCMD19.ExecuteScalar();
                    myCMD20.ExecuteScalar();
                    myCMD21.ExecuteScalar();
                    myCMD22.ExecuteScalar();
                    myCMD23.ExecuteScalar();
                    myCMD24.ExecuteScalar();
                    myCMD25.ExecuteScalar();
                    myCMD26.ExecuteScalar();
                    Properties.Settings.Default.companyName = CompanyDetails.companyName;
                }
                catch(MySqlException error)
                {
                    MessageBox.Show("Изглежда, че има грешка със MySQL връзката : " + error.Message);
                }
            }
            else
            {
                MessageBox.Show("Въвели сте грешен код !");
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LicenseCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
