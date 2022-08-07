using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace P3
{
    class Program
    {
        static void Main()
        {
            int num, randomNumber;
            float totalTime;
   
            //타이머 인스턴스
            Stopwatch stopwatch = new Stopwatch();


            while (true)
            {
                //시작
                num = Start();

                //창리셋
                Clear();

                //입력받은 값 띄워주기
                Startint(num);

                //타이머 시작(리셋)
                stopwatch.Reset();
                stopwatch.Start();

                //랜덤숫자 뽑기
                randomNumber = RanNum(num);

                //키보드 입력받기
                ConsoleKeyInfo cki = ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.Y:
                        if (randomNumber % num == 0)//결과값이 참일때
                        {
                            stopwatch.Stop();
                            totalTime = stopwatch.ElapsedMilliseconds/1000;
                            TResult(totalTime);
                        }
                        else//결과값이 거짓일때
                        {
                            stopwatch.Stop();
                            FResult();
                            break;
                        }
                        break;

                    case ConsoleKey.N:
                        if (randomNumber % num == 0)//결과값이 거짓일때
                        {
                            stopwatch.Stop();
                            FResult();
                            break;
                        }
                        else//결과값이 참일때
                        {
                            stopwatch.Stop();
                            totalTime = stopwatch.ElapsedMilliseconds/1000;
                            TResult(totalTime);
                        }
                        break;

                    default:
                        WrongKey();
                        continue;
                }
                //재도전
                RTry();

                //키 입력받기
                cki = ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.Y:
                        Clear();
                        continue;

                    case ConsoleKey.N:
                        GameOver();
                        ReadKey();
                        return;

                    default:
                        WrongKey();
                        break;
                }
                ReadKey();
            }
        }





        //메소드 모음
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static int Start()
        {
            string num;
            int nnum;

            Write("숫자를 입력해주세요 : ");
            num = ReadLine();
            nnum = Convert.ToInt32(num);

            return nnum;
        }

        static void Startint(int startint)
        {
            Write("입력받은 숫자 : " + startint);
        }

        static int RanNum(int num)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            WriteLine("\n랜덤한 숫자 : " + randomNumber);
            WriteLine("\n입력한 숫자("+ num +")가 랜덤한 숫자("+ randomNumber +")의 배수입니까? : Y or N");

            return randomNumber;
        }

        static void TResult(float time)
        {
            WriteLine("\n정답입니다.");
            WriteLine("정답까지 걸린 시간 : " + time + "초");
        }

        static void FResult()
        {
            WriteLine("\n정답이 아닙니다.");
        }

        static void WrongKey()
        {
            WriteLine("\n잘못된 키를 입력하셨습니다.");
        }

        static void RTry()
        {
            WriteLine("\n계속 하시겠습니까? : Y or N");
        }

        static void GameOver()
        {
            WriteLine("\n게임이 종료됩니다.\n아무키나 눌러주세요");
        }
    }
}
