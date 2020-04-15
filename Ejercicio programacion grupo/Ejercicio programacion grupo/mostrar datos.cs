using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_programacion_grupo
{
    class mostrar_datos
    {
        public void MostrarDatos(int contador ,ref datos[] datos)
        {
            for(int i = 0; i < contador; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Fichero {0}",contador+1);
                Console.WriteLine("");
                Console.WriteLine("Nombre: {0}", datos[i].nombre);
                Console.WriteLine("Autor: {0}", datos[i].autor);
                Console.WriteLine("Número de páginas: {0}", datos[i].paginas);
                Console.WriteLine("Año de publicación: {0}", datos[i].ayoPublicacion);
            }
        }
    }
}
