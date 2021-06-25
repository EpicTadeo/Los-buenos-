using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion_T obj = new Operacion_T();
            string respuesta1;
          do
          {
            Console.WriteLine("Hola, bienvenido te ayudare con tu suma >>>Enter para empezar<<< ");
            Console.ReadKey();
            obj.TadeoCuenta(); 
            Console.WriteLine("Quieres repetir tu programa:  ");
            respuesta1 = Console.ReadLine();

          }
          while (respuesta1 == "si");  
        }
    }
}