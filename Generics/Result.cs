using System;
using System.Collections.Generic;
using System.Text;

namespace advanced_csharp.Generics
{
  class Result<T>
  {
    public bool Success { get; set; }
    public T Data { get; set; }
  }
}
