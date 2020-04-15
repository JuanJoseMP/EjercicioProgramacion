using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_programacion_grupo
{

    struct datos
    {
        public string nombre;
        public string autor;
        public int paginas;
        public int ayoPublicacion;

    }

    class añadir_dato
    {

        public static void AñadirDato()
        {
            Datos[] datos = new Datos[50];
            int contador = 0;
            int total = 50;

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Escriba los datos cuando pulse INTRO sin escribir ningun nombre se volvera a abrir el menu \n");

                Console.WriteLine("Fichero {0}", contador + 1);

                Console.WriteLine("Escribe el nombre : ");
                datos[i].nombre = Console.ReadLine();

                if (datos[i].nombre == "")
                {
                    break;
                }

                Console.WriteLine("Escribe el autor : ");
                datos[i].autor = Console.ReadLine();



                Console.WriteLine("Escribe el numero de paginas : ");
                datos[i].paginas = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Escribe el año de publicación : ");
                datos[i].ayoPublicacion = Convert.ToInt32(Console.ReadLine());
                



                contador++;


            }



        }
    }
}
