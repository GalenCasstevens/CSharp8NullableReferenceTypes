using System;

namespace NullDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var galen = new Person("Galen", "Casstevens");
            //var length = GetMiddleNameLength(galen);
            //Console.WriteLine(length);

            var bmw = new SportsCar("BMW", "335i", 2013);
            var count = GetNumberOfFeatures(bmw);
            Console.WriteLine(count);
        }

        static int GetNumberOfFeatures(SportsCar car)
        {
            //return car.Features?.Count ?? 0;
            //return car.Features is { Count: var count } ? count : 0;
            return car.Features.Count;
        }

        //static int GetMiddleNameLength(Person person)
        //{
        //    var middle = person.MiddleName;
        //    return middle.Length;
        //}
    }
}
