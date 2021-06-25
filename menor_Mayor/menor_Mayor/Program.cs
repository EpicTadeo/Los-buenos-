using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menor_Mayor
{
   public class Numeros 
    {
        public static void Main(string[] args)
        {

            int a = 0, b = 0, c = 0;
            Console.Write("Escribe el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.Write("Escribe el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.Write("Escribe el tercero numero");
            c = int.Parse(Console.ReadLine());
            

            if (a < b)

                if (a < c)
                    Console.WriteLine("El menor es {0}", a);

                else

                    if (c < b)
                        Console.WriteLine("El menor es {0}", c);
                    else
                        Console.WriteLine("El menor es {0}", b);
            else
                if (b < c)
                    Console.WriteLine("El menor es {0}", b);
                else
                    Console.WriteLine("El menor es {0}", b);
            Console.ReadKey();
        }
    }
}
