using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            // тест метода
            Console.WriteLine("Введите любой текст: ");
            string test = Console.ReadLine();
            Console.WriteLine(Invers(test));
            
            
        }

        public static string Invers(string text)
        {
            string invers = "";
            string word;
            for(int i=(text.Length-1); i>=0; i--)
            {
                word = text[i].ToString();
                invers += word;

            }
            return invers;
        }
    }
}
