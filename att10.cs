using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att10
{
    class Program
    {
        static void Main(string[] args)
        {
            char sexo ;

            Console.WriteLine("Informe o sexo se e M ou F");
            sexo = char.Parse(Console.ReadLine());

            double h,p;

            Console.WriteLine("Informe a Altura");
            h = double.Parse(Console.ReadLine());
            if (sexo == 'M')
            {

                p = (72.7 * h) - 58;
                Console.WriteLine("Seu peso ideal e " + p);

            }

            else
            {
                p = (62.1 * h) - 44.7 ;

                      Console.WriteLine("Seu peso ideal e " + p);
            }

            Console.ReadLine();


        }
    }
}
