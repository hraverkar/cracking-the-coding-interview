using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  public static class oneAway
  {

    public static void Main()
    {
      string str1 = "pale";
      string str2 = "ple";
      var rt = check(str1, str2);

      Console.WriteLine(rt);
    }

    public static bool check(string str1, string str2)
    {
      if (str1 == str2)
      {
        return true;
      }
      else if (str1.Length == str2.Length)
      {
        return replaceString(str1, str2);
      }
      else if (str1.Length == str2.Length + 1)
      {
        return insertString(str1, str2);
      }
      else if (str2.Length == str1.Length + 1)
      {
        return insertString(str2, str1);
      }

      return false;
    }

    private static bool replaceString(string str1, string str2)
    {
      bool replaced = false;
      for (int i = 0; i < str1.Length; i++)
      {
        if (str1[i] != str2[i])
        {
          if (replaced)
          {
            return false;
          }
          else
          {
            replaced = true;
          }
        }
      }
      return true;
    }

    private static bool insertString(string str1, string str2)
    {
      int j = 0;
      bool inserted = false;
      for (int i = 0; i < str2.Length; i++)
      {
        if (str1[j] != str2[i])
        {
          if (inserted)
          {
            return false;
          }
          else
          {
            inserted = true;
            i--;
          }
        }
        j++;
      }
      return true;
    }

  }
}
