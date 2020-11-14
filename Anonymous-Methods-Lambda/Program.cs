using System;

namespace Anonymous_Methods_Lambda
{
  class Program
  {

    delegate void Operation(int num);

    static void Main(string[] args)
    {
      //Operation op = delegate (int num) { Console.WriteLine($"{num} * {num} = {num * num}"); };
      //Operation op = num => { Console.WriteLine($"{num} * {num} = {num * num}"); };
      
      Action<int> op = num => { Console.WriteLine($"{num} * {num} = {num * num}"); };
      op(6);

      Func<int, int> Double = num => { return num * 2; };

      Console.WriteLine(Double(5));
    }
  }
}
