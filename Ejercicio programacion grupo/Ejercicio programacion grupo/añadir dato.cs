using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_programacion_grupo
{

    class añadir_dato
    {
        
        
        public void AñadirDato(ref int contador,ref datos[] datos)
        {


                Console.WriteLine("Fichero {0}", contador + 1);

                Console.WriteLine("Escribe el nombre : ");
                datos[contador].nombre = Console.ReadLine();



                Console.WriteLine("Escribe el autor : ");
                datos[contador].autor = Console.ReadLine();



                Console.WriteLine("Escribe el numero de paginas : ");
                datos[contador].paginas = Convert.ToInt32(Console.ReadLine());
            if (datos[contador].ayoPublicacion < 1)
            {
                datos[contador].ayoPublicacion = 1;
                Console.WriteLine("No es posible tener un libro de 0 páginas o negativas,se cambia el nº automáticamente.");
            }


            Console.WriteLine("Escribe el año de publicación : ");
                datos[contador].ayoPublicacion = Convert.ToInt32(Console.ReadLine());
            if (datos[contador].ayoPublicacion>2020)
            {
                datos[contador].ayoPublicacion = 2020;
                Console.WriteLine("No es posible haber publicado un libro en el futuro,se cambia la fecha automáticamente.");
            }



                contador++;






        }
    }
}
