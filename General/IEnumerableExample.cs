using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Topic: Why do C# collection initializers work this way?
https://stackoverflow.com/questions/459652/why-do-c-sharp-collection-initializers-work-this-way
 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
*/
namespace General
{
    class IEnumerableExample
    {
        public void test()
        {
            Employe empObj = new Employe()
            {
                ID = 1,
                Name = "pradeep"
            };

            //We can write code like this if we implement IEnumerable to Employee Class
            //and adding two methods mentioned in region AddedManully
            #region
            Employe empObj1 = new Employe() { 1 };
            Employe empObj3 = new Employe() { 1, { 1, "a" } };
            #endregion

        }
    }

    public class Employe : IEnumerable
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #region AddedManually
        public void Add(int i)
        { }
        public void Add(int i, string j)
        { }
        #endregion AddedManually

    }
}
