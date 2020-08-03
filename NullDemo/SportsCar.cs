using System;
using System.Collections.Generic;
using System.Text;

namespace NullDemo
{
    public class SportsCar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool HasTurbo { get; set; }
        public List<Feature>? Features { get; set; }

        public SportsCar(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            Features = null;
        }
    }
}
