using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacion
{
    class Operacion_T
    {
         private  double suma;
         private  double res;
         private string linea;
         
        public double SUMA
        {
            get { return this.suma; }
            set { this.suma = value;}
        }
        public double RES
        {
            get { return this.res; }
            set { this.res = value; }
        }
        public string LINEA
        {
            get { return this.linea; }
            set { this.linea = value; }
        }
        public void TadeoCuenta()
        {
            do
            {
                Console.Write("Ingrese los numeros:");
                linea = Console.ReadLine();
                RES = double.Parse(linea);
                if (RES > 0)
                {
                    SUMA = SUMA + RES;


                }
            } while (RES > 0);
            
            Console.WriteLine();
            Console.WriteLine("TOTAL: " + SUMA);
            if (RES < res)

                if (RES < RES)
                    Console.WriteLine("El menor es {0}", LINEA);

                else

                    if (RES < RES)
                        Console.WriteLine("El menor es {0}", RES);
                    else
                        Console.WriteLine("El menor es {0}", LINEA);
            else
                if (RES < RES)
                    Console.WriteLine("El menor es {0}", LINEA);
                else
                    Console.WriteLine("El menor es {0}", LINEA);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();           
        }
    }
}
