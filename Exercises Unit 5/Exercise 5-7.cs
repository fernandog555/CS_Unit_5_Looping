using System;

public class MultiplicationTable
{
  public static void
  Main ()
  {
    int j, n;

    Console.Write ("Input an integer number: ");

    n = Convert.ToInt32 (Console.ReadLine ());

    Console.Write ("\n");
    for (j = 1; j <= 10; j++)
      {
        Console.Write ("{0} X {1} = {2} \n", j, n, n * j);
      }
  }
}
