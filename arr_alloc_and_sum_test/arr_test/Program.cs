using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace arr_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var a = new List<long>();

            for (var i = 0; i < 20000000; i++){
                a.Add(i);
            }

            var sum  = 0l;
            var len = a.Count;

            var sw1 = new Stopwatch();
            sw1.Start();

            for (var i = 0; i < len; i++){
                sum+=a[i];
            }

            sw1.Stop();
            Console.WriteLine(sw1.ElapsedMilliseconds);
            Console.WriteLine(sum);
        }
    }
}
