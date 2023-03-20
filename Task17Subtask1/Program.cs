using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task17Subtask1;
using System;


namespace Task17Subtask1
{/// <summary>
/// За счет использования принципа open/close можно без припятствий добавлять и другие аккаунты для рассчетов
/// без нарушения и корректировки исходных данных
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var initalData = new InitalData();

            // аккаунт с обычным типом
            initalData.PerformAccount(new OrdinaryAccount());
            Console.WriteLine();

            // аккаунт с зарплатным типом
            initalData.PerformAccount(new SalaryAccount());
            Console.WriteLine();
        }
    }
}