using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите точку A ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точку B ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите точку C ");
            double c = Convert.ToDouble(Console.ReadLine());
            double absAB=Math.Abs(b-a);
            double absAC=Math.Abs(c-a);
            if (b==a||c==a)
            {
                Console.WriteLine("Одна из точек совпадает с точкой A");
            }
            if (absAB > absAC)
            {
                Console.WriteLine("Точка C расположена ближе к точке A");
            }
            else if (absAB < absAC) 
            {
                Console.WriteLine("Точка B расположена ближе к точке A");
            }
            else
            {
                Console.WriteLine("Точки B и С являются равноотстоящими от точки A");
            }
            Console.ReadKey();
        }
    }
}
