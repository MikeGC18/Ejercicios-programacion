// See https://aka.ms/new-console-template for more information
using System;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce tu peso en kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Introduce tu altura en metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine($"Tu IMC es: {imc:F2}");

        if (imc < 18.5)
            Console.WriteLine("Bajo peso.");
        else if (imc <= 24.9)
            Console.WriteLine("Peso normal.");
        else if (imc <= 29.9)
            Console.WriteLine("Sobrepeso.");
        else
            Console.WriteLine("Obesidad.");
    }
}

