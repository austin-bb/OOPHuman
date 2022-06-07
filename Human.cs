namespace OOPHuman
{
  class Human
  {
      // Properties for Human
      public string Name {get; set; }
      public int Strength {get; set; }
      public int Intelligence {get; set; }
      public int Dexterity {get; set; }
      public int Health {get; set; }
      // Add a constructor that takes a value to set Name, and set the remaining fields to default values
      public Human(string humanName)
      {
        Name = humanName;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
      }
      // Add a constructor to assign custom values to all fields
      public Human(string humanName, int str, int intel, int Dex, int hp)
      {
        Name = humanName;
        Strength = str;
        Intelligence = intel;
        Dexterity = Dex;
        Health = hp;
      }
      // Build Attack method
      public int Attack(Human target)
      {
        int atk = Strength * 5;
        target.Health -= atk;
        Console.WriteLine($"{Name} Attacked {target.Name}!");
        Console.WriteLine($"{target.Name} took {atk} damage and has {target.Health} health remaining.");
        return target.Health;
      }
  }

}

