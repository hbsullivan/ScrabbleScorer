using System;
using System.Collections.Generic;

namespace ScrabbleScorer.Models
{
  public class Scrabble
  {

    public string UserWord { get; set; }
    public char[] CharArray { get; }

    private Dictionary<int, string> ScoreDictionary = new Dictionary<int,string>() {{1, "aeioulnrst"}, {2, "dg"}, {3, "bcmp"}, {4, "fhvwy"}, {5, "k"}, {8, "jx"}, {10, "qz"}};

    private int[] ScoreArray = {1,2,3,4,5,8,10};
    public Scrabble(string userWord)
    {
      UserWord = userWord;      
    }
    public char[] StringToArray()
    {
      char[] charArray = UserWord.ToCharArray();
      return charArray;
    }

    public int WordScore() 
    {
      char[] array = this.StringToArray(); // {'g','a','r'...}
      int scoreCounter = 0;
      foreach (char character in array) //'g'
      {
        for (int index = 0; index<ScoreArray.Length; index++) // {1,2,3..}
        {
          int score = ScoreArray[index]; //1
          if (ScoreDictionary[score].Contains(character))
          {
            scoreCounter += score;      
          }
        }
      }
      return scoreCounter;
    }
  }
}