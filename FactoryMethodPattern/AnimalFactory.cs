using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Patterns.FactoryMethodPattern
{
    public static class AnimalFactory
    {
        public static Animal CreateDog()
        {
            return new Dog();
        }
        public static Animal CreateCat()
        {
            return new Cat();
        }
        public static Func<Animal> CreateAnimal(string type)
        {
            switch (type.ToLower())
            {
                case "dog":
                    return CreateDogMethod;
                case "cat":
                    return CreateCatMethod;
                default:
                    throw new ArgumentException("Unknown animal type");
            }
        }
        private static Animal CreateDogMethod()
        {
            return new Dog();
        }

        private static Animal CreateCatMethod()
        {
            return new Cat();
        }
    }
}
