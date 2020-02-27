using System;
using Models;

namespace GrowYourOwnPlant
{
  public class Program
  {
    static string plantName;
    static Plant plantOne = new Plant(plantName);
    public static void Main()
    {
      Console.WriteLine("It's time to grow your own plant! What would you like to name your plant?");
      plantName = Console.ReadLine();
      Game();

    }
     
    public static void Game()
    {  
      Console.WriteLine("Keep " + plantName + " alive, to water your plant, type 'water', to feed your plant, type 'food' and to provide sunshine, type'sun'");
      string addPlantHealth = Console.ReadLine().ToLower();
      Console.WriteLine("-----------------------------");
      plantOne.DetermineNextSteps(addPlantHealth);
      Console.WriteLine(plantName + " is " + plantOne.StateOfMind);
      Console.WriteLine(plantOne.PlantTroubles);
      Console.WriteLine(plantName +"'s " + "Health Level: " + plantOne.PlantHealth);
      Console.WriteLine("------------");
      if (plantOne.StateOfMind == "dead")
      {
        Console.WriteLine("Your plant has died");
      }
      else
      {
        Console.WriteLine("Keep playing");
        Game();
      }
    }
  }
}