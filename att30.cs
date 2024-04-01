namespace att30
{
    internal class att30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero:");
          
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");

            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero:");

            int n3 = int.Parse(Console.ReadLine());

       
            int menor, meio, maior;

            if (n1 <= n2 && n1 <= n3)
            {
                menor = n1;
                if (n2 <= n3)
                { 
                    meio = n2;
                    maior = n3;
                }
                else
                {
                    meio = n3;
                    maior = n2;
                }
            }

            else if (n2 <= n1 && n2 <= n3)
            {
                menor = n2;
                if (n1 <= n3)
                {
                    meio = n1;
                    maior = n3;
                }
                else
                {
                    meio = n3;
                    maior = n1;
                }
            }
            else
            {
                menor = n3;
                if (n1 <= n2)
                {
                    meio = n1;
                    maior = n2;
                }
                else
                {
                    meio = n2;
                    maior = n1;
                }
            }

            Console.WriteLine("Números em ordem crescente:" + " " + menor +" "+ meio + " "+maior);
        }
    }
}
