// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("Hello, World!");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine(numbers.First());
Console.WriteLine(numbers.Last());
Console.WriteLine(string.Join(",", numbers.ToArray().Reverse().Select(n => n.ToString())));
Console.WriteLine(numbers.Skip(2).Take(1).First());

Console.WriteLine(numbers.SkipWhile(i => i <3).TakeWhile(i => i >= 3).Last());
Console.WriteLine(numbers.Single());
