#region One of Two
/*
using System.Collections.Generic;
using System.Linq;

namespace Treehouse.CodeChallenges
{
    public class NumberAnalysis
    {
        private List<int> _numbers;
        public NumberAnalysis()
        {
            _numbers = new List<int> { 2, 4, 6, 8, 10 };
        }
        
        public IEnumerable<int> NumbersGreaterThanFive()
        {
            return _numbers.Where(number => (number > 5));
        }
    }
}
*/
#endregion

#region Two of Two
using System.Collections.Generic;
using System.Linq;

namespace Treehouse.CodeChallenges
{
    public class NumberAnalysis
    {
        private List<int> _numbers;
        public NumberAnalysis()
        {
            _numbers = new List<int> { 2, 4, 6, 8, 10 };
        }
        
        public IEnumerable<int> NumbersGreaterThanFive()
        {
            return _numbers.Where(number => (number > 5));
        }

        public IEnumerable<int> ReverseNumbers()
        {
            return _numbers.OrderByDescending(number => _numbers);
        }

    }
}
#endregion