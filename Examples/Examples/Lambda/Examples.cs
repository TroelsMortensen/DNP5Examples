using System;
using Microsoft.VisualBasic;

namespace Examples.Lambda
{
    public class Examples
    {
        public void RunExample()
        {
            Print();
            Action p = () => Console.WriteLine("Hello World");
            
            p.Invoke();
            
            Print("Goodbye world");

            Action<string> p1 = argument => Console.WriteLine(argument);
            
            p1.Invoke("Goodbye world");
        }

        private void Print()
        {
            Console.WriteLine("Hello world");
        }

        private void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}