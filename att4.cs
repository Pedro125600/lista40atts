using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att4
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("De um numero Positivo ");
            double n1 = int.Parse(Console.ReadLine()), n2 , n3;

            if (n1 > 0)
            {

                n2 = Math.Sqrt(n1);
                n3 = Math.Pow(n1,2);
                Console.WriteLine("A raiz quadrado  deste numero e : " + n2);
                Console.WriteLine("A raiz quadrado  deste numero e : " + n3);

            }

            else
            {
           
                Console.WriteLine("O numero não e positivo ");
            }

            Console.ReadLine();



        }
    }
}
