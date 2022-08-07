using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9
{
    class Program
    {
        static void Main()
        {
            List<string> myList = new List<string>();

            myList.Add("사과");
            myList.Add("배");
            myList.Add("수박");
            myList.Add("복숭아");
            myList.Add("포도");
            myList.RemoveAt(3);
            myList.Count();
            WriteLine(myList[0]);
            WriteLine(myList[2]);
            WriteLine(myList[3]);


            
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            myDict["수박"] = 1;
            myDict["배"] = 2;
            WriteLine(myDict["수박"]);
            WriteLine(myDict["배"]);



            ReadKey();
        }
    }
}
