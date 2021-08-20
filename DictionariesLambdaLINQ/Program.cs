using System;
using System.Collections.Generic;

namespace DictionariesLambdaLINQ
{
  class Program
  {
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

      // Assign new value to key
      dictCapitals["France"] = "Bordeaux";
      foreach (var item in dictCapitals)
      {
        Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        // Output:
        // Key: France, Value: Bordeaux
        // ...
      }

      Console.ReadLine();
    }
  }
}
