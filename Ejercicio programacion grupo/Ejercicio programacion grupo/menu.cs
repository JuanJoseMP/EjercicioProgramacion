using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_programacion_grupo
{
    class menu
    {
       public static void Menu()
       {
            int menu = 0;

            do
            {
                Console.WriteLine("[1].Añadir un dato");
                Console.WriteLine("[2].Mostrar todos los datos");
                Console.WriteLine("[3].Mostrar dato a partir del tamaño");
                Console.WriteLine("[4].Buscar parialmente un dato");
                Console.WriteLine("[5]. Salir del programa");

                switch (menu)
                {
                    case 1:

                        añadir_dato.AñadirDato();


                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:
                        Salir_programa.Salir();


                        break;


                }




            }

            while (menu != 5);
                {
                    Console.WriteLine("Saliendo");
                }
        }

    }
}


