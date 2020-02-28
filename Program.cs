using System;
using Models;

namespace GrowYourOwnPlant
{
  public class Program
  {
    static string plantName;
    static Plant plantOne = new Plant(plantName);
    static string addPlantHealth;
    public static void Main()
    {
      Console.WriteLine("It's time to grow your own plant! What would you like to name your plant?");
      plantName = Console.ReadLine();
      Game();

    }
     
    public static void Game()
    {  
      Console.WriteLine("Keep " + plantName + " alive, to water your plant, type 'water', to feed your plant, type 'food' and to provide sunshine, type'sun'");
      addPlantHealth = Console.ReadLine().ToLower();
      if (addPlantHealth == "water" || addPlantHealth == "food" || addPlantHealth == "sun")
      {
        KeepPlaying();
      }
      else 
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Please enter a valid command");
        Console.ResetColor();
        KeepPlaying();
      }
    }

    public static void KeepPlaying()
    {
      Console.WriteLine("-----------------------------");
      plantOne.DetermineNextSteps(addPlantHealth);
      Console.WriteLine(plantOne.PlantTroubles);
      Console.WriteLine(plantName + " is " + plantOne.StateOfMind);
      Console.WriteLine(plantName +"'s " + "Health Level: " + plantOne.PlantHealth);
      Console.WriteLine("------------");
      if (plantOne.StateOfMind == "dead")
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Your plant has died");
        Console.WriteLine("--------------------");
      }
      else if (plantOne.StateOfMind == "full growth") 
      {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(plantName + " is at full growth - You've won the game!");
        Console.WriteLine("--------------------");
      }
      else
      {
        Console.WriteLine("Keep playing");
        Console.WriteLine("--------------------");
        Game();
      }
    }
  }
}