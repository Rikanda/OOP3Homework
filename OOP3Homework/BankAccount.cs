using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3Homework
{
    public class BankAccount
    {
        public int NumberAccount { get; set; }
        public double BalanceAccount { get; set; }
        public Type TypeAccount { get; set; }

        public BankAccount(int number, double balance, Type type)
        {
            NumberAccount = number;
            BalanceAccount = balance;
            TypeAccount = type;
        }



        public void AddToAccount(double summ)
        {
            this.BalanceAccount = BalanceAccount + summ;
            Console.WriteLine("Ваш счет " + this.NumberAccount+"  увеличен на " + summ + ", " +
                "общая сумма по счету теперь составляет " + this.BalanceAccount);
        }

        // добавлено: добавление снятием с другого счета
        public void AddToAccount(double summ, BankAccount b2)
        {
            b2.Withdraw(summ);
            if (summ<=b2.BalanceAccount)
            {
                this.AddToAccount(summ);
            }
           
        }

        // снятие со счета
        public void Withdraw(double summ)
        {
            if (summ > this.BalanceAccount)
            {
                Console.WriteLine("Снятие невозможно, поскольку запрошенная сумма больше остатка по счету " + this.NumberAccount);
               
            }
            else
            {
                this.BalanceAccount = BalanceAccount - summ;
                Console.WriteLine("Ваш счет "+ this.NumberAccount+" уменьшен на " + summ + ", " +
                "общая сумма по счету теперь составляет " + this.BalanceAccount);
            }
        }

        public void PrintAccountData()
        {
            Console.WriteLine("Номер счета: " + NumberAccount + "; Баланс счета: "
                + BalanceAccount + "; Тип счета: " + TypeAccount);
        }



    }
}
