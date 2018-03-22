using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Topic Build Pattern:
https://code.msdn.microsoft.com/windowsapps/Design-Patterns-Builder-26d38c45
Components of Builder Pattern: 

1. Builder:
Defines a template for the steps to construct the product. 
Specifies an abstract interface for creating parts of a Product object.
 
2. Concrete Builder:
Implements the builder interface and provides an interface for getting the product.
 * Constructs and assembles parts of the product by implementing the Builder interface 
 * defines and keeps track of the representation it creates provides an interface for 
 * retrieving the product.Concrete Builder builds the product's internal representation 
 * and defines the process by which it's assembled includes classes that define the constituent parts, 
 * including interfaces for assembling the parts into the final result.

3. Director:
Actually constructs the object through the builder interface.
Constructs an object using the Builder interface.
 
4. Product:
Main object that's constructed.
Represents the complex object under construction.
 **/
namespace DesignPatterns
{
    //The director actually constructs the
    //object through the builder interface
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.StepOne();
            builder.StepLast();
        }
    }

    //The builder interface defines a template 
    //for the steps to construct the product.
    interface IBuilder
    {
        void StepOne();

        void StepLast();
    }

    //The concrete builder implements the builder interface and 
    //provides an interface for getting the product. 
    class CarBuilder : IBuilder
    {
        public void StepOne()
        {
            //Necessary code for building the computer type A
            Console.WriteLine("Step 1 For CAR Assebmly");
        }

        public void StepLast()
        {
            Console.WriteLine("Step Last For CAR Assebmly");
        }
    }
    class BikeBuilder : IBuilder
    {
        public void StepOne()
        {
            //Necessary code for building the computer type A
            Console.WriteLine("Step 1 For Bike----Bike Assebmly");
        }

        public void StepLast()
        {
            Console.WriteLine("Step Last For Bike----Bike Assebmly");
        }
    }
    class MyClient
    {
        public static void Method1()
        {
            Director d = new Director();
            IBuilder carBuilder = new CarBuilder();
            d.Construct(carBuilder);
            Console.WriteLine("\r\n");

            IBuilder bikeBuilder = new BikeBuilder();
            d.Construct(bikeBuilder);
            Console.WriteLine("\r\n");
        }
    }

}
