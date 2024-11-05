

using System.Formats.Asn1;

int Altura;
int Base;
int Area;
Console.WriteLine("Dime una altura");
Altura= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dime una base");
Base= Convert.ToInt32(Console.ReadLine());
Area= (Base*Altura)/2;
Console.WriteLine("La area es {0}",Area);




