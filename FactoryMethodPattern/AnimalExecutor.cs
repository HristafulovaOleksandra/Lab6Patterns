using Lab7Patterns.FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Patterns.FactoryMethodPattern
{
    public static class AnimalExecutor
    {
        public static void Execute(Func<Animal> createAnimal)
        {
            Console.WriteLine("-> Starting to create animal...");

            try
            {
                Animal animal = createAnimal();
                Console.WriteLine("-> Animal created. Sound:");
                animal.Speak();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"!!! Error: {ex.Message}");
            }

            Console.WriteLine("-> Execution completed.\n");
        }
    }

}
