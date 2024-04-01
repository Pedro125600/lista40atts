namespace att18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());


            if ((numero % 3 == 0 && numero % 5 != 0) || (numero % 5 == 0 && numero % 3 != 0))
            {
                Console.WriteLine(numero + " é divisível por 3 ou por 5 ");
            }

            else
            {
                Console.WriteLine(numero + " não é divisível por 3 ou por 5, ou é divisível simultaneamente por ambos.");
            }


        }
    }
}
