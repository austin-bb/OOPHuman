public class Wizard : Human
{
  public Wizard(string name) : base(name)
  {
    Name = name;
    Strength = 3;
    Intelligence = 25;
    Dexterity = 3;
    Health = 50;
  }

  public override int Attack(Human target)
  {
    int atk = Intelligence * 5;
    target.Health -= atk;
    Health += atk;
    Console.WriteLine($"{Name} attacked {target.Name} for {atk} damage and healed for {atk}, health is now {Health}!");
    return target.Health;
  }

  public int Heal(Human target)
  {
    int heal = Intelligence * 10;
    target.Health += heal;
    Console.WriteLine($"{Name} healed {target.Name} for {heal} and increased health to {target.Health}!");
    return target.Health;
  }
} 
