/*
     * This program displays a multiplication table of the product of every
     * integer from 1 through 10 multiplied by every integer from 1 through 10.
     *
     */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayMultiplicationTable
{
class Program
{
  static void Main (string[] args)
  {
    int value = 10;

    for (int x = 1; x <= value; ++x)

      Console.Write ("{0, 4}", x);
    Console.WriteLine ();
    Console.WriteLine ("_________________________________________");

    for (int x = 1; x <= value; ++x)

      Console.WriteLine ("{0, 4}", x);

    for (int row = 1; row <= value; ++row)
      {
        for (int column = 1; column <= value; ++column)
          {

            Console.Write ("{0, 4}", row * column);
          }
        Console.WriteLine ();
      }
    Console.ReadLine ();
  }
}
}
