using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("De um numero ");
            double n1 = int.Parse(Console.ReadLine()), n2;

            if (n1 > 0)
            {

                n2 = Math.Sqrt(n1);

                Console.WriteLine("A raiz quadrado  deste numero e : " + n2);
            }

            else
            {
                n2 = Math.Pow(n1,2);
                Console.WriteLine("O munero elevado ao quadrado e : " + n2);
            }

            Console.ReadLine();





        }
    }
}
