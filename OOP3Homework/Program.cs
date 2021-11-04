using System;

namespace OOP3Homework
{
    public enum Type
    {
        Дебетовый,
        Кредитовый,
        Накопительный
    }
    class Program
    {
        static void Main(string[] args)
        {
            // создание списка счетов
            AccountList testList = new AccountList();

            //добавление счетов (сумма, тип) в список
            testList.AddItem(123456, Type.Дебетовый);
            testList.AddItem(1000, Type.Кредитовый);
            testList.AddItem(100000, Type.Накопительный);

            // вывод счетов на печать
            testList.PrinListAccounts();

            // перевод суммы между счетами
            testList.RemoveSum(1001, 1002, 10000);
            testList.RemoveSum(1001, 1003, 10000);




        }
    }
}
