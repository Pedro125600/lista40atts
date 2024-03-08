using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace att11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um numero inteiro com 4 digitos");
            int n1 = int.Parse(Console.ReadLine());


            if (n1 > 0)
            {

                int n2 = n1 / 1000;
                int n3 = (n1 / 100) % 10;
                int n4 = (n1 / 10) % 10;
                int n5 = (n1 % 10) ;
             

                Console.WriteLine($"{n2} {n3} {n4} {n5}");

                int soma = n2 + n3 + n4 + n5;
                Console.WriteLine("A soma dos algorismos e " + soma );


            }

            else
            {

                Console.WriteLine("Numero invalido");
            }

            Console.ReadLine();

        }
    }
}
