namespace att22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a idade do trabalhador:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tempo de serviço (em anos):");
            int tempo = int.Parse(Console.ReadLine());

            if (idade >= 65 || tempo>= 30 || (idade >= 60 && tempo >= 25))
            {
                Console.WriteLine("O trabalhador pode se aposentar.");
            }
            else
            {
                Console.WriteLine("O trabalhador ainda não pode se aposentar.");
            }
        }
    }
}
