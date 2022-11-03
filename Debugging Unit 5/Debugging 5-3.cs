using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
class DebugFive3
{
  static void Main (string[] args)
  {
    char letter;
    int number;
    const int LOW = 0;
    const int HIGH = 100;
    const int NUMINROW = 20;
    for (letter = 'A'; letter <= 'Z'; ++letter)
      {
        for (number = LOW; number < HIGH; ++number)
          {
            if (number % NUMINROW == 0)
              Console.WriteLine ("\r\n");
            Console.Write ("{0}{1} ", letter, number.ToString ("D2"));
          }
      }
    Console.ReadKey ();
  }
}
}
