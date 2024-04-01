namespace att33
{
    internal class att33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço antigo do produto:");
            double precoAntigo = double.Parse(Console.ReadLine());


         
            double precoNovo = 0;

            if (precoAntigo <= 50)
            {
                precoNovo = precoAntigo + (precoAntigo * 0.05);
                Console.WriteLine("O preço novo do produto é: R$" + precoNovo);
            }
            else if (precoAntigo > 50 && precoAntigo <= 100)
            {
                precoNovo = precoAntigo + (precoAntigo * 0.10);
  
                Console.WriteLine("O preço novo do produto é: R$" + precoNovo);
            }
            else
            {
                precoNovo = precoAntigo + (precoAntigo * 0.15);
                Console.WriteLine("O preço novo do produto é: R$" + precoNovo);
            }


            if (precoNovo <= 80)
            {
                Console.WriteLine("Barato");
            }
            else if (precoNovo > 80 && precoNovo <= 120)
            {
                Console.WriteLine("Normal");
            }
            else if (precoNovo > 120 && precoNovo <= 200)
            {
                Console.WriteLine("Caro");
            }
            else
            {
                Console.WriteLine("Muito caro");
            }
        }
    }
}
    

