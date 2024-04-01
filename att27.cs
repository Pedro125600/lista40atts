namespace att27
{
    internal class att27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De a idade de um nadador");
            int id = int.Parse(Console.ReadLine());

            if (id >= 5 && id <= 7)
            {
                Console.WriteLine("Infantil A");
            }
            else if (id >= 9 && id <= 10)
            {
                Console.WriteLine("Infantil B");
            }
            else if (id >= 11 && id <= 13)
            {
                Console.WriteLine("Juvenil A");
            }
            else if (id >= 14 && id <= 17)
            {
                Console.WriteLine("Juvenil B");
            }

            else if (id >= 18)
            {
                Console.WriteLine("Senior");
            }

            else
            {
                Console.WriteLine("NUmero menor que 5");

            }

            Console.ReadLine();
        }
    }
}
