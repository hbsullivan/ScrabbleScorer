using System;

namespace ScrabbleScorer.Models
{
  public class Scrabble
  {

    public string UserWord { get; set; }
    public char[] CharArray { get; }
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

    }
  }
}