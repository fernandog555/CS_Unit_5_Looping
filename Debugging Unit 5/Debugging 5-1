// Program asks user to enter password If password is not "home", "lady" or
// "mouse" the user must re-enter the password
// DebugFive1.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Debug
{
class DebugFive1
{
  static void Main (string[] args)
  {
    string PASS1 = "home";
    string PASS2 = "lady";
    string PASS3 = "mouse";
    string password;
    Console.Write ("Please enter your password ");
    password = Console.ReadLine ();

    while (password != PASS1 && password != PASS2 && password != PASS3)
      {
        Console.WriteLine ("Invalid password. Please enter again. ");
        password = Console.ReadLine ();
      }
    Console.WriteLine ("Valid password");
    Console.ReadKey ();
  }
}
}
