using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_programacion_grupo
{

    class añadir_dato
    {
        
        
        public void AñadirDato(ref datos[] datos)
        {
<<<<<<< HEAD
            datos[] datos = new datos[50];
            int contador = 0;
=======
>>>>>>> bd1da4e4ef57c26efe7fc93bf040ebd24be551b5
            int total = 50;
            int contador = 0;
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
