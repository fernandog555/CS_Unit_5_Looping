using System;

using static System.Console;

class WebAddress

{

  static void
  Main ()

  {

    Console.WriteLine ("Enter A Business Name");

    string name;

    name = Console.ReadLine ();

    Console.Write ("www.");

    Console.Write (name.Replace (" ", ""));

    Console.Write (".com");
  }
}
