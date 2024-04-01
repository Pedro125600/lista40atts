namespace att36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da venda mensal:");
            double venda = double.Parse(Console.ReadLine());

            double comissao;

            if (venda >= 100000)
            {
                comissao = 700 + 0.16 * venda;
                Console.WriteLine("O valor da comissao e de" + comissao);
            }
            else if (venda >= 80000)
            {
                comissao = 650 + 0.14 * venda;
                Console.WriteLine("O valor da comissao e de" + comissao);

            }
            else if (venda >= 60000)
            {
                comissao = 600 + 0.14 * venda;
                Console.WriteLine("O valor da comissao e de" + comissao);

            }
            else if (venda >= 40000)
            {
                comissao = 550 + 0.14 * venda;
                Console.WriteLine("O valor da comissao e de" + comissao);

            }
            else if (venda >= 20000)
            {
                comissao = 500 + 0.14 * venda;
                Console.WriteLine("O valor da comissao e de" + comissao);
            }

            else
            {
                comissao = 400 + 0.14 * venda;
                Console.WriteLine("O valor da comissao e de" + comissao);

            }

            }
    }
}
