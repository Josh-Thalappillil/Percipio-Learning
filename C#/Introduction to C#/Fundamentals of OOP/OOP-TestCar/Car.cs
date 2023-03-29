using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TestCar
{

    public class Car
    {
        String make;
        String model;
        int year;
        String colour;

        public Car(String make, String model, int year, String colour)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.colour = colour;
        }

        public void Drive()
        {
            Console.WriteLine("You drive the " + colour + " " + year + " " + make + " " + model);
        }
    }
}

