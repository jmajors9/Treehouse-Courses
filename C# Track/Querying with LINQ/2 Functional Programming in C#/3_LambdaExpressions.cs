// copied from Actions and Funcs, with all previous notes removed
using System;

/*
 use lambda expressions for anonymous methods.
 (x) => x + 2
 x goes to x + 2
 if x were one, answer would be three
*/

namespace FunctionalProgramming
{
  class Program
  {

    static void Main(string[] args)
    {
      Action<string> sayGreeting;

      Func<string, string> conversate = message =>
      {
        Console.WriteLine(message);
        return Console.ReadLine();
      };

      string input = conversate("What's your name?");

      sayGreeting = greeting =>
      {
        Console.WriteLine(string.Format(greeting, input));
      };
     
      sayGreeting("Hello, {0}");
      conversate("Nice to see you!");
      conversate("Are you well?");
      sayGreeting("Later, {0}");

    }
  }
}
