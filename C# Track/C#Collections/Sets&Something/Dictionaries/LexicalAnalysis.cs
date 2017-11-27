using System.Collections.Generic;

namespace Treehouse.CodeChallenges
{
  public class LexicalAnalysis 
  {
    public Dictionary<string, int> WordCount = new Dictionary<string, int>();

    public void AddWord(string word) 
    {
      if(WordCount.ContainsKey(word)) 
      {
        WordCount[word] ++;
      } 
      else 
      {
        WordCount.Add(word, 1);
      } 
    }
    
        public Dictionary<string, int> WordsWithCountGreaterThan(int count) 
        {
            Dictionary<string, int> biggerWords = new Dictionary<string, int>();

            foreach(var word in WordCount.Keys)
            {
              if(WordCount[word] > count)
              {
                biggerWords.Add(word, WordCount[word]);
              }
            }
            
            return biggerWords;
        }

  }
}
