using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17Subtask1
{
    /// <summary>
    /// Это первый шаг создать общий интерфейс
    /// Общий интерфейс для всех аккаунтов
    /// </summary>
    public interface IAllAccounts
    {
        void CalculateInterest();
 
    }
}
