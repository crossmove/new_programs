using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//It deals with the problem of creating objects (products) without specifying the exact class of object 
//that will be created.

namespace DesignPatterns
{
    public static class FactoryClassExample
    {
        public static IVehicle VehicleType(string value)
        {
            if (value == "petrol")
            {
                return new Car();
                //Factory Pattern
            }

            else
            {
                return new Lorry();
            }
        }
    }

    public interface IVehicle
    {
        void FuelType();
    }

    public class Car : IVehicle
    {

        public void FuelType()
        {
            Console.WriteLine("Petrol");
        }
    }

    public class Lorry : IVehicle
    {

        public void FuelType()
        {
            Console.WriteLine("Diesel");
        }
    }

    // Finally, the client code looks like shown below. In this, the client does not bother
    //about the classes and class name and does not worry if any new class will be added:
    public class FactoryClass
    {
        static void Method(string[] args)
        {
            IVehicle vehiclePetrol = FactoryClassExample.VehicleType("petrol");
            IVehicle vehicleDiesel = FactoryClassExample.VehicleType("diesel");

            vehiclePetrol.FuelType();
            vehicleDiesel.FuelType();
        }
    }
}
