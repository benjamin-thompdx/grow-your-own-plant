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

      Console.WriteLine("Keep " + plantName + " alive, to water your plant, type 'water', to feed your plant, type 'food' and to provide sunshine, type'sun'");
      string addPlantHealth = Console.ReadLine();
      Console.WriteLine("-----------------------------");
      if (addPlantHealth == "water")
      {
        plantOne.AddWater();
        Console.WriteLine("Water added");
        plantOne.UpdateMood();
        Console.WriteLine(plantName + " is " + plantOne.StateOfMind);
        
        Console.WriteLine(plantOne.IsPlantDead());
      }
      else if (addPlantHealth == "food")
      {
        plantOne.AddFood();
        Console.WriteLine("Food added");
        plantOne.UpdateMood();
        plantOne.IsPlantDead();
      }
      else if (addPlantHealth == "sun")
      {
        plantOne.AddSunshine();
        Console.WriteLine("Sun added");
        plantOne.UpdateMood();
        plantOne.IsPlantDead();
      }

      

      
    }
  }
}