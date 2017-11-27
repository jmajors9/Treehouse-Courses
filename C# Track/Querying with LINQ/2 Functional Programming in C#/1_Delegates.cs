using System;
using System.Linq;

namespace FunctionalProgramming
{
  class Program
  {
    delegate void SayGreeting(string name);
    //defines method with no functionality what it will do w/o how

    /*
    public static void SayHello (string name)
    {
      // Console.WriteLine(string.Format("Hello, {0}", name));
      // moved below
    }
    */

     public static void SayGoodbye(string name)
    {
      Console.WriteLine(string.Format("Later, {0}", name));
    }

    static void Main(string[] args)
    {
      // now we'll call sayhello by passing it as a parameter
      // SayGreeting sayGreeting = new SayGreeting(SayHello);
      // telling the delegate to run the sayhello method when it's called
      // now we can call saygreeting like it's a method
/*
      Console.WriteLine("what's your name?");
      string input = Console.ReadLine();
      sayGreeting(input);
      Console.ReadLine();
      sayGreeting = new SayGreeting(SayGoodbye);
      sayGreeting(input);
*/
      // now we clean up the above
      SayGreeting sayGreeting = delegate(string name)
      {
        Console.WriteLine(string.Format("Hello, {0}", name));
        // now the delegate is pointing at an anonymous method
        // we can now delete say hello method because we won't need it. we only run it once
      };


      Console.WriteLine("what's your name?");
      string input = Console.ReadLine();
      sayGreeting(input);
      Console.ReadLine();
      sayGreeting = new SayGreeting(SayGoodbye);
      sayGreeting(input);

    }
  }
}