namespace att41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso em quilogramas:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("O IMC é: "  + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Saudável");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Peso em Excesso");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade Grau II (severa)");
            }
            else
            {
                Console.WriteLine("Obesidade Grau III (mórbida)");
            }
        }
    }
}
