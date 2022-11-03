using System;
public class TippingTable3
{
  public static void
  Main ()
  {
    double dinnerPrice;
    double tipRate;
    double tip;

    double LOWRATE;
    double MAXRATE;
    const double TIPSTEP = 0.05;
    double MAXDINNER;
    const double DINNERSTEP = 10.00;

    Console.Write ("What is lowest tipping percentage ");
    LOWRATE = Convert.ToDouble (Console.ReadLine ());

    Console.Write ("What is Highest tipping percentage ");
    MAXRATE = Convert.ToDouble (Console.ReadLine ());

    Console.Write ("What is lowest restaurent bill ");
    dinnerPrice = Convert.ToDouble (Console.ReadLine ());

    Console.Write ("What is highest restaurent bill ");
    MAXDINNER = Convert.ToDouble (Console.ReadLine ());
    Console.Write (" Price");
    for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
      Console.Write ("{0, 8}", tipRate.ToString ("F"));
    Console.WriteLine ();
    Console.WriteLine ("----------------------------------------");

    tipRate = LOWRATE;

    while (dinnerPrice <= MAXDINNER)
      {
        Console.Write ("{0, 8}", dinnerPrice);
        while (tipRate <= MAXRATE)
          {
            tip = dinnerPrice * tipRate;
            Console.Write ("{0, 8}", tip.ToString ("F"));
            tipRate += 0.05;
          }
        dinnerPrice += DINNERSTEP;
        tipRate = LOWRATE;
        Console.WriteLine ();
      }
  }
}
