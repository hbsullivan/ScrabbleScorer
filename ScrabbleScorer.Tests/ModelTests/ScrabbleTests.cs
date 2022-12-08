using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void CreateDictionary_CreateConstructor_DictionaryOfScores()
    {
      Scrabble newScrabble = new Scrabble("garden");
      // Dictionary<int, string> newDictionary = new Dictionary<int, string>() {};
      Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
    }

    [TestMethod]

    public void GetUserWord_ReturnsUserWord_String()
    {
      string userWord = "garden";
      Scrabble newScrabble = new Scrabble(userWord);
      string result = newScrabble.UserWord;
      Assert.AreEqual(userWord, result); 
    }

  }
}