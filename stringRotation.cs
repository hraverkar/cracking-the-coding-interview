using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  class stringRotation
  {
    public static void Main()
    {
      string str = "helloharshal";
      stringRotate(str);
    }

    private static void stringRotate(string str)
    {
      string ans = str.Substring(5) + str.Substring(0, 5);
      Console.WriteLine(ans);
    }
  }
}
