using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа по расчету суммы вух чисел");
            Console.WriteLine("введите первое число");
            int  a = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int b = int.Parse(Console.ReadLine());
            int c = a - b;
            Console.WriteLine("сумма двух чисел равна" + c);
        }
    }
}
