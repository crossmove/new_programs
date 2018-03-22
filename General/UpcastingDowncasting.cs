using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * http://people.cs.aau.dk/~normark/oop-csharp/html/notes/inheritance-note-up-down-casting.html
Upcasting converts an object of a specialized type to a more general type.
Downcasting converts an object from a general type to a more specialized type.
*/

namespace General
{
    class UpcastingDowncasting
    {
        public void PositiveCase()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();

            //Upcasting converts an object
            //of a specialized type to a more general type
            animal = dog;

            //this also correct already dog is assigned to animal in previous line
            //now casting from animal to dog wont give error
            dog = (Dog)animal;

            Console.WriteLine();
        }

        public void NegativeCase()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();

            //it gives error
            //Unable to cast object of Type Animal to Dog 
            dog = (Dog)animal;
        }

    }
    public class Animal { }
    public class Dog : Animal { }
}
