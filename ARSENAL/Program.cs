using System.Text.Json;
// ------------------------------------------------------------
// Behöver bara launchas en gång:

//     Warstaff staff  = new() {
//     name = "Warstaff"
// };

// string serialized = JsonSerializer.Serialize(staff);

// File.WriteAllText("weapon.json", serialized);
// ------------------------------------------------------------
string content = File.ReadAllText("weapon.json");

Warstaff Staff = JsonSerializer.Deserialize<Warstaff>(content);

Console.WriteLine("How many meteors do you wanna drop?");

int numAttacks  = 0;
string numAttacksStr = "";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
    numAttacksStr = Console.ReadLine();
}

int damageSum = 0;

Console.ForegroundColor = ConsoleColor.DarkBlue;

for (int i = 0; i < numAttacks; i++)
{
    int damage = Staff.Meteor();
    Console.WriteLine($"+{damage}");
    damageSum += damage;
}

Console.ResetColor();

Console.WriteLine($"You did a total of {damageSum} damage!");

Console.ReadLine();