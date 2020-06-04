using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static int val = 3;
        static int[,] numeros = new int[val, val];//3X3
        static void Main(string[] args)
        {
            string linea;
            for (int f=0;f<val;f++)
            {
                for (int c = 0; c < val; c++)
                {
                    Console.WriteLine("f: "+f+"  c: "+c+"\n\n");
                    Console.Write("Ingrese un valor: ");
                    linea = Console.ReadLine();
                    numeros[c, f] = int.Parse(linea);
                }
            }
            Console.WriteLine("\n----------------------------------\n");
            for (int f = 0; f < val; f++)
            {
                for (int c = 0; c < val; c++)
                {
                    Console.WriteLine("Valor: "+numeros[c,f]);
                    
                }
            }

            Console.ReadKey();
        }
    }
}
