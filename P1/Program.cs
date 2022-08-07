using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    class Program
    {
        static void Main()
        {
            WriteLine("Hello World\n\n");

            int i1 = 3;
            string s1 = "Hi";

            WriteLine("{0} {1}", i1, s1);
            WriteLine(i1 + " " + s1);
            WriteLine($"{i1} {s1}");

            ReadKey();
        }
    }
}
