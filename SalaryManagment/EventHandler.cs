using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagment
{
    class EventHandler
    {
        public static int GetParameterID;
        public static bool stepsCompleted = false;
        public static bool stepsCompanyCompleted = false;
        public static void OnSuccess(int stepInfo)
        {
            GetParameterID = stepInfo;
        }
        public static void EventOnLoad()
        {
        }
    }
}
