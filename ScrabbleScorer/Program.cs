using System;
using System.Collections.Generic;
using ScrabbleScorer.Models;

namespace Interface
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Scrabble Scorer!");
      Console.WriteLine("Please input a word: ");
      string userInput = Console.ReadLine().ToLower();
      Scrabble userWord = new Scrabble(userInput);

      Console.WriteLine("The score for " + userInput + " is: " + userWord.WordScore());

      Console.WriteLine("Would you like to play again? [Y]/[N]");
      string replay = Console.ReadLine().ToLower();

      if (replay == "y")
      {
        Main();
      } else {
        Console.WriteLine("Thanks for playing!");
      }
    }
  }
}