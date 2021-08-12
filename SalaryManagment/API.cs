using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagment
{
    class API
    {
        public static string monthNow;
        public static string yearNow;
        public string January { get; set; }
        public string February { get; set; }
        public string March { get; set; }
        public string April { get; set; }
        public string May { get; set; }
        public string June { get; set; }
        public string July { get; set; }
        public string August { get; set; }
        public string September { get; set; }
        public string October { get; set; }
        public string November { get; set; }
        public string December { get; set; }
        public string getMonth { get; set; }
        public string productInfo;
        public int totalCustomers { get; set; }
        public double monthlySalary { get; set; }
        public int totalEmployees { get; set; }
        public int avaragemonthlyIncome { get; set; }
        public string avgmonthMode { get; set; }
        public static int monthOne = 1982;
        public static int monthTwo = 2945;
        public static int monthThree = 4921;
        public static int monthFour = 1114;
        public static int monthFive = 5922;
        public static int monthSix = 982;
        public static int monthSeven = 1000;
        public static int monthEight = 1320;
        public static int monthNine = 1424;
        public static int monthTen = 1692;
        public static int monthEleven = 1141;
        public static int monthTwelve = 1412;
        public static string currentVersion = "V1.0";
        public static bool lastVersion = true;
        public static void SetMonth(int CurrentMonth)
        {
            if (CurrentMonth == 1)
            {
                monthNow = "January";
            }
            if (CurrentMonth == 2)
            {
                monthNow = "February";
            }
            if (CurrentMonth == 3)
            {
                monthNow = "March";
            }
            if (CurrentMonth == 4)
            {
                monthNow = "April";
            }
            if (CurrentMonth == 5)
            {
                monthNow = "May";
            }
            if (CurrentMonth == 6)
            {
                monthNow = "June";
            }
            if (CurrentMonth == 7)
            {
                monthNow = "July";
            }
            if (CurrentMonth == 8)
            {
                monthNow = "August";
            }
            if (CurrentMonth == 9)
            {
                monthNow = "September";
            }
            if (CurrentMonth == 10)
            {
                monthNow = "October";
            }
            if (CurrentMonth == 11)
            {
                monthNow = "November";
            }
            if (CurrentMonth == 12)
            {
                monthNow = "December";
            }
        }
    }
}