using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFeatures
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
            dog = (Dog)animal;
        }
    }

    class Animal
    {

    }

    class Dog : Animal
    {
    }
}
