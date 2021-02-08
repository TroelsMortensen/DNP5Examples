using System;
using System.Collections.Generic;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Troels", "Mortensen");

            var p1 = new Person();

            Person p2 = new();

            Person p3 = new Person
            {
                FirstName = "Troels",
                LastName = "Mortensen"
            };

            Person p87 = new Person
            {
                FirstName = "Peter"
            };
            
            Person p4 = new()
            {
                FirstName = "Troels",
                LastName = "Mortensen"
            };

            List<int> numbers = new() {1,2,3};

            int atIndex2 = numbers[2];

            Console.WriteLine("hello");
            string s = "gekk";
            String s1 = s;
        }
    }
}