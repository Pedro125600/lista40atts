using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero");

            int n1 = int.Parse(Console.ReadLine());

            if ( n1 % 2 == 0   )
            {
                Console.WriteLine("Esse numeoro e par");

            }

            else
            {
                Console.WriteLine("Esse numeor e impar");

            }

            Console.ReadLine();
        }
    }
}
