namespace ScrabbleScorer.Models
{
  public class Scrabble
  {
    public string UserWord { get; set; }
    public Scrabble(string userWord)
    {
      UserWord = userWord;
    }
  }
}