
string fightu = "kör";
Random general = new Random();
int hitpoint = general.Next(100);
int strength = general.Next(20);
int chans = general.Next(100);
int heal = general.Next(20);
int chans_chans = general.Next(100);


bool live_1 = true;
bool live_2 = true;


while (fightu == "kör")
{
    Console.WriteLine("fighting game press any key to start");
    Console.ReadLine();
    chans = general.Next(100);
    if (chans < 50)
    {
        chans = 50;
    }
    else if (chans > 90)
    {
        chans = 90;
    }
    hitpoint = general.Next(100);
    strength = general.Next(20);
    if (hitpoint < 50)
    {
        hitpoint = 50;
    }
    if (strength < 5)
    {
        strength = 5;
    }
    while (live_1 && live_2)
    {
        chans_chans = general.Next(100); 
        
        Console.WriteLine($"hp({hitpoint}) str({strength}) hit Chanse({chans}) hit({sucsses})");
        Console.ReadLine();
        
    }

}


static bool sucsses(int chans_chans, int chans)
{
    Random stat = new Random();
    chans_chans = stat.Next(100);
    if (chans_chans < chans)
    {
        result = true;
    }
    else if (chans_chans > chans)
    {
        result = false;
    }
    return result;
}



Console.ReadLine();

// Random general = new Random();

// int hitRoll = general.Next(100);

// Console.WriteLine(hitRoll);

// if (hitRoll > 95)
// {
//     Console.WriteLine("crit");
// }
// else if (hitRoll > 40)
// {
//     Console.WriteLine("hit");
// }
// else
// {
//     Console.WriteLine("miss");
// }
// Console.ReadLine();
