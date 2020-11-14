using System;
using System.Linq;
using System.Reflection;

namespace Reflection
{
  class Program
  {
    static void Main(string[] args)
    {
      var assembly = Assembly.GetExecutingAssembly();

      var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<MyClassAttribute>().Count() > 0);

      foreach (var type in types)
      {
        Console.WriteLine($"Type: {type.Name}");

        var props = type.GetProperties().Where(p => p.GetCustomAttributes<MyPropertyAttribute>().Count() > 0);

        foreach (var prop in props)
        {
          Console.WriteLine($"Property: {prop.Name}");
        }

        var methods = type.GetMethods().Where(m => m.GetCustomAttributes<MyMethodAttribute>().Count() > 0);

        foreach (var method in methods)
        {
          Console.WriteLine($"Method: {method.Name}");
          //Console.WriteLine($"Method Content: {method.Invoke(obj, assembly)}");
        }
      }
    }
  }

  [MyClass]
  class JustClass
  {
    [MyProperty]
    public string MyProperty { get; set; }
    public int myInt = 0;

    [MyMethod]
    public void MyMethod() { Console.WriteLine("just a sentence"); }

    [MyMethod]
    public void AnotherMethod() { }
  }

  [AttributeUsage(AttributeTargets.Class)]
  class MyClassAttribute : Attribute
  {

  }

  [AttributeUsage(AttributeTargets.Method)]
  class MyMethodAttribute : Attribute
  {

  }

  [AttributeUsage(AttributeTargets.Property)]
  class MyPropertyAttribute : Attribute
  {

  }
}
