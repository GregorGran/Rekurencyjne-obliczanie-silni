using System.IO.Enumeration;

static int Silnia(int x)
{
    if (x < 1)
    {
        return 0;
    }
    else if (x == 1) 
    {
        return 1;
    }
    else
    {
        return x * Silnia(x - 1);
    }
}
static void ObliczSilnie()
{
    for (int i = 1; i < 15; i++)
    {
        Console.WriteLine($"{i}!= {Silnia(i)}");
    }
}
ObliczSilnie();