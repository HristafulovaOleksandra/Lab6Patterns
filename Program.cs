using Lab6Patterns.DecoratorPattern;
using Lab6Patterns.FactoryMethodPattern;
using Lab7Patterns.DecoratorPattern;
using Lab7Patterns.FactoryMethodPattern;
using Lab7Patterns.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.WriteLine($"Sum: {context.ExecuteAroundStrategy(numbers)}");

            context.SetStrategy(Strategies.Max);
            Console.WriteLine($"Max: {context.ExecuteAroundStrategy(numbers)}");

            context.SetStrategy(Strategies.CountEven);
            Console.WriteLine($"Even Count: {context.ExecuteAroundStrategy(numbers)}");

            Console.WriteLine("\n______________|Factory Method Pattern|______________");
            var dogCreator = AnimalFactory.CreateAnimal("dog");
            var catCreator = AnimalFactory.CreateAnimal("cat");
            AnimalExecutor.Execute(dogCreator);
            AnimalExecutor.Execute(catCreator);

            Console.WriteLine("\n______________|Decorator Pattern|______________");
            Func<string, string> baseProcessor = text => text;
            var processor = TextProcessor.AddFooter(TextProcessor.AddHeader(TextProcessor.MakeUpper(baseProcessor)));

            string finalResult = TextExecutor.Execute(processor, "this is sample text.");
            Console.WriteLine("\n--- Result ---");
            Console.WriteLine(finalResult);
        }
    }
}
