using System;
namespace Perfect
{
class Perfect
{
  public static void Main (string[] args)
  {
    int sum;
    Console.WriteLine ("Perfect numbers between 1 and 10,000");
    for (int i = 1; i <= 10000; i++)
      {
        sum = 0;
        for (int j = 1; j < (i / 2) + 1; j++)
          {
            if (i % j == 0)
              sum = sum + j;
          }
        if (sum == i)
          Console.WriteLine (i);
      }
    Console.ReadKey (true);
  }
}
}
