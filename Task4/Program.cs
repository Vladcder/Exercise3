using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число от 100 до 999 ");
            bool result = Int32.TryParse(Console.ReadLine(), out int x1);
            if (x1 < 100 || x1 > 999 || result == false)
            {
                Console.WriteLine("Не правильно введенные данные");
                Console.ReadKey();
                return;
            }
            string message = "";
            int n1 = x1 / 100;
            switch (n1)
            {
                case 1:
                    message += "сто";
                    break;
                case 2:
                    message += "двести";
                    break;
                case 3:
                    message += "триста";
                    break;
                case 4:
                    message += "четыреста";
                    break;
                case 5:
                    message += "пятьсот";
                    break;
                case 6:
                    message += "шестьсот";
                    break;
                case 7:
                    message += "семьсот";
                    break;
                case 8:
                    message += "восемьсот";
                    break;
                default:
                    message += "девятьсот";
                    break;             
            }
            int n2 = x1%100;
            if (n2>10&&n2<20)
            {
                switch (n2)
                {
                    case 11:
                        message += " одиннадцать";
                        break;
                    case 12:
                        message += " двенадцать";
                        break;
                    case 13:
                        message += " тринадцать";
                        break;
                    case 14:
                        message += " четырнадцать";
                        break;
                    case 15:
                        message += " пятнадцать";
                        break;
                    case 16:
                        message += " шестнадцать";
                        break;
                    case 17:
                        message += " семнадцать";
                        break;
                    case 18:
                        message += " восемнадцать";
                        break;
                    case 19:
                        message += " девятнадцать";
                        break;
                    default:
                        message += " ";
                        break;
                }
            }
            else
            {
                int n3 = n2 / 10;
                switch (n3)
                {
                    case 2:
                        message += " двадцать";
                        break;
                    case 3:
                        message += " тридцать";
                        break;
                    case 4:
                        message += " сорок";
                        break;
                    case 5:
                        message += " пятьдесят";
                        break;
                    case 6:
                        message += " шестьдесят";
                        break;
                    case 7:
                        message += " семьдесят";
                        break;
                    case 8:
                        message += " восемьдесят";
                        break;
                    case 9:
                        message += " девяносто";
                        break;
                    default:
                        message += "";
                        break;
                }
                int n4 = n3 % 10;
                switch (n4)
                {
                    case 1:
                        message += " один";
                        break;
                    case 2:
                        message += " два";
                        break;
                    case 3:
                        message += " три";
                        break;
                    case 4:
                        message += " четыре";
                        break;
                    case 5:
                        message += " пять";
                        break;
                    case 6:
                        message += " шесть";
                        break;
                    case 7:
                        message += " семь";
                        break;
                    case 8:
                        message += " восемь";
                        break;
                    case 9:
                        message += " девять";
                        break;
                    default:
                        message += "";
                        break;
                }
            }
          
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
