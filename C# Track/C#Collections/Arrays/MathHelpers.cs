// Pulled from treehouse community. Couldn't answer the challenge on my own

using System.Collections.Generic;
using System;

namespace Treehouse.CodeChallenges
{
    public static class MathHelpers
    {
        public static List<int> GetPowersOf2(int powerBase)
        {
            var returnList = new List<int>();
            for (int i = 0; i < powerBase + 1; i++)
            {
                returnList.Add((int)Math.Pow(2, i));
            }
            return returnList;
        }
    }
}
