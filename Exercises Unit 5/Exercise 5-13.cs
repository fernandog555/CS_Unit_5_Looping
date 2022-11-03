using System;

class CountVowels
{
  static void
  Main ()
  {
    String line = Console.ReadLine ();
    int vowelCount = 0;
    char ch;
    for (int i = 0; i < line.Length; ++i)
      {
        ch = line[i];
        ch = char.ToLower (ch);
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
          {
            vowelCount++;
          }
      }
    Console.WriteLine (vowelCount);
  }
}
