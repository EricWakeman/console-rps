using System;

namespace console_rps
{
    public class Game
    {
      public string compChoice = "";
      public string matchResult = "";
      public void StartGame()
      {
        Console.Clear();
        ComputerChoice();
        Console.WriteLine("Lets Play Rock-Paper-Scissors!");
        Console.Write("Type in your choice: ");
        string userChoice = Console.ReadLine().ToUpper();
        Console.Clear();
        Console.WriteLine($"You chose {userChoice}! I chose {compChoice}!");
        matchResult = $"{userChoice} is not a valid choice!";
        if(userChoice == compChoice)
        {
          matchResult = "It's a tie!";
        }
        if(userChoice == "ROCK")
        {
         if(compChoice == "SCISSORS")
          {
            matchResult = "You win!";
          }
          else if(compChoice == "PAPER")
          {
            matchResult = "You Lose!";
          }
        }
        else if(userChoice == "SCISSORS")
        {
          if(compChoice == "PAPER")
          {
            matchResult = "You win!";
          }
          else if(compChoice == "ROCK")
          {
            matchResult = "You Lose!";
          }
        }
        else if(userChoice == "PAPER")
        {
          if(compChoice == "ROCK")
          {
            matchResult = "You win!";
          }
          if(compChoice == "SCISSORS")
          {
            matchResult = "You Lose!";
          }
        }
        Console.WriteLine(matchResult);
        Console.WriteLine("Try again? y/n");
        string userSelection = Console.ReadLine().ToLower();
        if(userSelection == "y")
        {
          StartGame();
        }
        else
        {
          Console.Clear();
          return;
        }
      }
      void ComputerChoice()
      {
        var r = new Random();
        int move = r.Next(1,3);
        if(move == 1)
        {
          compChoice = "ROCK";
        }
        else if(move == 2){
          compChoice = "PAPER";
        }
        else{
          compChoice = "SCISSORS";
        }
      }
    }
}