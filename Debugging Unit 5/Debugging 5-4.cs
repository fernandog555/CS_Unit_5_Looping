/*
    The program requires the user to guess the number of days it takes to make X
    amount of money when doubling the value every day. The starting value is
    $0.01. The program indicates if the guess is too high, or too low.
    */
using System;

using static System.Console;

using System.Globalization;

class DebugFive4
{
  static void
  Main ()
  {

    const double LIMIT = 1000000.00;
    const double START = 0.01;
    string inputString;
    double total;
    int howMany;
    int count;

    Write ("How many days do you think ");
    WriteLine ("it will take you to reach");
    WriteLine (LIMIT.ToString ("C"));
    WriteLine (START.ToString ("C"));
    Write ("{0} starting with {1}", LIMIT.ToString ("C"), START.ToString ("C"),
           CultureInfo.GetCultureInfo ("en-US"));
    WriteLine ("and doubling it every day?");

    inputString = Console.ReadLine ();
    howMany = Convert.ToInt32 (inputString);
    WriteLine (howMany);

    count = 0;
    total = START;
    WriteLine (total);

    while (total <= LIMIT)
      {
        Write ("Total after each loop: " + total + "\n");
        total = total * 2;
        count = count + 1;
      }

    if (howMany > count)
      WriteLine ("Your guess was too high.");
    else
      {
        if (howMany < count)
          WriteLine ("Your guess was too low.");
        else if (howMany == count)
          WriteLine ("Your guess was correct.");
      }
    Write (count);
    WriteLine ("It takes {0} days to reach {1}", count,
               LIMIT.ToString ("C", CultureInfo.GetCultureInfo ("en-US")));
    WriteLine ("when you double {0} every day",
               START.ToString ("C", CultureInfo.GetCultureInfo ("en-US")));
  }
}
