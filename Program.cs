using System;

namespace guessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int level = 0;
      int chosenNumber = 0;
      int userGuess = 0;
      int guessCount = 0;
      Console.WriteLine("Hello and Welcome to our Guessing Game. Use only Numbers please!");
      Console.Write("Select a Level; 1-Easy, 2-Medium,3-Hard:     ");
      level = int.Parse(Console.ReadLine());

      if (level == 1)
      {
        chosenNumber = random.Next(1, 10);
        Console.WriteLine("You have chosen EASY: You have 6 tries\nPick a Number between 1 and 10");

        while (guessCount < 6 && userGuess != chosenNumber)
        {
          string input = Console.ReadLine();
          if (int.TryParse(input, out userGuess))
          {
            if (userGuess == chosenNumber)
            {
              Console.WriteLine("You got it right!");
            }
            else
            {
              Console.WriteLine("That was wrong!");
              guessCount++;

              if (guessCount == 6) { Console.WriteLine("Game Over!"); }
              else { Console.WriteLine($"Pick another Number between 1 and 10: You have {6 - guessCount} tries left"); }
            }
          }
          else
          {
            guessCount++;
            Console.WriteLine($"That was not a Number, Please enter a number! You have {6 - guessCount} tries left");
          }
        }
      }
      else if (level == 2)
      {
        chosenNumber = random.Next(1, 20);
        Console.WriteLine("You have chosen MEDIUM: You have 4 tries\nPick a Number between 1 and 20");
        Console.WriteLine(chosenNumber);

        while (guessCount < 4 && userGuess != chosenNumber)
        {
          string input = Console.ReadLine();
          if (int.TryParse(input, out userGuess))
          {
            if (userGuess == chosenNumber)
            {
              Console.WriteLine("You got it right!");
            }
            else
            {
              Console.WriteLine("That was wrong!");
              guessCount++;

              if (guessCount == 4) { Console.WriteLine("Game Over!"); }
              else { Console.WriteLine($"Pick another Number between 1 and 20: You have {4 - guessCount} tries left"); }
            }
          }
          else
          {
            guessCount++;
            Console.WriteLine($"That was not a Number, Please enter a number! You have {4 - guessCount} tries left");
          }
        }
      }
      else if (level == 3)
      {
        chosenNumber = random.Next(1, 50);
        Console.WriteLine("You have chosen HARD: You have 3 tries\nPick a Number between 1 and 50");
        Console.WriteLine(chosenNumber);

        while (guessCount < 3 && userGuess != chosenNumber)
        {
          string input = Console.ReadLine();
          if (int.TryParse(input, out userGuess))
          {
            if (userGuess == chosenNumber)
            {
              Console.WriteLine("You got it right!");
              break;
            }
            else
            {
              Console.WriteLine("That was wrong!");
              guessCount++;

              if (guessCount == 3) { Console.WriteLine("Game Over!"); }
              else { Console.WriteLine($"Pick another Number between 1 and 20: You have {3 - guessCount} tries left"); }
            }
          }
          else
          {
            guessCount++;
            Console.WriteLine($"That was not a Number, Please enter a number! You have {3 - guessCount} tries left");
          }
        }
      }
      else
      {
        Console.WriteLine("Please select A NUMBER for a level. Start Again! Game Over!");
      }
    }
  }
}