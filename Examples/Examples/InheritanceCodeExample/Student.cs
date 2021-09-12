namespace Examples.InheritanceCodeExample
{
    
    class Student : Human, IMale, ISoftwareStudent 
    {
        public Student(string name) : base(name)
        {
            // other stuff here perhaps
        }
    }


}