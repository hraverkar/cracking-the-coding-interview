using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  static class stringurlify
  {
    public static void Main()
    {
      string str = "hello harshal raverkar ".Trim();
      var t = str.Replace(" ", "%20");
      Console.WriteLine(t);
    }
  }
}
