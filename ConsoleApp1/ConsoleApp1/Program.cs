using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        private static object stopWatch;

        static void Main(string[] args)
        {
             Console.WriteLine("Hello World!");
            string myString ="Hello";

            string a = "B";
            string b = "b";
            string c = "c";

            int result = string.Compare(a, b, false);
            //returneaza -1 daca str1 e la stanga lui str 2; 0 egale; 1 altfel; alt 3-lea parametru - daca tine cont de litere mari si mici
            Console.WriteLine(result);

            //cocatenari
            myString = myString + " world";
            string helloWorld = myString + " ";
            //myString+=i
            StopWatch stopWatch = StopWatch.StartNew();
              for (int i=0;i<1000;i++)
            {
                myString += i;
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            //sau elapsedMilliseconds

            //StringBuilder lucreaza performant cu stringuri
            //CTRL+. -> aduce clase
            StopWatch stopWatch1 = StopWatch.StartNew();
            StringBuilder builder = new StringBuilder();
            builder.Append(myString);
            for (int i=0;i<1000;i++)
            {
                builder.Append(i);
            }
            stopWatch1.Stop();
            Console.WriteLine(stopWatch1.Elapsed);
        }
    }
}
