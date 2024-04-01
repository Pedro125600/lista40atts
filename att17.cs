namespace att17
{
 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular a area de um trapezio");

            Console.WriteLine("Base Maior");
                double bM = double.Parse(Console.ReadLine());

            Console.WriteLine("Base Menor");
                double bm = double.Parse(Console.ReadLine());

            while(bM < 0)
            {
                Console.WriteLine("Base Maior tem que ser maior que 0");
                 bM = double.Parse(Console.ReadLine());
            }

            while (bm < 0)
            {
                Console.WriteLine("Base Maior tem que ser maior que 0");
                bm = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Altura");
            double al = double.Parse(Console.ReadLine());

            double a = ((bM + bm) * al) / 2;


            Console.WriteLine("area do trapezio e de " + a);


        }
    }
}
