var bans = new List<string>{ "Schere", "Stein", "Papier"};

int index = Random.Shared.Next(bans.Count);



Console.WriteLine("Willkommen zum Schere-Stein-Papier Spiel \nWähle eines der Drei aus");
string ans = Console.ReadLine();

if (ans == bans[index])
{
    Console.WriteLine("Unentschieden!");
}
else if (ans != bans[index])
{
    Console.WriteLine("Spieler 2 gewinnt!");
}
else
{
    Console.WriteLine("Spieler 1 gewinnt");
}


Console.WriteLine("Die Auswahl vom Bot war: " + bans[index]);

