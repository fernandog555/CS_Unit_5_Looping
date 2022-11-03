using System;

class DailyTemps
{
  static void Main (string[] args)
  {
    int number = 0;
    int sum = 0;
    int temp;

    Console.WriteLine (
        "Please enter your series of high temperatures and enter 999 when you are done.");
    do
      {
        temp = int.Parse (Console.ReadLine ());
        if (temp == 999)
          break;
        if (temp < -20 || temp > 130)
          Console.WriteLine (
              "Valid temperatures range from -20 to 130. Please reenter temperature.");
        else
          {
            sum += temp;
            number++;
          }
      }
    while (true);

    Console.WriteLine ("The sum is {0}", sum);
    Console.WriteLine ("Number of temperatures entered is {0}", number);
    Console.WriteLine ("Average temperature is {0}", (float) sum / number);
  }
}
