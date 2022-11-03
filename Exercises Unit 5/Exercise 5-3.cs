using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterUppercaseLetters
{
  class Program
  {
    static void Main (string[] args)
    {
      while (true)
        {
          Console.Write ("Enter an uppercase letter: ");
          char ch = Console.ReadLine ()[0];
          if (ch == '!')
            break;
          if (ch >= 'A' && ch <= 'Z')
            {
              Console.WriteLine ("OK");
            }
          else
            {
              Console.WriteLine (" Sorry - that was not an uppercase letter.");
            }
        }
    }
  }
}
