namespace att20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento do lado A:");
            double ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do lado B:");
            double ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do lado C:");
            double ladoC = double.Parse(Console.ReadLine());


            if (ladoA < ladoB + ladoC && ladoB < ladoA + ladoC && ladoC < ladoA + ladoB)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("É um triângulo equilátero.");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("É um triângulo isósceles.");
                }
                else
                {
                    Console.WriteLine("É um triângulo escaleno.");
                }
            }

            else
            {
                Console.WriteLine("Os valores informados não formam um triângulo.");
            }
        }
    }
}
