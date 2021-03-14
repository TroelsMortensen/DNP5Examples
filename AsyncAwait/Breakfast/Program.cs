using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Breakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            await AsyncBreakfast.MakeAsynch();
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