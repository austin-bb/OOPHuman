// namespace OOPHuman;

  public class Human
  {
      // Properties for Human
      public string Name;
      public int Strength;
      public int Intelligence;
      public int Dexterity;
      public int Health;
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
      public Human(string humanName, int str, int intel, int dex, int hp)
      {
        Name = humanName;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
      }
      // Build Attack method
      public virtual int Attack(Human target)
      {
        int atk = Strength * 5;
        target.Health -= atk;
        Console.WriteLine($"{Name} Attacked {target.Name}!");
        Console.WriteLine($"{target.Name} took {atk} damage and has {target.Health} health remaining.");
        return target.Health;
      }
  }



