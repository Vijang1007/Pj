using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10
{
    class Program
    {
        static void Main()
        {
            int a = 3, b = 4;
            int re;

            Add(a, b,out re);
            Swap(ref a, ref b);

            WriteLine(re);
            WriteLine(a);
            WriteLine(b);

            ReadKey();
        }

        static void Add(int a, int b, out int result)
        {
            result = a + b;
        }

        static void Swap(ref int n1, ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
