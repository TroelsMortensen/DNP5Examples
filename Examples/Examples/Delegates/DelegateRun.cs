using System;

namespace Examples.Delegates
{
    public class DelegateRun
    {
        public void RunExample()
        {
            DelegateExample de = new DelegateExample();
            DelegateMethods dm = new DelegateMethods();
            
            de.ExecuteDelegate(dm.PrintHelloWorld);
            
            de.ExecuteDelegate(SayHelloToStudents);
            
            de.ExecuteOtherDelegate(dm.PrintString, "Hello moon");
        }

        private void SayHelloToStudents()
        {
            Console.WriteLine("Hello students");
        }
    }
}