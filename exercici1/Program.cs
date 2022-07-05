using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Class1
    {
        static void Main()
        {
            int N = 5;
            double A = 4.56;
            char C = 'b';
            int b = 97;

            int B = Convert.ToInt32(A);

            int suma = B + N;
            int resta = B - N;
            
            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(C);
            Console.WriteLine(b);
            Console.ReadKey();

            


        }

    }
}