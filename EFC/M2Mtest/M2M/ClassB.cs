using System.Collections.Generic;

namespace M2Mtest.M2M
{
    public class ClassB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ClassA> AClasses { get; set; }
    }
}