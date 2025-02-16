// See https://aka.ms/new-console-template for more information
using System.Linq;
using LINQDemo;

Console.WriteLine("Hello, World!");

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<int> numList2 = new List<int> { 6, 7, 8, 2, 1 };
numbers.ForEach(n =>
{
    Console.WriteLine($"{n} ");
});

Console.WriteLine(numbers.Aggregate((int arg1, int arg2) => arg1 + arg2 ));
Console.WriteLine(numbers.All(i=> i>0));
Console.WriteLine(numbers.Any());
Console.WriteLine(numbers.Any(i=> i == 0));
Console.WriteLine(numbers.Average());

var concatenatedList = numbers.Concat(numList2).ToList();
concatenatedList.ForEach(n =>
{
    Console.WriteLine($" type of {n} is {n.GetType()}");
});

Console.WriteLine(concatenatedList.Contains(8));

var stringList = concatenatedList.ConvertAll(n => n.ToString());
stringList.ForEach(n =>
{
    Console.WriteLine($"type of {n} is {n.GetType()}");
});

Console.WriteLine(numbers.Count());
List<string> words = new List<string>();
var defaultValues = words.DefaultIfEmpty("Default Value").ToList();
defaultValues.ForEach(n =>
{
    Console.WriteLine(n);
});

var distinctList = concatenatedList.Distinct().ToList();
distinctList.ForEach(n =>
{
    Console.WriteLine(n);
});

Console.WriteLine(numbers.ElementAt(3));

List<string> List1 = new List<string> { "apple", "banana", "cherry" };
List<string> List2 = new List<string> { "apple", "banana", "cherry" };

var groupedByLength = List1.GroupBy(c => c.Length);

foreach (var group in groupedByLength)
{
    Console.WriteLine($"Key: {group.Key}");
    Console.WriteLine(string.Join(",", group));
}

// Compare if the lists are the same
bool areEqual = List1.SequenceEqual(List2);
Console.WriteLine(areEqual);

var exceptList = concatenatedList.Except(numbers).ToList();
exceptList.ForEach(n =>
{
    Console.WriteLine(n);
});

Console.WriteLine(numbers.First());
Console.WriteLine(numbers.FirstOrDefault());
Console.WriteLine(numbers.Last());
Console.WriteLine(numbers.LastOrDefault());
Console.WriteLine(string.Join(",", numbers.ToArray().Reverse().Select(n => n.ToString())));
Console.WriteLine(numbers.Skip(2).Take(1).First());

Console.WriteLine(numbers.SkipWhile(i => i <3).TakeWhile(i => i >= 3).Last());

var intersectList = numbers.Intersect(numList2).ToList();
intersectList.ForEach(n => Console.WriteLine(n));

Console.WriteLine(numList2.LongCount());
Console.WriteLine(numList2.Max());
Console.WriteLine(numList2.Min());
// Example list with mixed types (e.g., objects)
List<object> numList = new List<object> { 1, "hello", 2, 3, "world", 4 };

// Use OfType to filter out only integers
var intList = numList.OfType<int>();  // Filtering integers

// Print the filtered list
Console.WriteLine(string.Join(", ", intList));

var orderByList = numList2.OrderBy(n => n).ToList();
orderByList.ForEach(n =>
{
    Console.WriteLine(n);
});

var orderByDescList = numList2.OrderByDescending(n => n).ToList();
orderByDescList.ForEach(n =>
{
    Console.WriteLine(n);
});

var selectList = numList2.Where(n => n > 5).ToList();
selectList.ForEach(n =>
{
    Console.WriteLine(n);
});

var unionList = numbers.Union(numList2).ToList();
Console.WriteLine(string.Join(", ", unionList));

Console.WriteLine(numList2.Sum());

//Merges two sequences by matching corresponding elements.
var combined = numbers.Zip(numList2, (a, b) => new { a, b });
Console.WriteLine(string.Join(",", combined));

var people = new List<Person>()
                    { new Person { Name = "John", CityId = 1 },
                        new Person { Name = "Jeevan", CityId = 2 },
};

var cities = new List<City> { new City { Id = 1, CityName = "Pune" }, new City { Id = 2, CityName = "Mumbai" } };
var result = from person in people
             join city in cities on person.CityId equals city.Id
             select new { person.Name, city.CityName };

foreach (var item in result)
{
    Console.WriteLine($"Name: {item.Name}, City Name: {item.CityName}");
}

Console.WriteLine(numbers.Single());
Console.WriteLine(numbers.SingleOrDefault());



