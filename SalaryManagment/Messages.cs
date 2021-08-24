using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagment
{
    class Messages
    {
        public static void LegalCharacters()
        {
            MessageBox.Show("[⚠] ВАЖНО СЪОБЩЕНИЕ !! \r\n МОЛЯ, НА ТОЗИ РЕД НЕ ИЗПОЛЗВАЙТЕ ЗНАЦИ КАТО @,№,!,% И Т.Н, В ПРОТИВЕН СЛУЧЕЙ Е ВЪЗМОЖНО ДА ПОЛУЧИТЕ ГРЕШКА ПРИ ЛИЦЕНЗИРАНЕТО ! ", "[⚠] SalaryManagment WARNING");
        }
    }
}
