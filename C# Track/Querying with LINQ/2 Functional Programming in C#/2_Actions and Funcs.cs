// copied from Delegates, with all previous notes removed
using System;

namespace FunctionalProgramming
{
  class Program
  {

// Actions are generic delegates.

    static void Main(string[] args)
    {

// added an action here.
// enapsulates a method that has a single paramter and does not return a value
      Action<string> sayGreeting;
// func type is a delegate that 
      // has an in and out.
      // let's create a func that will write a message to console and return input from user.

      Func<string, string> conversate = delegate(string message)
      {
        Console.WriteLine(message);
        return Console.ReadLine();
      };

      string input = conversate("What's your name?");

      sayGreeting = delegate(string greeting) //changed from name to greeting
      {
        Console.WriteLine(string.Format(greeting, input));
        // removing name, changing to "input"
      };
     
      sayGreeting("Hello, {0}"); //changed from input
      // Console.ReadLine();
      // sayGreeting = delegate(string name)
      // {
      //   Console.WriteLine(string.Format("Later, {0}", name));
      // };
      conversate("Nice to see you!");
      conversate("Are you well?");
      sayGreeting("Later, {0}");

    }
  }
}
