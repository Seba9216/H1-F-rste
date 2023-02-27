// See https://aka.ms/new-console-template for more information
using H1_Første;

Console.WriteLine("Hej, Velkommen til vores lommeregner ! :)");

Console.WriteLine("Indtast Venligst et tal ");

string start = Input.input();
bool valid = Input.isValid(start);

if (valid)
{
    Console.WriteLine("Indtast venligst et tal");
    string start1 = Input.input();
    bool valid1 = Input.isValid(start1);
    if (valid1)
    {
        int tal1 = Convert.ToInt32(start1);
        int tal = Convert.ToInt32(start);
        Console.WriteLine("Vælg venligst en regenmetode :)"); 
        Minus.minus(tal1, tal);
    }


}





