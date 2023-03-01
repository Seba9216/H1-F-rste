// See https://aka.ms/new-console-template for more information
using H1_Første;

Console.WriteLine("Hej, Velkommen til vores lommeregner ! :)");

while (true)
{
    Console.WriteLine("Indtast Venligst et tal ");
    double start = Input.input();
    Console.WriteLine("Indtast venligst et tal");
    double start1 = Input.input();
    if (start1 == 0 || start == 0)
    {
        Console.WriteLine("Vælg et tal andet end 0");
    }
    if (start != 0 && start1 != 0)
    {
        Console.WriteLine("Vælg venligst en regenmetode :)");
        ValgAfRegnemetode.Valg(start, start1);
    }
    Console.WriteLine("Hej");
}

Console.WriteLine("Hej");

Console.WriteLine("Nej din");







