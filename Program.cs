using System;
using Models;

namespace GrowYourOwnPlant
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("It's time to grow your own plant! What would you like to name your plant?");
      string plantName = Console.ReadLine().ToLower();

      Plant plantOne = new Plant(plantName);
    }
  }
}