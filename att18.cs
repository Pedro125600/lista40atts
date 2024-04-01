namespace att18._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adição +");
            Console.WriteLine("Subtração -");
            Console.WriteLine("Multiplicação *");
            Console.WriteLine("Divisão /");
            Console.WriteLine("Escolha uma operação matematica");
            char opcao = char.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um numero");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha outro numero");
            double n2 = double.Parse(Console.ReadLine());
            double result;

            switch (opcao)
            {
                case '+': result = n1 + n2;
                    Console.WriteLine( "A adição deu " + result);
                    break;

                case '-':
                    result = n1 - n2;
                    Console.WriteLine("A subtração deu " + result);
                    break;

                case '*':
                    result = n1 * n2;
                    Console.WriteLine("A multiplicação deu " + result);
                    break;

                case '/':
                    result = n1 / n2;
                    Console.WriteLine("A divisão deu " + result);
                    break;


            }

        }
    }
}
