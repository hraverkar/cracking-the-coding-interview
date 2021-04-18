using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  class base_Class
  {
    public virtual void Show()
    {
      Console.WriteLine("Hello harshal");
    }
  }

  class UpperClass :  base_Class
  {
      public  override void Show()
    {
      Console.WriteLine("Hello harshal Test");
    }
  }
  internal static class Overriding
  {
    public static void Main()
    {
      base_Class bc = new base_Class();
      bc.Show();

      bc = new UpperClass();
      bc.Show();

    }
  }
}
