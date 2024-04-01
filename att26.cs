namespace att26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("km gastos no percurso ");
            double km = double.Parse(Console.ReadLine());

            Console.WriteLine("litros gastos no percurso ");
            double litros = double.Parse(Console.ReadLine());


            if (km / litros < 8)
            {
                Console.WriteLine("Venda o carro!");
            }

            else if (km / litros >= 8 && km / litros <= 14)
            {
                Console.WriteLine("Economico");
            }

            else
            {
                Console.WriteLine(" Super Economico!");

            }
        }
    }
}
