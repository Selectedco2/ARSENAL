using System.Text.Json;


string gtext = File.ReadAllText("goomba.json");

Enemy goomba = JsonSerializer.Deserialize<Enemy>(gtext);
// Enemy goomba = new()
// {
//     Name = "Goomba",
//     Hp = 1
// };

// Enemy fireplant = new()
// {
//     Name = "Fireplant",
//     Hp = 2
// };

// string gtext = JsonSerializer.Serialize(goomba);

// Console.WriteLine(gtext);

// File.WriteAllText("Goomba.json", gtext);

// Console.ReadLine();
