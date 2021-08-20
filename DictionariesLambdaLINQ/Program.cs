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
      Console.WriteLine("==========");
      SortedDictionary<string, List<string>> synonyms = new SortedDictionary<string, List<string>>();
      Console.Write("Read 2 * N lines of pairs word and synonym: ");
      int n = int.Parse(Console.ReadLine());
      for (int i = 0; i < n; i++)
      {
        var word = Console.ReadLine();
        var synonym = Console.ReadLine();

        if (synonyms.ContainsKey(word))
        {
          synonyms[word].Add(synonym);
        }
        else
        {
          synonyms.Add(word, new List<string>() { synonym });
        }
      }

      foreach (var item in synonyms)
      {
        Console.WriteLine($"{item.Key} -> ");
        foreach (var syn in item.Value)
        {
          Console.WriteLine($"\t {syn}");
        }
      }

      Console.ReadLine();


    }
  }
}
