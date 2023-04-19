do
{

    var bans = new List<string> { "Schere", "Stein", "Papier" };

    int index = Random.Shared.Next(bans.Count);



    Console.WriteLine("Willkommen zum Schere-Stein-Papier Spiel \nWähle eines der Drei aus");
    string ans = Console.ReadLine();

    if (ans == bans[index])
    {
        Console.WriteLine("Unentschieden!");

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Die Auswahl vom Bot war: " + bans[index]);
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Dayyyyummm \nLust den Bot nochmal zu besiegen? (Ja/Nein)");

        string qans = Console.ReadLine();

        if (qans == "Ja")
        {
            continue;
        }
        else
        {
            break;
        }
    }
    else if (bans[index] == "Schere")
    {
        if (ans == "Papier")
        {
            Console.WriteLine("Spieler 2 gewinnt");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl vom Bot war: " + bans[index]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Skill issue... \nLust den Bot nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        else if (ans == "Stein")
        {
            Console.WriteLine("Spieler 1 gewinnt");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl vom Bot war: " + bans[index]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust den Bot nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }

    }
    else if (bans[index] == "Stein")
    {
        if (ans == "Papier")
        {
            Console.WriteLine("Spieler 1 gewinnt");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl vom Bot war: " + bans[index]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gut gemacht! \nLust den Bot nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }


        }
        else if (ans == "Schere")
        {
            Console.WriteLine("Spieler 2 gewinnt");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl vom Bot war: " + bans[index]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Skill issue... \nLust den Bot nochmal zu besiegen? (Ja/Nein)");

            string qans = Console.ReadLine();

            if (qans == "Ja")
            {
                continue;
            }
            else
            {
                break;
            }
        }
    }

}while(true);
