using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        //이벤트는 전방선언
        public static event Action myOwnAction;
        static void Main()
        {
            while(true)
            {
                string s1 = ReadLine();

                switch (s1)
                {
                    case "1":
                        myOwnAction += One;
                        break;
                    case "2":
                        myOwnAction += Two;
                        break;
                    case "3":
                        myOwnAction += Three;
                        break;
                    case "4":
                        myOwnAction?.Invoke();
                        break;
                    case "5":  //스택으로 나중에 넣은것이 먼저 빠짐
                        myOwnAction -= Three;
                        break;
                    default:
                        break;
                }
                if(s1 == "n")
                {
                    break;
                }
            }          
            ReadKey();
        }


        static void One()
        {
            WriteLine("hi world");
        }

        static void Two()
        {
            WriteLine("hello world");
        }

        static void Three()
        {
            WriteLine("안녕");
        }


        /*
        액션 사용법(Action<T> 이름)
        public class ClassA
        {
            public event Action<string> OnAdd;
            
            private void SomethingHappened()
            {
                OnAdd?.Invoke("It Happened");
            }
        }

        public class ClassB
        {

            public ClassB()
            {
                var myClass = new ClassA();
                myClass.OnAdd += Add;
                myClass.OnAdd += Add;
                myClass.OnAdd += Add;
                myClass.OnAdd += Add;
            }

            private void Add(string Input)
            {
                //do Something
            }
        }
        */
    }
}
