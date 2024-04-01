namespace att24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto:");
            double valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o estado destino do produto:");
            Console.WriteLine("1 - MG");
            Console.WriteLine("2 - SP");
            Console.WriteLine("3 - RJ");
            Console.WriteLine("4 - MS");
            int opcao = int.Parse(Console.ReadLine());
            double precoFinal = 0;

            switch (opcao)
            {
                case 1:
                   precoFinal = valorProduto * (1 +  0.07); 
                    Console.WriteLine("O peço do produto e de " + precoFinal);
                    break;
                case 2:
                    precoFinal = valorProduto * (1 + 0.12);
                    Console.WriteLine("O peço do produto e de " + precoFinal);
                    break;
                   
                case 3:
                    precoFinal = valorProduto * (1 + 0.15);
                    Console.WriteLine("O peço do produto e de " + precoFinal);
                    break;
                case 4:
                    precoFinal = valorProduto * (1 + 0.08);
                    Console.WriteLine("O peço do produto e de " + precoFinal);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

        }
    }
}
