using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_programacion_grupo
{
    class Busqueda_parcial
    {
        public void Busqueda(int contador,ref datos[] datos)
        {
            Console.WriteLine("Escriba 1 para buscar por autor o 2 para buscar por nombre del libro:");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    {
                        Console.Write("Escriba el nombre del autor: ");
                        string name = Console.ReadLine();
                        for (int i=0;i<contador;i++)
                        {
                            if (datos[i].autor.Contains(name))
                            {
                                Console.WriteLine("Fichero {0}", contador + 1);
                                Console.WriteLine("");
                                Console.WriteLine("Nombre: {0}", datos[i].nombre);
                                Console.WriteLine("Autor: {0}", datos[i].autor);
                                Console.WriteLine("Número de páginas: {0}", datos[i].paginas);
                                Console.WriteLine("Año de publicación: {0}", datos[i].ayoPublicacion);
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Escriba el nombre del libro: ");
                        string name = Console.ReadLine();
                        for (int i = 0; i < contador; i++)
                        {
                            if (datos[i].nombre.Contains(name))
                            {
                                Console.WriteLine("Fichero {0}", contador + 1);
                                Console.WriteLine("");
                                Console.WriteLine("Nombre: {0}", datos[i].nombre);
                                Console.WriteLine("Autor: {0}", datos[i].autor);
                                Console.WriteLine("Número de páginas: {0}", datos[i].paginas);
                                Console.WriteLine("Año de publicación: {0}", datos[i].ayoPublicacion);
                            }
                        }
                        break;
                    }
                default: Console.WriteLine("Número incorrecto,te devuelvo al menú"); break;
            }
        }

    }
}
