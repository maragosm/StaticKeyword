using System;
using System.Collections.Generic;
using System.Text;

namespace StaticKeyword
{
    internal class Car
    {

        public Car()
        {
            CarLot.numberOfCars++;
        }

        public string Name { get; set; }
    }
}
