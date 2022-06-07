using OOPHuman;


Human austin = new Human("Austin");
Console.WriteLine("Name: " + austin.Name + " | " + "Strength: " + austin.Strength + " | " + "Intelligence: " + austin.Intelligence + " | " + "Dexterity: " + austin.Dexterity + " | " + "Health: " + austin.Health);

Human bob = new Human("Bob", 5, 1, 3, 150);
Console.WriteLine("Name: " + bob.Name + " | " + "Strength: " + bob.Strength + " | " + "Intelligence: " + bob.Intelligence + " | " + "Dexterity: " + bob.Dexterity + " | " + "Health: " + bob.Health);

bob.Attack(austin);