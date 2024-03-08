using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att9
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2,n3;

            Console.WriteLine("Informe seu salario");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a prestação de um emprestimo");
            n2 = double.Parse(Console.ReadLine());

            n3 = (100 * 20) / n1;


            if (n2 > n3 )
            {
                Console.WriteLine("Empréstimo não concedido");

            }

            else
            {
                Console.WriteLine("Empréstimo concedido");
            }


            Console.ReadLine();
        }
    }
}
