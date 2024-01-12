using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату прямоугольника x1 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату прямоугольника y1 ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату прямоугольника x2 ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату прямоугольника y2 ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату прямоугольника x3 ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату прямоугольника y3 ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4=0, y4=0;
            if (x1 == x2 && y1 == y2 || x1 == x3 && y1 == y3||x2==x3&&y2==y3) 
            {
                Console.WriteLine("Стороны прямоугольника не параллельны осям ");
                Console.ReadKey();
                return;
            }
            if (x1==x2)
            {
                if (y1==y3)
                {
                    x4 = x3;
                    y4 = y2;
                }
                else if (y2==y3)
                {
                    x4 = x3;
                    y4 = y1;
                }
                else
                {
                    Console.WriteLine("Стороны прямоугольника не параллельны осям ");
                    Console.ReadKey();
                    return;
                }

            }
            else if (x2 ==x3)
            {
                if (y3 == y1)
                {
                    x4 = x1;
                    y4 = y2;
                }
                else if (y2 == y1)
                {
                    x4 = x1;
                    y4 = y3;
                }
                else
                {
                    Console.WriteLine("Стороны прямоугольника не параллельны осям ");
                    Console.ReadKey();
                    return;
                }
            }
            else if (x1 == x3)
            {
                if (y3 == y2)
                {
                    x4 = x2;
                    y4 = y1;
                }
                else if (y1 == y2)
                {
                    x4 = x2;
                    y4 = y3;
                }
                else
                {
                    Console.WriteLine("Стороны прямоугольника не параллельны осям ");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Стороны прямоугольника не параллельны осям ");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("x4="+x4+", y4="+y4);

            Console.ReadKey();
        }
    }
}
