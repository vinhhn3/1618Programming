using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesLambdaLINQ
{
  class Program
  {
    // Lambda Expression: "=>"
    // Read: "goes to"


    //static double DivideByTwo(double input)
    //{
    //  return input / 2;
    //}
    //                        input             output      
    static double DivideByTwo(double input) => input / 2;
    //static double Multiply(double a, double b)
    //{
    //  return a * b;
    //}
    //                     input                  output
    static double Multiply(double a, double b) => a * b;
    static void Main(string[] args)
    {
      List<string> capitals = new List<string>()
      {
        "Paris", "Hanoi", "Tokyo"
      };

      foreach (var item in capitals)
      {
        Console.WriteLine(item);
        // Output:
        // Paris
        // Hanoi
        // Tokyo
      }

      // SortedDictionary
      SortedDictionary<string, string> dictCapitals = new SortedDictionary<string, string>();
      // Dictionary['key'] = value
      //dictCapitals["France"] = "Paris";
      //dictCapitals["Vietnam"] = "Hanoi";
      //dictCapitals["Japan"] = "Tokyo";

      dictCapitals.Add("France", "Paris");
      dictCapitals.Add("Vietnam", "Hanoi");
      dictCapitals.Add("Japan", "Tokyo");

      foreach (var item in dictCapitals)
      {
        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        // Output:
        // Key: France, Value: Paris
        // ...
      }

      // Assign new value to existing key
      dictCapitals["France"] = "Bordeaux";
      foreach (var item in dictCapitals)
      {
        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        // Output:
        // Key: France, Value: Bordeaux
        // ...
      }

      // Methods:
      // Add(key, value)
      Console.WriteLine("==========");
      dictCapitals.Add("Germany", "Berlin");
      dictCapitals.Add("Australia", "Canberra");
      dictCapitals.Add("Italy", "Rome");

      foreach (var item in dictCapitals)
      {
        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        // Output:
        //Key: Australia, Value: Canberra
        //Key: France, Value: Bordeaux
        //Key: Germany, Value: Berlin
        //Key: Italy, Value: Rome
        //Key: Japan, Value: Tokyo
        //Key: Vietnam, Value: Hanoi
      }

      // Remove(key)
      Console.WriteLine("==========");
      dictCapitals.Remove("France");
      foreach (var item in dictCapitals)
      {
        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        // Output:
        //Key: Australia, Value: Canberra
        //Key: Germany, Value: Berlin
        //Key: Italy, Value: Rome
        //Key: Japan, Value: Tokyo
        //Key: Vietnam, Value: Hanoi
      }

      // ContainsValue(value)
      Console.WriteLine("==========");
      Console.WriteLine(dictCapitals.ContainsValue("Rome"));    // True
      Console.WriteLine(dictCapitals.ContainsValue("Paris"));   // False

      // ContainsKey(key)
      Console.WriteLine("==========");
      Console.WriteLine(dictCapitals.ContainsKey("Japan"));     // True
      Console.WriteLine(dictCapitals.ContainsKey("France"));    // False

      // Problem: Word Synonyms
      //Console.WriteLine("==========");
      //SortedDictionary<string, List<string>> synonyms = new SortedDictionary<string, List<string>>();
      //Console.Write("Read 2 * N lines of pairs word and synonym: ");
      //int n = int.Parse(Console.ReadLine());
      //for (int i = 0; i < n; i++)
      //{
      //  var word = Console.ReadLine();
      //  var synonym = Console.ReadLine();

      //  if (synonyms.ContainsKey(word))
      //  {
      //    synonyms[word].Add(synonym);
      //  }
      //  else
      //  {
      //    synonyms.Add(word, new List<string>() { synonym });
      //  }
      //}

      //foreach (var item in synonyms)
      //{
      //  Console.WriteLine($"{item.Key} -> ");
      //  foreach (var syn in item.Value)
      //  {
      //    Console.WriteLine($"\t {syn}");
      //  }
      //}

      // LINQ
      Console.WriteLine("==========");
      SortedDictionary<string, int> students = new SortedDictionary<string, int>();
      students.Add("John", 10);
      students.Add("Wick", 7);
      students.Add("Eric", 8);
      students.Add("Superman", 2);
      students.Add("Batman", 7);
      students.Add("Thor", 8);
      students.Add("BlackPanther", 4);
      students.Add("BlackWidow", 3);

      foreach (var item in students)
      {
        Console.WriteLine($"{item.Key} : {item.Value}");
      }

      Console.WriteLine("==========");

      var sortedByVal = students
        .OrderBy(s => s.Value)
        .ToDictionary(s => s.Key, s => s.Value);

      foreach (var item in sortedByVal)
      {
        Console.WriteLine($"{item.Key} : {item.Value}");
      }

      Console.WriteLine("==========");
      Console.WriteLine(students.Max(s => s.Value));      // 10
      Console.WriteLine(students.Min(s => s.Value));      // 2
      Console.WriteLine(students.Average(s => s.Value));  // 6.125
      Console.WriteLine(students.Sum(s => s.Value));      // 49

      Console.WriteLine("==========");
      var sortedByValDesc = students
        .OrderByDescending(s => s.Value)
        .ToDictionary(s => s.Key, s => s.Value);
      foreach (var item in sortedByValDesc)
      {
        Console.WriteLine($"{item.Key} : {item.Value}");
      }

      // Seaching
      Console.WriteLine("==========");
      var result = students
        .Where(s => s.Value == 7)
        .ToDictionary(s => s.Key, s => s.Value);
      foreach (var item in result)
      {
        Console.WriteLine($"{item.Key} : {item.Value}");
      }
      Console.ReadLine();


    }
  }
}
