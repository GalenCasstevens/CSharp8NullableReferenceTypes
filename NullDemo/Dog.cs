using System;
using System.Collections.Generic;
using System.Text;

namespace NullDemo
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsTrained { get; set; }
        public enum TrainingType
        {
            PositiveReinforcement,
            ScientificTraining,
            ClickerTraining,
            ElectronicTraining
        }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Dog(string name, int age, bool isTrained)
        {
            Name = name;
            Age = age;
            IsTrained = isTrained;
        }
    }
}
