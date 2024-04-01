namespace att40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o custo de fábrica do carro:");
            double custoF = double.Parse(Console.ReadLine());

            double custoC;

            if (custoF <= 12000.00)
            {
                custoC = custoF + (custoF * 0.05); 
            }
            else if (custoF > 12000.00 && custoF <= 25000.00)
            {
                custoC = custoF + (custoF * 0.10) + (custoF * 0.15); 
            }
            else
            {
                custoC = custoF + (custoF * 0.15) + (custoF * 0.20); 
            }

            Console.WriteLine("O custo ao consumidor do carro é: " + custoC);

        }
    }
}
