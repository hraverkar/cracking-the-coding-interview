using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  public static class StringCompression
  {
    public static void Main()
    {
      string str = "aabcccaaa";
      StringCompresation(str);
    }

    private static void StringCompresation(string str)
    {
      int len = str.Length;
      var ch = str.ToCharArray();
      for(int i=0; i < len; i++)
      {
        int count = 1;
        while (i < len - 1 && ch[i] == ch[i + 1])
        {
          count++;
          i++;
        }
        Console.Write(ch[i]);
        Console.Write(count);
      }

    }
  }
}
