namespace att31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura (em metros):");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso (em kg):");
            double peso = double.Parse(Console.ReadLine());

            if (altura < 1.20)
            {
                if (peso < 60)
                {
                    Console.WriteLine("A");
                }
                else if (peso >= 60 && peso <= 90)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("G");
                }
            }
            else if (altura >= 1.20 && altura <= 1.70)
            {
                if (peso < 60)
                {
                    Console.WriteLine("B");
                }
                else if (peso >= 60 && peso <= 90)
                {
                    Console.WriteLine("E");
                }
                else
                {
                    Console.WriteLine("H");
                }
            }
            else
            {
                if (peso < 60)
                {
                    Console.WriteLine("C");
                }
                else if (peso >= 60 && peso <= 90)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine("I");
                }
            }
        }
    }
}