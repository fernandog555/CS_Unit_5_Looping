using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OdddNumbers
{
class OddNums

{

  static void
  Main ()

  {

    WriteLine ("Odd numbers from 1 to 99. Prints one number per line");

    string output = "";
    for (int n = 1; n <= 99; n++)

      {

        if (n % 2 != 0)

          {

            output = output + n.ToString () + Environment.NewLine;
          }
      }

    WriteLine (output);
    ReadKey ();
  }
}
}
