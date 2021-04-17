using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  internal static class PalindromeString
  {
    public static void Main()
    {
      string str = "Malayalama".ToLower();
      var result = stringPalindrome(str);
      if (result)
      {
        Console.WriteLine("Given string is palindrome");
      } else
      {
        Console.WriteLine("Given string is not palindrome ");
      }
    }

    private static bool stringPalindrome(string str)
    {
      string res = "";
      int len = str.Length;
      if (len % 2 == 0)
      {
        return false;
      } else {
        for(int i = str.Length-1; i>=0; i--)
        {
          res += str[i].ToString();
        }
        return str == res;
      }
    }
  }
}
