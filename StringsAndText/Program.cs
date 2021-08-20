using System;

namespace StringsAndText
{
  class Program


  {
    // Examples for StackOverFlow
    static void functionA()
    {
      int c = 10;
      functionB();
    }

    static void functionB()
    {
      functionA();
    }


    static void Main(string[] args)
    {
      // Declare string 
      string hello = "Hello World";

      // string vs. String
      // string allias String
      String s = "Hello Wolrd";

      int a = 10;
      Int32 b = 20;

      // Operation string
      // Concat strings with "+" operator
      hello = "Hello Wolrd" + " C#";

      // Comparaison 
      string myHello = "ABC";
      // == vs. Equals()
      hello = "ABC";
      char[] c = new char[]
      {
        'A','B','C','\0'
      };
      Console.WriteLine(hello == myHello);      // true
      Console.WriteLine(hello.Equals(c));       // true

      // string: object immutable (can not change)
      Console.WriteLine(hello[0]);
      c[0] = 'O';
      // Cannot change value of hello[0] because string is immutable object
      // hello[0] = 'O';

      // Concat()
      string gretting = "Hello ";
      string name = "John Wick";
      string result = gretting + " " + name;
      Console.WriteLine(result); // Hello John Wick
      result = string.Concat(
        gretting, " ", name, ". This is example of Concat() function");
      Console.WriteLine(result);  // Hello John Wick. This is example of Concat() function

      // Searching 
      // Contains()
      var contains = name.Contains("Wi"); // true
      Console.WriteLine(contains);
      contains = name.Contains("Doe");    // false
      Console.WriteLine(contains);

      // IndexOf() - returns the first match index or -1
      string fruits = "banana, apple, kiwi, banana, apple";
      Console.WriteLine(fruits.IndexOf("banana")); //0
      Console.WriteLine(fruits.IndexOf("apple"));  //8
      Console.WriteLine(fruits.IndexOf("orange")); //-1

      // LastIndexOf() - finds the last occurrence or -1
      Console.WriteLine(fruits.LastIndexOf("banana"));    //21
      Console.WriteLine(fruits.LastIndexOf("orange"));    //-1

      // Substring(int startIndex, int length)
      string card = "10C";
      string power = card.Substring(0, 2);
      Console.WriteLine(power); //10
      power = card.Substring(1, 2);
      Console.WriteLine(power); //0C

      // Substring(int startIndex)
      power = card.Substring(1);
      Console.WriteLine(power); //0C
      power = card.Substring(0);
      Console.WriteLine(power); //10C

      // functionA();
      Console.ReadLine();

    }
  }
}
