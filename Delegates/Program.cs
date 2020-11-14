using System;

namespace Delegates
{
  class Program
  {
    delegate void MyDelegate(string message);
    // class MyDelegate

    static void Main(string[] args)
    {
      //MyDelegate del = new MyDelegate(SayHi);
      //del.Invoke();


      //MyDelegate del = SayHi;
      
      MyDelegate del = GiveMeAway();
      del("Michael");
      Test(del, "Hi Test!!");

      //SayHi();
    }

    private static void SayHi(string message) => Console.WriteLine($"Hello {message}!");

    private static void Test(MyDelegate del, string message) => del(message);

    private static MyDelegate GiveMeAway()
    {
      return new MyDelegate(SayHi);
    }
  }
}
