using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task17Subtask1;

namespace Task17Subtask1;
/// <summary>
/// Данный класс храниит исходные данные 
/// Что бы разделить тело метода  CalculateInterest без потери работы функционала использывал принцип open/close principle
/// </summary>
class InitalData
{
     public class Account
     {
    // тип учетной записи
     public string Type { get; set; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }
    }
    // public static class Calculator
    // {
    // Метод для расчета процентной ставки
    // public static void CalculateInterest(Account account)
    //  {
    //  if (account.Type == "Обычный")
    //  {
    // расчет процентной ставки обычного аккаунта по правилам банка
    // account.Interest = account.Balance * 0.4;

    //  if (account.Balance < 1000)
    //     account.Interest -= account.Balance * 0.2;

    // if (account.Balance < 50000)
    //   account.Interest -= account.Balance * 0.4;
    // }
    // else if (account.Type == "Зарплатный")
    // {
    // расчет процентной ставк зарплатного аккаунта по правилам банка
    //account.Interest = account.Balance * 0.5;
    // }
    //}
    //}
    public void PerformAccount(IAllAccounts allAccounts)
    {
        allAccounts.CalculateInterest();
    }
}
