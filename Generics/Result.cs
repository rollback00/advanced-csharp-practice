using System;
using System.Collections.Generic;
using System.Text;

namespace advanced_csharp.Generics
{
  class Result<T, U>
  {
    public bool Success { get; set; }
    public T Data { get; set; }
    public U Data2 { get; set; }
  }
}
