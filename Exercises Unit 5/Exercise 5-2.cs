using System;

class Program
{
  static void Main (string[] args)
  {
    int number = 1;
    int sum = 0;
    do
      {
        number = int.Parse (Console.ReadLine ());
        if (number != 999)
          {
            sum += number;
          }
        else
          break;
      }
    while (number != 999);

    Console.WriteLine ("The sum is {0}", sum);
  }
}
