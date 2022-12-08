# _Scrabble Scorer_

#### By _Henry Sullivan and Robert Onstott_

#### _Makes a console application that takes a word and returns the Scrabble score for that word._

## Technologies Used

* _C Sharp_
* _.Net 6.0_

## Description

_This program will calculate the score of a given Scrabble word according to the official letter point values in the board game Scrabble. It does not account for extra word score multipliers on the board itself._

## Setup/Installation Requirements

* _Clone the repo from github_
* _Open a console_
* _Navigate to the ScrabbleScorer directory in your console_
* _Enter the dotnet run command_
  `$ dotnet run'
* _Enter your scrabble word when prompted and recieve your score_
* _Enter y if you would like to check another word_

## Specs
UI:
1) Take a word from user
    Message: "Enter a word"
    Read input

    ***Run Business

2) Print Answer
    Message: "The score for" + word + "is" + answer.
  


Business:
1) Create dictionary with scrabble scores ex.{1, "aeiou"}, {2, dg};

2) Gather input as string ex. "hello"

3) Convert string to an array ex. {'h', 'e', 'l', 'l', 'o'}

4) Loop through the character array. Compare character against score values in Dictionary. Increment score counter using if/else logic.


## Known Bugs

* _No known bugs_

## License

MIT License

Copyright (c) [2022] [Henry Sullivan and Robert Onstott]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.