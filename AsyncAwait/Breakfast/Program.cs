using System;
using System.Diagnostics;

namespace Breakfast
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            SyncBreakfast.MakeSynchronous();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }

    internal class Coffee
    {
    }

    internal class Egg
    {
    }

    internal class Toast
    {
    }

    internal class Bacon
    {
    }

    internal class Juice
    {
    }
}