int Spielergewinnanzahl = 0;
int Martinggewinnanzahl = 0;


do
{

    var bans = new List<string> { "Schere", "Stein", "Papier" };

    int index = Random.Shared.Next(bans.Count);



    Console.WriteLine("Willkommen zum Schere-Stein-Papier Spiel \nWähle eines der Drei aus");
    string ans = Console.ReadLine();

    if (ans == bans[index]) // hier kekkkkkkkkkkkkkkkk
    {
        Console.WriteLine("Unentschieden!");

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
        Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
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
    else if (bans[index] == "Schere") // hier kekkkkkkkkkkkkkkkk
    {
        if (ans == "Papier")
        {
            Console.WriteLine("Martin gewinnt");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
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
            Console.WriteLine("Du gewinnst");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
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
    else if (bans[index] == "Stein") // hier kekkkkkkkkkkkkkkkk
    {
        if (ans == "Papier")
        {
            Console.WriteLine("Du gewinnst!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Spielergewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
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
            Console.WriteLine("Martin gewinnt!");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Die Auswahl von Martin war: " + bans[index]);
            Martinggewinnanzahl++;
            Console.WriteLine("Siegesanzahl: DU(" + Spielergewinnanzahl + ")  MARTIN(" + Martinggewinnanzahl + ")");
            Console.WriteLine("---------------------------------------");
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

} while (true);