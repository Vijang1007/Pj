using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    class Program
    {
        static void Main()
        {
            int temp = 0;

            string[] name = new string[5];
            name[0] = "황수연";
            name[1] = "김동록";
            name[2] = "김동건";
            name[3] = "전지수";
            name[4] = "박태욱";

            char[] firstname = new char[5];
            char[] secondname = new char[5];
            char[] thirdname = new char[5];
            

            for (int i = 0;i < 5;i++)
            {
                char[] chName = name[i].ToCharArray();
                firstname[i] = chName[0];
                secondname[i] = chName[1];
                thirdname[i] = chName[2];
            }

            for (int i = 0; i < firstname.Length; i++)
            {
                int low = i;

                for (int j = i + 1; j < firstname.Length; j++)
                {
                    if (firstname[j] < firstname[low])
                    {
                        low = j;
                    }
                    temp = firstname[low];
                    firstname[low] = firstname[i];
                    firstname[i] = (char)temp;
                    if (firstname[j] == firstname[low])
                    {

                        temp = secondname[low];
                        secondname[low] = secondname[i];
                        secondname[i] = (char)temp;
                        if (secondname[j] == secondname[low])
                        {

                            temp = thirdname[low];
                            thirdname[low] = thirdname[i];
                            thirdname[i] = (char)temp;
                        }
                    }

                }
            }
            //출력

            for (int i = 0; i < 5; i++)
            {
                Write(firstname[i]);
                Write(secondname[i]);
                Write(thirdname[i]);
                WriteLine();
            }

            ReadKey();






            //비교


            /*
            1.이름을 받아오고
            2.이름의 첫번째글자 비교(순서대로 바꾸기)
            3.만약 이름의 첫번째 글자가 같은것만 2번째로 넘어가서 비교
            4.만약 두번째 글자가 같은것만 3번째로 넘어가서 비교
            5.이름을 받아온것을 WL
            */ 
        }
    }
}
