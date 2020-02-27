namespace Models
{
  public class Plant
  {
    public string Name {get; set;}
    public int PlantHealth {get; set;}

    public string StateOfMind {get; set;}

  public Plant(string name)
  {
    Name = name;
    PlantHealth = 10;
    StateOfMind = "neutral";
  }

  // public void DetermineNextSteps()
  // {
  //   AddWater();
  //   AddFood();
  //   AddSunshine();
  //   UpdateMood();
  //   IsPlantDead();
  // }

  public void UpdateMood()
  {
    if (PlantHealth > 10)
    {
      StateOfMind = "healthy";
    }
    else if( PlantHealth < 10)
    {
      StateOfMind = "unhealthy";
    }
    else if ( PlantHealth == 0)
    {
      StateOfMind = "dead";
    }
  }

  public string IsPlantDead()
  {
    if (StateOfMind == "dead")
    {
      return "Your plant died.";
    }
    else 
    {
      return "Keep playing...";
    }
  }
  public void AddWater()
  {
    PlantHealth += 1;
  }

  public void AddFood()
  {
    PlantHealth += 2;
  }

  public void AddSunshine()
  {
    PlantHealth += 3;
  }

  }
}