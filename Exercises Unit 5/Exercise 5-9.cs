using System;
class Sum200
{

  public static void Main (string[] args)
  {
    int i;
    Console.WriteLine ("Halfway through......");
    int sum = 0;
    for (i = 1; i <= 200; i++)
      {
        sum = sum + i;
        if (i == 100)
          Console.WriteLine ("After 100 nymbers sum is {0}", sum);
      }
    Console.WriteLine ("The sum of integers 1 through 100 is {0}", sum);
    Console.ReadKey ();
  }
}
