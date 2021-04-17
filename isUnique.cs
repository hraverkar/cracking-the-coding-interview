using System;

namespace ConsoleApp210
{
  public static class isUnique
  {
    public static void Main(string[] args)
    {
      const string str = "abcdefghij";
      var result = IsUniqueCharacters(str);
      if (result)
      {
        Console.WriteLine( str + " Given string is unique");
      }
      else
      {
        Console.WriteLine(str + " Given string is not unique");
      }
    }

    public static bool IsUniqueCharacters(string str)
    {
      for (int i = 0; i < str.Length; i++)
      {
        for (int j = i + 1; j < str.Length; j++)
        {
          if (str[i] == str[j])
            return false;
        }
      }
      return true;
    }
  }
}
