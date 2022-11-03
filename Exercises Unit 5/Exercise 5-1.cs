using System;

public class SumFiveints
{
  public static void Main (string[] args)
  {
    int sum = 0;
    for (int i = 0; i < 5; i++)
      {
        Console.Write ("Enter an integer: ");
        sum += Convert.ToInt32 (Console.ReadLine ());
      }

    Console.WriteLine ("Sum = " + sum);
  }
}
