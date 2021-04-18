using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp210
{
  internal class Base_Class
  {
    public virtual void Show()
    {
      Console.WriteLine("Hello harshal");
    }
  }
  internal class UpperClass : Base_Class
  {
    public override void Show()
    {
      Console.WriteLine("Hello harshal Test");
    }
  }
  internal static class Overriding
  {
    public static void Main()
    {
      Base_Class bc = new Base_Class();
      bc.Show();

      bc = new UpperClass();
      bc.Show();

    }
  }
}
