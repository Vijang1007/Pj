using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main()
        {
            MakeStar2();

            ReadKey();
        }
        static void MakeStar()
        {
            //별을 그릴수 있는 최대 범위
            int Limit = 5;

            //for문을 사용하여 출력방식을 만들기
            for(int i = 0; i < Limit; i++)
            {
                for(int n = 5; n > i; n--)
                {
                    //별그리기
                    Write("*");
                }
                for (int n = 0; n < i * 2; n++)
                {
                    //빈공간
                    Write(" ");
                }
                for (int n = 5; n > i; n--)
                {
                    //별그리기
                    Write("*");
                }
                //줄바꿈
                WriteLine();
            }
        }
        static void MakeStar2()
        {
            int t = 5;

            for (int n = 0; n < 5; n++)
            {
                for (int i = 5; i > n; i--)
                {
                    Write("*");
                }
                WriteLine();
            }         
            for (int n = 0; n < 5; n++ ,t = t - 5 + n)
            {
                for (int i = 5; i > n; i--,t++)
                {
                    SetCursorPosition(t, n);
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}
