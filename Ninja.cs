public class Ninja : Human
{
  public Ninja(string name) : base(name)
  {
    Name = name;
    Strength = 3;
    Intelligence = 3;
    Dexterity = 175;
    Health = 100;
  }

  public override int Attack(Human target)
  {
    int atk = Dexterity * 5;
    Random rand = new Random();
    int x = rand.Next(1, 6);
    if (x == 5)
    {
      target.Health -= 10;
      Console.WriteLine($"{Name} rolled a 5 and dealt additional damage!");
    }      
      target.Health -= atk;
      Console.WriteLine($"{Name} attacked {target.Name} for {atk} damage!");
      return target.Health;      
  }
  public int Steal(Human target)
  {
    int steal = 5;
    target.Health -= steal;
    Health += steal;
    return Health;
  }
}