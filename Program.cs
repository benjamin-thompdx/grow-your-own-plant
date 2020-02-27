using System;
using Models;

namespace GrowYourOwnPlant
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("It's time to grow your own plant! What would you like to name your plant?");
      string plantName = Console.ReadLine();

      Plant plantOne = new Plant(plantName);
      Game();

    void Game()
    {  
      Console.WriteLine("Keep " + plantName + " alive, to water your plant, type 'water', to feed your plant, type 'food' and to provide sunshine, type'sun'");
      string addPlantHealth = Console.ReadLine().ToLower();
      Console.WriteLine("-----------------------------");
      plantOne.DetermineNextSteps(addPlantHealth);
      Console.WriteLine(plantName + " is " + plantOne.StateOfMind);
      Game();
    }
    }
  }
}