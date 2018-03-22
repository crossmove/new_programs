using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class Car
    {
        public string _nameofcar = "";
        public int _carno = 0;
        public double _carprice = 0;
        public Car(string NameofCar, int CarNumber, double CarPrice)
        {
            _nameofcar = NameofCar;
            _carno = CarNumber;
            _carprice = CarPrice;
        }
        //Copy Constructor
        public Car(Car objCar)
        {
            _nameofcar = objCar._nameofcar;
            _carno = objCar._carno;
            _carprice = objCar._carprice;
        }
    }

    class CopyConstructor
    {
        public void Method()
        {
            Car obj1 = new Car("BMW Sedan", 4545, 5000000);
            Car obj2 = new Car(obj1);
        }
    }
}
