using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个数:");
            double x = Convert.ToDouble(Console.ReadLine());
            double t = x;
            double s = 0;
            double n = 2;
            while (Math.Abs(t) >= 1E-7)
            {
                s += t;
                t = (-1) * t * x * x / (n * (n + 1));
                n += 2;
            }
            Console.WriteLine("sin({0})={1}", x, s);
        }
    }
}
