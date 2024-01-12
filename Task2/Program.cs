using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n=Convert.ToInt32(Console.ReadLine());
            string ending;
            int N = n % 10;
            if (N == 1&&n!=11)
            {
                ending = "";
            }
            else if ((N > 1&&N <5) && (n > 19||n<11))
            {
                ending = "а";
            }
            else
            {
                ending = "ов";
            }
            Console.WriteLine("Девочка нашла "+n+" гриб"+ending);
            Console.ReadKey();
        }
    }
}
