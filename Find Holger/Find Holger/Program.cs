Console.WriteLine("Velkommen til find Holger");

Console.WriteLine("Skriv hvor mange rækker du vil have");

string bogstaver = "abcdefghijklmnopqrstuvwxyz";

int size = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();

string holger = ("@" + "  ");

int holgery = rand.Next(1, size + 1);
int holgerx = rand.Next(1, size + 1);

Console.WriteLine("");
for (int x = 0; x <= size; x++)

{
    if (x < 10)
    {
        Console.Write(x + "  ");
    }
    else
    {
        Console.Write(x + " ");
    }

}
Console.WriteLine();
for (int y = 1; y <= size; y++)
{
    if (y < 10)
    {
        Console.Write(y + "  ");
    }
    else
    {
        Console.Write(y + " ");
    }
    for (int j = 1; j <= size; j++)
    {
        if (holgery == y && holgerx == j)
        {
            Console.Write(holger);
        }
        else
        {
            Random random = new Random();

            int index = random.Next(0, bogstaver.Length);

            char randombogstav = bogstaver[index];
            Console.Write(randombogstav + "  ");
        }

    }
    Console.WriteLine();
}

Console.WriteLine("Koordinaterne er   " + holgerx + " X" + " og " + holgery + " Y");


