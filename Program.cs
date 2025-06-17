using Lab7Patterns.DecoratorPattern;
using Lab7Patterns.FactoryMethodPattern;
using Lab7Patterns.StrategyPattern;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab7Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________|Strategy Pattern|______________");
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            var context = new StrategyContext(Strategies.Sum);
            Console.WriteLine($"Sum: {context.ExecuteStrategy(numbers)}");

            context.SetStrategy(Strategies.Max);
            Console.WriteLine($"Max: {context.ExecuteStrategy(numbers)}");

            context.SetStrategy(Strategies.CountEven);
            Console.WriteLine($"Even Count: {context.ExecuteStrategy(numbers)}");

            Console.WriteLine("\n______________|Factory Method Pattern|______________");
            var dogCreator = AnimalFactory.CreateAnimal("dog");
            var catCreator = AnimalFactory.CreateAnimal("cat");
            dogCreator().Speak();
            catCreator().Speak();

            Console.WriteLine("\n______________|Decorator Pattern|______________");
            Func<string, string> baseProcessor = Identity;

            var upper = TextProcessor.MakeUpper(baseProcessor);
            var header = TextProcessor.AddHeader(upper);
            var footer = TextProcessor.AddFooter(header);
            var result = footer("this is sample text.");
            Console.WriteLine(result);

            Console.WriteLine("\n______________|Execute Around Pattern|______________");
            var filePath = "Lab6Patterns.txt";
            ExecuteAround.WithFile(filePath, WriteBody);
            Console.WriteLine($"File written to {Path.GetFullPath(filePath)}");
        }
        static string Identity(string input)
        {
            return input;
        }
        static void WriteBody(StreamWriter writer)
        {
            writer.WriteLine("Functional programming");
        }
    }
}
