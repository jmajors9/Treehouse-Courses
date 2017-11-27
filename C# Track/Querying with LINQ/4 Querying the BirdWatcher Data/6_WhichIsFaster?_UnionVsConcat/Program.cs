/*

union looks over two diff sequences and attempts to see if each element already exists before adding it to a new enumerable

concat looks over two seq, mashes into one
a distinct.. something

*/

using System;
using System.Diagnostics;
using System.Linq;

namespace UnionVsConcat
{
  class Program
  {
    public static void Main(string[] args)
    {
      var listA = Enumerable.Range(0, 100000);
      var listB = Enumerable.Range(50000, 100000);

      Stopwatch stopWatch = new Stopwatch();
      
      stopWatch.Start();
      var listC = listA.Union(listB);
      stopWatch.Stop();
      var unionTicks = stopWatch.ElapsedTicks; //a tick is a 10000th of a millisecond

      stopWatch.Restart();
      var listD = listA.Concat(listB).Distinct();
      stopWatch.Stop();
      var concatTicks = stopWatch.ElapsedTicks;

      Console.WriteLine(string.Format("Union took {0} ticks.", unionTicks));
      Console.WriteLine(string.Format("Concat took {0} ticks.", concatTicks));

      if (unionTicks > concatTicks)
      {
        Console.WriteLine("Concat is faster by {0} ticks", (unionTicks - concatTicks));
      }
      else if (concatTicks > unionTicks)
      {
       Console.WriteLine("Union is faster by {0} ticks", (concatTicks - unionTicks)); 
      }

    }
  }
}