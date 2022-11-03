using System;
namespace HomeSales
{
class Program
{
  static void Main (string[] args)
  {
    char ch = 'D';
    int sum = 0, sumD = 0, sumE = 0, sumF = 0, value, highestSale;
    string highestSalesPerson;
    while (true)
      {
        Console.WriteLine ("Enter the" + "initial for salesperson "
                           + "D,E,F and Z to terminate");
        string input = Console.ReadLine ().Trim ();
        if (!string.IsNullOrEmpty (input))
          {
            ch = Convert.ToChar (input);
          }
        else
          {
            ch = 'w';
          }
        if (ch == 'd' || ch == 'D')
          {
            Console.WriteLine ("Please" + "enter the sale amount");
            value = Convert.ToInt32 (Console.ReadLine ());
            sum = sum + value;
            sumD = sumD + value;
          }
        else if (ch == 'e' || ch == 'E')
          {
            Console.WriteLine ("Please" + "enter the sale amount");
            value = Convert.ToInt32 (Console.ReadLine ());
            sum = sum + value;
            sumE = sumE + value;
          }
        else if (ch == 'f' || ch == 'F')
          {
            Console.WriteLine ("Please" + "enter the sale amount");
            value = Convert.ToInt32 (Console.ReadLine ());
            sum = sum + value;
            sumF = sumF + value;
          }
        else if (ch == 'z' || ch == 'Z')
          {
            break;
          }
        else
          {
            Console.WriteLine ("Sorry - invalid salesperson");
          }
      }

    if (sumD > sumE && sumD > sumF)

      {

        highestSalesPerson = "Danielle";

        highestSale = sumD;
      }

    else if (sumE > sumF)

      {

        highestSalesPerson = "Edward";

        highestSale = sumE;
      }

    else

      {

        highestSalesPerson = "Francis";

        highestSale = sumF;
      }

    Console.WriteLine ("\nTotal sale" + "of Danielle is: {0:c}", sumD);

    Console.WriteLine ("\nTotal sale" + "of Edward is: {0:c}", sumE);

    Console.WriteLine ("\nTotal sale" + "of Francis is: {0:c}", sumF);

    if (sumD.Equals (sumE) || sumD.Equals (sumF) || sumE.Equals (sumF))
      {
        Console.WriteLine (
            "\nThere was a tie"); // Case 2: The program indicates there is tie
      }
    else
      {
        Console.WriteLine ("\nHighest" + "sales person is :{0}"
                               + "\nHighest sale is {1:c}",
                           highestSalesPerson, highestSale);
        Console.WriteLine ("\nGran" + "Total sale is: {0:c}", sum);
      }
    Console.ReadLine ();
  }
}

}
