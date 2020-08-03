using System;
using System.Collections.Generic;
using System.Text;

namespace NullDemo
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool AccidentFree { get; set; }

        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }

        public Car(int year, string make, string model, bool accidentFree)
        {
            Year = year;
            Make = make;
            Model = model;
            AccidentFree = accidentFree;
        }
    }
}
