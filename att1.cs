using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Escreva um numero");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro numero");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2 )
            {
                Console.WriteLine("O primeiro numero e maior " + n1);

            }

            else
            { 
                Console.WriteLine("O segundo numero e maior " + n2);
            }

            Console.ReadLine();
        }
    }
}
