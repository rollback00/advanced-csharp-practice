using System;
using System.Collections.Generic;
using System.Text;

namespace advanced_csharp.Generics
{
  class ResultPrinter
  {
    //public void Print(Result<int> result)
    //{
    //  Console.WriteLine(result.Success);
    //  Console.WriteLine(result.Data);
    //}

    public void Print<T>(Result<T> result)
    {
      Console.WriteLine(result.Success);
      Console.WriteLine(result.Data);
    }
  }
}
