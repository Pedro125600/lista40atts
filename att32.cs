namespace att32
{
    internal class att32
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Cachorro Quente 100 1.20");
            Console.WriteLine("Bauru Simples 101 1.30");
            Console.WriteLine("Bauru com Ovo 102 1.50");
            Console.WriteLine("Hamburguer 103 1.20");
            Console.WriteLine("Cheeseburguer 104 1.70");
            Console.WriteLine("Suco 105 2.20");
            Console.WriteLine("Refrigerante 106 1.00");


            Console.WriteLine("\nDigite o código do produto escolhido:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

    
            double precoTotal = 0;

            switch (codigo)
            {
                case 100:
                    precoTotal = 1.20 * quantidade;
                    Console.WriteLine("Valor total a ser pago: " + precoTotal);
                    break;
                case 101:
                    precoTotal = 1.30 * quantidade;
                    Console.WriteLine("Valor total a ser pago: " + precoTotal);
                    break;
                case 102:
                    precoTotal = 1.50 * quantidade;
                    Console.WriteLine("Valor total a ser pago: " + precoTotal);
                    break;
                case 103:
                    precoTotal = 1.20 * quantidade;
                    Console.WriteLine("Valor total a ser pago: " + precoTotal);
                    break;
                case 104:
                    precoTotal = 1.70 * quantidade;
                    Console.WriteLine("Valor total a ser pago: " + precoTotal);
                    break;
                case 105:
                    precoTotal = 2.20 * quantidade;
                    Console.WriteLine("Valor total a ser pago: " + precoTotal);
                    break;
                case 106:
                    precoTotal = 1.00 * quantidade;
                    Console.WriteLine("Valor total a ser pago: " + precoTotal);
                    break;
                default:
                    Console.WriteLine("Código de produto inválido.");
                    break;
               
            }

         
        }
    }

}
    

