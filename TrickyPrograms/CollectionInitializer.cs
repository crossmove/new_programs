using System;
using System.Collections;

namespace TrickyPrograms
{
    class CollectionInitializer
    {
        public void test()
        {
            Employe empObj = new Employe()
            {
                ID = 1,
                Name = "pradeep"
            };

            Employe empObj1 = new Employe() { 1 };
            Employe empObj3 = new Employe() { 1, { 1, "a" }};

        }
    }
    //https://stackoverflow.com/questions/459652/why-do-c-sharp-collection-initializers-work-this-way
    //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers

    public class Employe : IEnumerable
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Add(int i)
        { }
        public void Add(int i, string j)
        { }
    }
}
