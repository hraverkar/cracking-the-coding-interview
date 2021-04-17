using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  internal static class StringPermutation
  {
    public static void Main()
    {
      string str1 = "abcd";
      string str2 = "dabc";

      var result = arePermutation(str1, str2);

      if (result)
      {
        Console.WriteLine("string is permutation");
      } else
      {
        Console.WriteLine("string is not permutation");
      }
    }

    private static bool arePermutation(string str1, string str2)
    {
      int len1 = str1.Length;
      int len2 = str2.Length;

      if (len1 != len2)
        return false;

      var ch1 = str1.ToCharArray();
      var ch2 = str2.ToCharArray();

      Array.Sort(ch1);
      Array.Sort(ch2);

      for(int i=0; i< len1; i++)
      {
        if (ch1[i] != ch2[i])
          return false;
      }
      return true;
    }
  }
}
