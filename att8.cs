using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;


            Console.WriteLine("De a nota entre 0.0 e 10.0");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("De outra nota 0.0 e 10.0");
            n2 = double.Parse(Console.ReadLine());

            if (n1 < 10.0 && n1 > 0.0  && n2 < 10.0 &&  n2 > 0.0)
            {
                double media = (n1 + n2) / 2;
                Console.WriteLine("A media e de : " + media);

            }

            else
            {
                Console.WriteLine("valorde entrada invalido");
            }
                        Console.ReadLine();


        }
    }
}
