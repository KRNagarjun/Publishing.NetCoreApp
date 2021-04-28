using System;
using Humanizer;

namespace PublishingAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("109".Humanize());
            Console.WriteLine(1000009.ToOrdinalWords());
            Console.WriteLine(1000009.ToWords());
            Console.WriteLine(1000009.ToRoman());
            Console.WriteLine(1000009.Tupleize());
        }
    }
}
