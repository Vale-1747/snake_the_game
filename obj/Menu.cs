using System.Collections;
using System.Diagnostics;

namespace snake_the_game;

public class Menu
{
    public static void Show()
    {
        string[] opciones = { "Jugar", "Ver Tabla", "Salir" };
    
        while (true)
        {
            int opcion = MenuSeleccionar(opciones, "SNAKE THE GAME");

            switch(opcion)
            {
                case 0:
                    Console.WriteLine("Jugar");
                    Console.ReadKey();
                    break;

                case 1:
                    Console.WriteLine("Ver Tabla");
                    Console.ReadKey();
                    break;

                case 2:
                    return;
            }
        }
    }
}