using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System;

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

    [TestMethod]
    public void WordToArray_ReturnsArrayOfCharacters_CharArray()
    {
      string userWord = "garden";
      Scrabble newScrabble = new Scrabble(userWord);
      char[] expected = new char[] {'g','a','r','d','e','n'};
      char[] result = newScrabble.StringToArray();
      CollectionAssert.AreEqual(expected, result); 
    }

    [TesteMethod]

    public void WordScore_ReturnsScoreOfWord_Int()
    {
      string userWord = "garden";
      Scrabble newScrabble = new Scrabble(userWord);
      int expected = 8;
      int result = newScrabble.WordScore();
    }

  }
}