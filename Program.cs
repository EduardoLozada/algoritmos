using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
 
namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("1. Sumar dos numeros");
                    Console.WriteLine("2. representar bases");
                    Console.WriteLine("3. Salir");                    
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Primer Numero");
                            int vl_iNumero1 = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Segundo Numero");
                            int vl_iNumero2 = Int32.Parse(Console.ReadLine());
                            int vl_sResultado = 0;                            
                            vl_sResultado = vl_iNumero1 + vl_iNumero2;
                            Console.WriteLine("La suma de los dos numeros es " + vl_sResultado + " \n") ;                            
                            break;

                        case 2:
                            Console.WriteLine("Numero");
                            int vl_iNumero = Int32.Parse(Console.ReadLine());                            
                            Console.WriteLine("Base");
                            int vl_iBase= Int32.Parse(Console.ReadLine());
                            int vl_iCociente = vl_iNumero * vl_iBase
                                ;
                            while (Convert.ToInt32(vl_iCociente / vl_iBase) > 1)
                            {
                                vl_iCociente = Convert.ToInt32(vl_iCociente / vl_iBase);
                                Console.WriteLine(vl_iCociente + ":" + vl_iBase + "|"+ vl_iCociente / vl_iBase + "|" + vl_iCociente % vl_iBase + "\n");                                
                            }
                            break;

                        case 3:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            Environment.Exit(0);
                            break;                       
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();

        }
    }
}