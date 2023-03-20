using Task17Subtask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using static Task17Subtask1.InitalData;

namespace Task17Subtask1
{/// <summary>
///  и зарплатный аккаунт
/// </summary>
    public class SalaryAccount : IAllAccounts
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Расчет процентной ставки зарплатного аккаунта по правилам банка");
            Console.WriteLine("Подробная инструкция находится в class SalaryAccount");

            // Метод для расчета процентной ставки
            void CalculateInterest(Account account)
            {
                if (account.Type == "Зарплатный")
                {
                    // расчет процентной ставк зарплатного аккаунта по правилам банка
                    account.Interest = account.Balance * 0.5;
                }
            }
        }
    }
}


