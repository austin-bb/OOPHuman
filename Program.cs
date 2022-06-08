// using OOPHuman;


Human austin = new Human("Austin");
Console.WriteLine("Name: " + austin.Name + " | " + "Strength: " + austin.Strength + " | " + "Intelligence: " + austin.Intelligence + " | " + "Dexterity: " + austin.Dexterity + " | " + "Health: " + austin.Health);

Human bob = new Human("Bob", 5, 1, 3, 150);
Console.WriteLine("Name: " + bob.Name + " | " + "Strength: " + bob.Strength + " | " + "Intelligence: " + bob.Intelligence + " | " + "Dexterity: " + bob.Dexterity + " | " + "Health: " + bob.Health);

// bob.Attack(austin);

Wizard lux = new Wizard("Lux");
Console.WriteLine("Wizards Name: " + lux.Name);

Ninja shen = new Ninja("Shen");
Console.WriteLine("Ninjas Name: " + shen.Name);

Samurai yi = new Samurai("Yi");
Console.WriteLine("Samurais Name: " + yi.Name);


shen.Attack(bob);
lux.Attack(austin);
yi.Attack(austin);