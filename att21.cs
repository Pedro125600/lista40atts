namespace att21
{
    internal class att21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a opção");
            Console.WriteLine("1- Soma de 2 numeros");
            Console.WriteLine("2-diferença entre dois numeros (maior pelo menor)");
            Console.WriteLine("3-produto entre dois numeros");
            Console.WriteLine("Divisão entre dois numeros");

            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um numero  for fazer divisao este e o numerador");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha outro numero se for fazer divisao este e o denominador");
            double n2 = double.Parse(Console.ReadLine());
            double result;

            switch (opcao)
            {
                case 1:
                    result = n1 + n2;
                    Console.WriteLine("A soma e  " + result);
                    break;

                case 2:
                    if (n1 > n2)
                    {
                        result = n1 - n2;

                    }
                    else
                    {
                        result = n2 - n1;

                    }
                    Console.WriteLine("A diferença e" + result);
                    break;

                case 3:
                    result = n1 * n2;
                    Console.WriteLine("O produto e " + result);
                    break;

                case 4:
                    while(n2 == 0)
                    {
                        Console.WriteLine("O denominador não pode ser zero escolha outro");
                            n2 = double.Parse(Console.ReadLine());
                    }
                    result = n1 / n2;
                    Console.WriteLine("A divisão deu " + result);
                    break;


            }
        }
    }
}
