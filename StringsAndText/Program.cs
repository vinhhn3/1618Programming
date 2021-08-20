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

      // functionA();
      Console.ReadLine();

    }
  }
}
