using System.Collections.Generic;

namespace M2Mtest.M2M
{
    public class ClassA
    {
        public int Id { get; set; }
        public string OtherName { get; set; }
        public IList<ClassB> BClasses { get; set; }

    }
}