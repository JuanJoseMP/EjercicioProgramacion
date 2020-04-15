using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_programacion_grupo
{
    class tamaño_datos
    {
        public static void tamañoDatos(int contador, ref datos[] datos)
        {
            Console.WriteLine();
            Console.WriteLine("Para buscar un dato por su tamaño, introduzca un número mínimo de páginas.");
            int pagMin = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < contador; i++)
            {
                if (datos[i].paginas > pagMin)
                {
                    Console.WriteLine("Fichero {0}", i);
                    Console.WriteLine("");
                    Console.WriteLine("Nombre: {0}", datos[i].nombre);
                    Console.WriteLine("Autor: {0}", datos[i].autor);
                    Console.WriteLine("Número de páginas: {0}", datos[i].paginas);
                    Console.WriteLine("Año de publicación: {0}", datos[i].ayoPublicacion);
                }
            }
        }
    }
}
