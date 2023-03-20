using Task17Subtask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task17Subtask1.InitalData;

namespace Task17Subtask1
{/// <summary>
/// Теперь можно без потерь разделить метод  CalculateInterest на обычный аккаунт
/// </summary>
    public class OrdinaryAccount : IAllAccounts
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Расчет процентной ставки обычного аккаунта по правилам банка ");
            Console.WriteLine("Подробная инструкция находится в class OrdinaryAccount");

            // Метод для расчета процентной ставки
            void CalculateInterest(Account account)
            {
                {
                    if (account.Type == "Обычный")
                    {
                        // расчет процентной ставки обычного аккаунта по правилам банка
                        account.Interest = account.Balance * 0.4;

                        if (account.Balance < 1000)
                            account.Interest -= account.Balance * 0.2;

                        if (account.Balance < 50000)
                            account.Interest -= account.Balance * 0.4;
                    }
                }
            }
        }
    }

}

