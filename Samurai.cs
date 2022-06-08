public class Samurai : Human
{
  public Samurai(string name) : base(name)
  {
    Name = name;
    Strength = 3;
    Intelligence = 3;
    Dexterity = 3;
    Health = 200;
  }

  public override int Attack(Human target)
  {
    base.Attack(target);
    if (target.Health < 50)
    {
      target.Health = 0;
      Console.WriteLine($"{Name} has depleated {target.Name}'s health");
    }
    return target.Health;
  }

  public int Meditate()
  {
    Health = 200;
    Console.WriteLine($"{Name} Meditates and restores health to full");
    return Health;
  }
}