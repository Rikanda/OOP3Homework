using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Homework
{
    public class AccountList
    {
        // список счетов
        public List<BankAccount> BankAccounts { get; set; }

        // конструктор
        public AccountList()
            {
            BankAccounts = new List<BankAccount>();
            }

        // переменная хранящая последнее значение счета, на старте 1000
        private static int lastnumber = 1000;
        
        // создание и добавление нового счета в список
        public void AddItem(double newvalue, Type newtype)
        {
            int newnumber = ++lastnumber;
            lastnumber = newnumber;
            var newBankAccount = new BankAccount(newnumber, newvalue, newtype);
            BankAccounts.Add(newBankAccount);
            

        }

        // перемещение денег между счетами по номеру счетов
        public void RemoveSum(int num1, int num2, double summa)
        {
            
                var b1 = this.SearchAccount(num1);
                var b2 = this.SearchAccount(num2);
                b1.AddToAccount(summa, b2);

            

        }


        // печать всех счетов

        public void PrinListAccounts()
        {
            foreach(BankAccount acc in BankAccounts)
            {
                acc.PrintAccountData();
            }
        }


        // поиск счета по номеру

        public BankAccount SearchAccount(int num)
        {
            foreach(BankAccount acc in BankAccounts)
            {
                if (acc.NumberAccount == num)
                    return acc;
            }
            return null;
        }

    }
}
