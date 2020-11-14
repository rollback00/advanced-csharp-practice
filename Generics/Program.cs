using advanced_csharp.Generics;
using System;

namespace Generics
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Hello World!");

      var result1 = new Result<int> { Success = true, Data = 12 };
      var result2 = new Result<string> { Success = true, Data = "John" };

      Console.WriteLine($"Result 1 Data: {result1.Data.GetType()}");
      Console.WriteLine($"Result 2 Data: {result2.Data.GetType()}");
    }
  }
}
