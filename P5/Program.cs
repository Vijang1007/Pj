using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                string s1 = ReadLine();
                switch (s1)
                {
                    case "1":
                        for (int i = 0; i < 5; i++)
                        {
                            for (int x = 0; x <= i; x++)
                            {
                                Write("*");
                            }
                            WriteLine();
                        }
                        WriteLine();
                        break;

                    case "2":
                        for (int i = 0; i < 5; i++)
                        {
                            for (int x = 5; x > i; x--)
                            {
                                Write("*");
                            }
                            WriteLine();
                        }
                        WriteLine();
                        break;

                    case "3":
                        for (int i = 0; i < 5; i++)
                        {
                            for (int x = 4; x > i; x--)
                            {
                                Write(" ");
                            }
                            for (int x = 0; x <= i; x++)
                            {
                                Write("*");
                            }
                            WriteLine();
                        }
                        WriteLine();
                        break;

                    case "4":
                        for (int i = 0; i < 5; i++)
                        {
                            for (int x = 0; x < i; x++)
                            {
                                Write(" ");
                            }
                            for (int x = 5; x > i; x--)
                            {
                                Write("*");
                            }
                            WriteLine();
                        }
                        WriteLine();
                        break;

                    case "5":
                        for (int i = 0; i < 4; i++)
                        {
                            for (int x = 3; x > i; x--)
                            {
                                Write(" ");
                            }
                            for (int x = 0; x < (i * 2) + 1; x++)
                            {
                                Write("*");
                            }
                            WriteLine();
                        }
                        WriteLine();
                        break;

                    case "6":
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Write(" ");
                            }
                            for (int x = 4; x > i; x--)
                            {
                                Write("* ");
                            }
                            WriteLine();
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 2; j > i; j--)
                            {
                                Write(" ");
                            }
                            for (int x = 0; x < i + 2; x++)
                            {
                                Write("* ");
                            }
                            WriteLine();
                        }
                        break;

                    default:
                        return;
                }
            }
        }
    }
}
