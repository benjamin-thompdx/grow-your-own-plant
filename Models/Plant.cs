using System;

namespace Models
{
  public class Plant
  {
    public string Name {get; set;}
    public int PlantHealth {get; set;}

    public string StateOfMind {get; set;}
    public string PlantTroubles {get; set;}

  public Plant(string name)
  {
    Name = name;
    PlantHealth = 5;
    StateOfMind = "neutral";
    PlantTroubles = " ";
  }

  public void DetermineNextSteps(string addPlantHealth)
  {
    if (addPlantHealth == "water")
    {
      AddWater();
      RemoveHealth();
      UpdateMood();
    }
    else if (addPlantHealth == "food")
    {
      AddFood();
      RemoveHealth();
      UpdateMood();
      
    }
    else if (addPlantHealth == "sun")
    {
      AddSunshine();
      RemoveHealth();
      UpdateMood();
      
    }
  }

  private void UpdateMood()
  {
    if (PlantHealth >= 10)
    {
      StateOfMind = "healthy";
    }
    else if( PlantHealth < 10 && PlantHealth >= 1)
    {
      StateOfMind = "unhealthy";
    }
    else if ( PlantHealth < 1)
    {
      StateOfMind = "dead";
    }
  }

  private void AddWater()
  {
    PlantHealth += 1;
  }

  private void AddFood()
  {
    PlantHealth += 2;
  }

  private void AddSunshine()
  {
    PlantHealth += 3;
  }

  private void RemoveHealth()
  {
    var rand = new Random();
    int index = rand.Next(4);

    if (index == 1)
    {
      PlantHealth -= 1;
      PlantTroubles = "Oh no, a windstrom damaged your plant!";
    }
    else if (index == 2)
    {
      PlantHealth -= 2;
      PlantTroubles = "Yikes, there was an aphid attack!";
    }
    else if (index == 3)
    {
      PlantHealth -= 3;
      PlantTroubles = "Your plant was bit by a slug!";
    }
   
  }

  }
}