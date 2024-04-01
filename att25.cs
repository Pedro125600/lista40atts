namespace att25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores de a, b e c");

            Console.Write("a:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b:");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c:");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Não é uma equação de segundo grau.");
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Não existe raiz real.");
            }
            else if (delta == 0)
            {
                double raiz = -b / (2 * a);
                Console.WriteLine("Raiz única:" + raiz);
            }
            else
            {
                double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Raiz 1:" + raiz1);
                Console.WriteLine("Raiz 2:" + raiz2);
            }
        }
    }
}
