using advanced_csharp.Generics;
using System;

namespace Generics
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Hello World!");

      var result1 = new Result<int, string> { Success = true, Data = 12, Data2 = "Papa" };
      var result2 = new Result<string, bool> { Success = true, Data = "John", Data2 = false };

      Console.WriteLine($"Result 1 Data: {result1.Data.GetType()}\nResult 1 Data2: {result1.Data2.GetType()}");
      Console.WriteLine();
      Console.WriteLine($"Result 2 Data: {result2.Data.GetType()}\nResult 2 Data2: {result2.Data2.GetType()}");
    }
  }
}
