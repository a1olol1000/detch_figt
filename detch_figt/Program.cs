Console.Title = "Fighting Game";
string fightu = "kör";
Random general = new Random();
int hitpoint = general.Next(100);
int strength = general.Next(20);
int heal = general.Next(10);
int chans = general.Next(100);
int hitpoint_1 = general.Next(100);
int strength_1 = general.Next(20);
int heal_1 = general.Next(10);
int chans_1 = general.Next(100);
int enemy_choice = general.Next(2);

bool live_1 = true;
bool live_2 = true;


while (fightu == "kör")
{
    Console.WriteLine("fighting game press enter key to start");
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
    heal = general.Next(10);
    if (hitpoint < 50)
    {
        hitpoint = 50;
    }
    if (strength < 5)
    {
        strength = 5;
    }
    if (heal <2)
    {
        heal = 2;
    }
    chans_1 = general.Next(100);
    if (chans_1 < 50)
    {
        chans_1 = 50;
    }
    else if (chans_1 > 90)
    {
        chans_1 = 90;
    }
    hitpoint_1 = general.Next(100);
    strength_1 = general.Next(20);
    heal_1 = general.Next(10);
    if (hitpoint_1 < 50)
    {
        hitpoint_1 = 50;
    }
    if (strength_1 < 5)
    {
        strength_1 = 5;
    }
    if (heal_1 <2)
    {
        heal_1 = 2;
    }
    while (live_1 && live_2)
    {

        bool result = sucsses(chans);
        bool resul_1 = sucsses_1(chans_1);
        bool result_2 = yesno(enemy_choice);
        Console.WriteLine($"You: hp({hitpoint}) str({strength}) hit Chanse({chans}) Heal({heal})");
        Console.WriteLine($"Enemy: hp({hitpoint_1}) str({strength_1}) hit Chanse({chans_1}) Heal({heal_1})");
        Console.WriteLine($"your chans({result}) enemys chans ({resul_1})");
        Console.ReadLine();


        
    }

}


static bool sucsses(int chans)
{
    int chans_chans;
    Random stat = new Random();
    chans_chans = stat.Next(100);
    bool result = false;

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
static bool sucsses_1(int chans_1)
{
    int chans_chans;
    Random stat = new Random();
    chans_chans = stat.Next(100);
    bool result_1 = false;

    if (chans_chans < chans_1)
    {
        result_1 = true;
    }
    else if (chans_chans > chans_1)
    {
        result_1 = false;
    }
    return result_1;
}
static bool yesno(int enemy_choice)
{
    int chans_chans;
    Random stat = new Random();
    chans_chans = stat.Next(100);
    bool result_2 = false;

    if (chans_chans < enemy_choice)
    {
        result_2 = true;
    }
    else if (chans_chans > enemy_choice)
    {
        result_2 = false;
    }
    return result_2;
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
