



using System;

class HistoriaInteractiva
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido a la aventura interactiva!");

       
        Console.WriteLine("¿A dónde quieres ir? 1. Bosque, 2. Montaña, 3. Playa");
        string lugar = Console.ReadLine();

        Console.WriteLine("¿Con quién vas a ir? 1. Amigo, 2. Perro, 3. Solo");
        string companero = Console.ReadLine();

        Console.WriteLine("Preparando tu historia...");

        switch (lugar)
        {
            case "1":
                switch (companero)
                {
                    case "1":
                        Console.WriteLine("Te adentras en el bosque con tu mejor amigo. Juntos encuentran una cabaña misteriosa y pasan una tarde explorándola.");
                        break;
                    case "2":
                        Console.WriteLine("Te adentras en el bosque con tu perro. De repente, él encuentra un mapa antiguo que indica la ubicación de un tesoro escondido!");
                        break;
                    case "3":
                        Console.WriteLine("Vas solo al bosque y disfrutas de la paz y la naturaleza. Sin darte cuenta, encuentras un árbol que habla y que te cuenta la historia de su vida.");
                        break;
                    default:
                        Console.WriteLine("Respuesta no válida. Fin de la historia.");
                        break;
                }
                break;

            case "2":
                switch (companero)
                {
                    case "1":
                        Console.WriteLine("Subes la montaña con tu amigo y, al llegar a la cima, ven un águila majestuosa volando en el horizonte.");
                        break;
                    case "2":
                        Console.WriteLine("Subes la montaña con tu perro y descubren una cueva secreta con oro dentro.");
                        break;
                    case "3":
                        Console.WriteLine("Escalas la montaña solo y, al llegar a la cima te conviertes en un poderoso Dios.");
                        break;
                    default:
                        Console.WriteLine("Respuesta no válida. Fin de la historia.");
                        break;
                }
                break;

            case "3":
                switch (companero)
                {
                    case "1":
                        Console.WriteLine("Vas a la playa con tu amigo y juntos encuentran un cofre enterrado en la arena que contiene algo misterioso.");
                        break;
                    case "2":
                        Console.WriteLine("Vas a la playa con tu perro y juegan en las olas, pero luego se acerca un tsunami.");
                        break;
                    case "3":
                        Console.WriteLine("Vas solo a la playa, disfrutas del sonido de las olas y encuentras al amor de tu vida");
                        break;
                    default:
                        Console.WriteLine("Respuesta no válida. Fin de la historia.");
                        break;
                }
                break;

            default:
                Console.WriteLine("Respuesta no válida. Fin de la historia.");
                break;
        }

        Console.WriteLine("¡Gracias por jugar!");
    }
}



