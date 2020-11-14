using advanced_csharp.Generics;
using System;

namespace Generics
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Hello World!");

      var resultInt = new Result<int> { Success = true, Data = 20};
      var resultString = new Result<string> { Success = false, Data = "Papa" };

      var rp = new ResultPrinter();
      rp.Print(resultInt);
      rp.Print(resultString);


      //Console.WriteLine($"Result 1 Data: {result1.Data.GetType()}\nResult 1 Data2: {result1.Data2.GetType()}");
      //Console.WriteLine();
      //Console.WriteLine($"Result 2 Data: {result2.Data.GetType()}\nResult 2 Data2: {result2.Data2.GetType()}");
    }
  }
}
 