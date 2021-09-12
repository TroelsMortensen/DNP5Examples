using System;

namespace Examples.Delegates
{
    public class DelegateExample
    {
        public void ExecuteDelegate(Action methodArgument)
        {
            methodArgument.Invoke();
            methodArgument();
        }

        public void ExecuteOtherDelegate(Action<string> methodArgument, string s)
        {
            methodArgument.Invoke(s);
        }
    }
}