using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст от 20 до 69 ");
            bool result = Int32.TryParse(Console.ReadLine(),out int x1);
            if (x1<20||x1>69||result==false)
            {
                Console.WriteLine("Не правильно введенные данные");
                Console.ReadKey();
                return;
            }
            string message="";
            int n1 = x1 / 10;
            switch (n1)
            {
                case 2:
                    message += "двадцать";
                    break;
                case 3:
                    message += "тридцать";
                    break;
                case 4:
                    message += "сорок";
                    break;
                case 5:
                    message += "пятьдесят";
                    break;
               default:
                    message += "шестьдесят";
                    break;
            }
            int n2 = x1 % 10;
            switch (n2)
            {
                case 1:
                    message += " один год";
                    break;
                case 2:
                    message += " два года";
                    break;
                case 3:
                    message += " три года";
                    break;
                case 4:
                    message += " четыре года";
                    break;
                case 5:
                    message += " пять лет";
                    break;
                case 6:
                    message += " шесть лет";
                    break;
                case 7:
                    message += " семь лет";
                    break;
                case 8:
                    message += " восемь лет";
                    break;
                case 9:
                    message += " девять лет";
                    break;
                default:
                    message += " лет";
                    break;
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
