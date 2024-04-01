namespace att28
{
    internal class att28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de x");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de z");
            int z = int.Parse(Console.ReadLine());


            Console.WriteLine("Escolha uma média:");
            Console.WriteLine("a - Média Geométrica");
            Console.WriteLine("b - Média Ponderada");
            Console.WriteLine("c - Média Harmônica");
            Console.WriteLine("d - Média Aritmética");
            char opcao = char.Parse(Console.ReadLine());
            double result = 0;
            switch(opcao)
            {
                case 'a':
                   result = Math.Sqrt(x * y * z);
                    Console.WriteLine("O resultado da Média Geométrica e " + result);
                    break;

                case 'b':
                    result = (x + 2 * y + 3 * z) / 6;
                    Console.WriteLine("O resultado da Média Ponderada e " + result);
                    break;

                case 'c':
                    result = 3 / (1 / x + 1 / y + 1 / z);
                    Console.WriteLine("O resultado da Média Harmônica e " + result);
                    break;

                case 'd':
                    result = (x + y + z) / 3;
                    Console.WriteLine("O resultado da Média Geométrica e " + result);
                    break;

            }

        }
    }
}
