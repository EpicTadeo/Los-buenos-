using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena_de_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {


           
           

            String cad = "";
            Console.WriteLine("ingresa una palabra");
            String pal = Console.ReadLine();
            int t = pal.Length;
            for (int i = t - 1; i >= 0; i--)
            {
                cad = cad + pal.Substring(i, 1);
            }
            

            Console.WriteLine("El texto es: {0}",
              cad);


            Console.WriteLine("En mayúsculas: {0}",
              cad.ToUpper());
            Console.WriteLine(cad);
            Console.ReadLine();

            
        }
    }
}
