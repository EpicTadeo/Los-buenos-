using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {            
            int numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, numero9, numero10,numero11,numero12,numero13,numero14,numero15,numero16,numero17,numero18,numero19,numero20,resultado;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número:");
                numerosM[i] = int.Parse(Console.ReadLine());
            }     
            Console.WriteLine("Ingrese un número Entero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero11 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero12 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero13 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero14 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero15 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero16 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero17 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero18 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero19 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero20 = int.Parse(Console.ReadLine());
            //Creamos un vector (Array) de enteros con una longitud de 20 elementos
            int[] numerosM = new int[20];

            //Solicitamos al usuario los 10 valores (desordenados)
            //Ordenamos la lista e imprimimos los valores.
            Array.Sort(numerosM); 

            Console.WriteLine("\nLos números ordenados son:");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(numerosM[i]);
            }
            resultado = numero1 + numero2 + numero3 + numero4 + numero5 + numero6 + numero7 + numero8 + numero9 + numero10 +numero11 + numero12 + numero13 + numero14 + numero15 + numero16 + numero17 + numero18 + numero19 + numero20;
            Console.WriteLine("El resultados es: " + resultado);
            Console.ReadLine();
        }



    }
}
