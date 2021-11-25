using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Andreyul Thau 1900");
            string stringulMieu = "Hi";
            string urmatorulString = "lume";

            string a = "a";
            string b = "b";
            
            int resultat = string.Compare(a, b);
            // daca resultat e -1 atunci a e in partea stanga a lui b, daca e 1 atunci e in partea dreapta, daca e 0 atunci sunt egale
            // string.compare are o a treia variabila care ignoreCase. By default e faulse, dar o putem seta pe true


            //string concat
            stringulMieu = stringulMieu + urmatorulString;
            string theUltimateString = string.Concat(stringulMieu, urmatorulString);

            Stopwatch stopWatch = Stopwatch.StartNew();
            stopWatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                stringulMieu += i;
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);

            Stopwatch stopWatchnou = Stopwatch.StartNew();
            stopWatchnou.Start();
            StringBuilder builder = new StringBuilder();
            builder.Append(stringulMieu);
            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);
            }
            stopWatchnou.Stop();
            Console.WriteLine(stopWatchnou.Elapsed);
        }
    }
}
