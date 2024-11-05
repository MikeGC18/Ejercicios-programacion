int Numerodni;
int resto;
Console.WriteLine("Dime el numero de tu dni");
Numerodni = Convert.ToInt32(Console.ReadLine());
resto= Numerodni%23;
switch(resto)
{
    case 0:
        resto=0;
        Console.WriteLine("La letra de tu dni es T");
        break;
    
    case 1:
        resto=1;
        Console.WriteLine("La letra de tu dni es R");
        break;

    case 2:
        resto=2;
        Console.WriteLine("La letra de tu dni es W ");
        break;

    case 3:
        resto=3;
        Console.WriteLine("la letra de tu dni es A");
        break;

    case 4:
        resto=4;
        Console.WriteLine("la letra de tu dni es G");
        break;
    
    case 5:
        resto=5;
        Console.WriteLine("la letra de tu dni es M");
        break;

    case 6:
        resto=6;
        Console.WriteLine("la letra de tu dni es Y");
        break;
    
    default:
        Console.WriteLine("e el DNI introducido está fuera de rango.");
        break;
}

