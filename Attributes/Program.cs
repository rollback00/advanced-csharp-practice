using System;
using System.Linq;
using System.Reflection;

namespace Attributes
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Hello World!");

      var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                  where t.GetCustomAttributes<SampleAttribute>().Count() > 0
                  select t;

      foreach (var t in types)
      {
        Console.WriteLine(t.Name);

        foreach (var p in t.GetProperties())
        {
          Console.WriteLine(p.Name);
        }
      }
    }
  }
}
