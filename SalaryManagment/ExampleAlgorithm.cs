using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagment
{
    class ExampleAlgorithm
    {
        public static void GetExample()
        {
            CompanyDB.Connect();
            API api = new API();
            api.January = "1";
            api.February = "2";
            api.March = "3";
            api.April = "4";
            api.May = "5";
            api.June = "6";
            api.July = "7";
            api.August = "8";
            api.September = "9";
            api.October = "10";
            api.November = "11";
            api.December = "12";
            var GetTime = DateTime.Today.Month.ToString();
            var cvl = int.Parse(GetTime.ToString());
            var cv = Convert.ToInt32(cvl);
            API.SetMonth(cv);
            var Monthly = new int[] { API.monthOne, API.monthTwo, API.monthThree, API.monthFour, API.monthFive, API.monthSix, API.monthSeven, API.monthEight, API.monthNine, API.monthTen, API.monthEleven, API.monthTwelve };
            double avg = Queryable.Average(Monthly.AsQueryable());
            double getResult = Math.Round(avg);
            double yearly = API.monthOne + API.monthTwo + API.monthThree + API.monthFour + API.monthFive + API.monthSix + API.monthSeven + API.monthEight + API.monthNine + API.monthTen + API.monthEleven + API.monthTwelve;
            double getYear = Math.Round(yearly);
            api.monthlySalary = 5691.2;
            api.totalEmployees = 14;
            api.totalCustomers = 1984;
            // salaryAmmount.Text = getResult + " BGN";
            // totaEmployees.Text = api.totalEmployees.ToString();
            // totaCustomers.Text = api.totalCustomers.ToString();
            // try
            {
                //   Properties.Settings.Default.server =// serverBox.Text; // Връща ТИП: [Стринг] от Property Value(server) //
                //  Properties.Settings.Default.database = //databaseBox.Text; // Връща ТИП: [Стринг] от Property Value(database) //
                // Properties.Settings.Default.port = //portBox.Text; // Връща ТИП: [INT] от Property Value(port) //
                // Properties.Settings.Default.ssl = //sslBox.Text; // Връща ТИП: [Стринг] от Property Value(SSLM) //
                //Properties.Settings.Default.password = //passwordBox.Text; // Връща ТИП: [Стринг] от Property Value(password) //
                //Properties.Settings.Default.username = //userBox.Text; // Връща ТИП: [Стринг] от Property Value(username) //
                //Properties.Settings.Default.Save(); // Запазва зададената стойност от Class{Register.CS} //
                //CompanyDB.ExampleConnection(); // Правим опит за връзка към сървъра със зададените от потребителя данни  //
                //}
                //  catch (MySql.Data.MySqlClient.MySqlException error) // Функцията се задейства при открита грешка със свързването към сървъра //
                {
                    //MessageBox.Show(error.ToString(), "Грешка със MySql Connection");
                }
            }
        }

    }
}
