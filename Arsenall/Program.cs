global using System.Text.Json;


string contents = File.ReadAllText("weapon.json");

Weapon w = JsonSerializer.Deserialize<Weapon>(contents);

Console.WriteLine("Hur många attacker vill du göra?");

int numAttacks = 0;

string numAttacksStr = "";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
  numAttacksStr = Console.ReadLine();
}

int damageTotal = 0;

for (int i = 0; i < numAttacks; i++)
{ 
    int damage = w.Attack();
    Console.WriteLine($"+{damage}");
    damageTotal += damage;
}

Console.WriteLine($"Du gjorde totalt {damageTotal} damage");




Console.ReadLine();




// Weapon w = new Weapon()
// {
//     Name = "Alban",

// };
// string JsonWeapon = JsonSerializer.Serialize(w);

// File.WriteAllText("weapon.json", JsonWeapon);


