using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  public class Overloading
  {

    class Calculator
    {
      public int Add(int x, int y)
      {
        int p;
        return p =  x + y;
      }

      public int Add(int x, int y, int z)
      {
        int p;
        return p = x + y + z;
      }
    }
    public static void Main()
    {
      var cal = new Calculator();
      Console.WriteLine(cal.Add(2, 3));
      Console.WriteLine(cal.Add(2, 3, 6));
    }
  }
}
