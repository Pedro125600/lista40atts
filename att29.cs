namespace att29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int n1 = random.Next(1, 100);
            int n2 = random.Next(1, 100);

            int cont = 0 , resp = 0 , acertos = 0 , erros = 0;
            int soma = n1 + n2;
            
            while (cont < 4)
            {
                cont++;

                Console.WriteLine("Qual é a soma de "+ n1 + " + " + n2 +" ?");
                resp = int.Parse(Console.ReadLine());

              

                if (resp == soma)
                {
                    Console.WriteLine("Resposta correta!");
                    acertos++;
                }
                else
                {
                    Console.WriteLine($"Resposta errada");
                    erros++;
                }
            }
            Console.WriteLine("A resposta correta e " + soma);

            Console.WriteLine("Voce acertou " + acertos + " e errou " + erros);

        }
    }
}
