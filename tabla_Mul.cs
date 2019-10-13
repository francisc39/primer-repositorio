using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla_de_multiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla, numero;

            //esta tabla llega hasta el 5 pero se puede cambiar el 5 con el nuemro que yo quiera
            for (tabla = 1; tabla <= 5; tabla++)
            {

                for (numero = 1; numero <= 10; numero++)

                    Console.WriteLine("{0} por {1} es {2}", tabla, numero, tabla * numero);

                Console.WriteLine();

                Console.ReadKey();
            } 
        }
    }
}
