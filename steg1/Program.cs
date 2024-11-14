
string gissasiffra;

int siffra = 40;

int svar;
int rättsvar = Random.Shared.Next(1, 100);

bool success;

while (siffra == 40)
{

    Console.WriteLine("Gissa ett tal mellan 1-100");
    gissasiffra = Console.ReadLine();
    success = int.TryParse(gissasiffra, out svar);


    if (svar < rättsvar)
    {
        Console.WriteLine("För lågt");
    }
    else if (svar > rättsvar)
    {
        Console.WriteLine("För högt");
    }
    else if (svar == rättsvar)
    {
        Console.WriteLine("rätt");
        siffra++;
    }

}

Console.ReadLine();

Console.WriteLine($" rätt svar var {rättsvar} grattis");
Console.ReadLine();







