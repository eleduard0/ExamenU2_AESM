using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExamenU2_AESM
{
    internal class Metodos
    {
        
        public void TablaVendedores()
        {
            int[,] tabla = { { 500, 3000, 100, 400 }, { 1000, 150, 200, 500 }, { 250, 1800, 2900, 300 }, { 400, 130, 90, 2400 }, { 60, 20, 4000, 3600, } };
            
            for (int i=0;i < tabla.GetLength(0);i++)
            {
                
                for (int j=0; j < tabla.GetLength(1); j++)
                {
                    Console.WriteLine(tabla[i, j]);
                }

            }

            Console.WriteLine($"\nEl vendedor 1 tuvo una ganancia de {tabla[0,0]+ tabla[1, 0] + tabla[2, 0] + tabla[3, 0] + tabla[4, 0] }");
            Console.WriteLine($"El vendedor 2 tuvo una ganancia de {tabla[0,1]+ tabla[1, 1] + tabla[2, 1] + tabla[3, 1] + tabla[4, 1] }");
            Console.WriteLine($"El vendedor 3 tuvo una ganancia de {tabla[0,2]+ tabla[1, 2] + tabla[2, 2] + tabla[3, 2] + tabla[4, 2] }");
            Console.WriteLine($"El vendedor 4 tuvo una ganancia de {tabla[0,3]+ tabla[1, 3] + tabla[2, 3] + tabla[3, 3] + tabla[4, 3] }");
            
            Console.WriteLine($"\nEl Producto 1 tuvo una ganancia de {tabla[0,0]+ tabla[0, 1] + tabla[0, 2] + tabla[0, 3]  }");
            Console.WriteLine($"El Producto 2 tuvo una ganancia de {tabla[1,0]+ tabla[1, 1] + tabla[1, 2] + tabla[1, 3]  }");
            Console.WriteLine($"El Producto 3 tuvo una ganancia de {tabla[2, 0] + tabla[2, 1] + tabla[2, 2] + tabla[2, 3] }");
            Console.WriteLine($"El Producto 4 tuvo una ganancia de {tabla[3, 0] + tabla[3, 1] + tabla[3, 2] + tabla[3, 3] }");
            Console.WriteLine($"El Producto 5 tuvo una ganancia de {tabla[4, 0] + tabla[4, 1] + tabla[4, 2] + tabla[4, 3] }");


        }

        public void Calificaciones()
        {
            Random rnd = new Random();
            int[] calificaciones = new int[100];

            for (int i =0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = rnd.Next(0,101);
            }

            Console.WriteLine("============Matriz desordenada=============\n");
            
            for (int i = 0; i < calificaciones.Length; i++)
            {
                
                Console.Write(calificaciones[i]+", ");

            }

            int menor =0;
            int posicion = 0;
            int temp = 0;

            for (int i = 0; i <= calificaciones.Length-1; i++)
            {
                menor = calificaciones[i];
                posicion= i;
                for (int j = i+1; j < calificaciones.Length; j++)
                {
                    if (calificaciones[j] > menor)
                    {
                        menor = calificaciones[j];
                        posicion= j;
                    }
                }
                if (posicion != i)
                {
                    temp = calificaciones[i];
                    calificaciones[i] = calificaciones[posicion];
                    calificaciones[posicion] = temp;
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("\n===================Matriz ordenada en forma descendente==================");
            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write(calificaciones[i]+", ");
            }

            Console.WriteLine("\n¿Que numero quieres buscar?");
            int numero = int.Parse(Console.ReadLine());

            int inferior = 0;
            int superior = calificaciones.Length - 1;
            int medio = 0;
            bool encontrado = false;

            while (superior <= inferior) 
            {
                medio = (inferior + superior) / 2;
                if (numero == medio)
                {
                    encontrado = true;
                    break;
                }
                else if (numero < medio)
                {
                    inferior = medio - 1;
                }
                else
                {
                    superior = medio + 1;
                }
            }
            if (encontrado= true)
            {
                Console.WriteLine($"El numero estaba en la posicion {medio}");
            }
            else { Console.WriteLine("No está"); }




        }
    }
}
