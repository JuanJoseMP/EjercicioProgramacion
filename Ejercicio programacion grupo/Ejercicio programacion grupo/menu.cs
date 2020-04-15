using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_programacion_grupo
{
    class menu
    {
       public static void Menu()
       {
            datos[] datos = new datos[50];
            int menu = 0;
            int contador = 0;
            añadir_dato añadirDato = new añadir_dato();
            Busqueda_parcial busquedaParcial = new Busqueda_parcial();
            mostrar_datos mostrarDatos = new mostrar_datos();
            tamaño_datos tamañoDatos = new tamaño_datos();

            do
            {
                Console.WriteLine("[1].Añadir un dato");
                Console.WriteLine("[2].Mostrar todos los datos");
                Console.WriteLine("[3].Mostrar dato a partir del tamaño");
                Console.WriteLine("[4].Buscar parialmente un dato");
                Console.WriteLine("[5].Salir del programa");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            añadirDato.AñadirDato(ref contador,ref datos);
                            break;
                        }


                    case 2:
                        {
                            mostrarDatos.MostrarDatos(contador, ref datos);
                            break;
                        }

                        

                    case 3:

                        tamañoDatos.tamañoDatos(contador, ref datos);
                        break;

                    case 4:

                        busquedaParcial.Busqueda(contador, ref datos);
                        break;

                    case 5:

                        break;
                    default: Console.WriteLine("Numero equivocado"); break;


                }




            }

            while (menu != 5);

            Salir_programa.Salir();

        }

    }
}


