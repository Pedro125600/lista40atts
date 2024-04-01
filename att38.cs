namespace att38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o dia de nascimento:");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês de nascimento:");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano de nascimento:");
            int ano = int.Parse(Console.ReadLine());

            if (mes >= 1 && mes <= 12)
            {
                if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && (dia >= 1 && dia <= 30))
                {
                    Console.WriteLine("Data válida.");
                }

                else if ((mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && (dia >= 1 && dia <= 31))
                {
                    Console.WriteLine("Data válida.");
                }
                else
                {
                    Console.WriteLine("Data inválida.");
                }
            }


            else if (mes == 2)
            {
                if (ano % 4 == 0 && (ano % 100 != 0 || ano % 400 == 0))
                {

                    if (dia >= 1 && dia <= 29)
                    {
                        Console.WriteLine("Data válida.");
                    }
                    else
                    {
                        Console.WriteLine("Data inválida.");
                    }
                }
                else
                {

                    if (dia >= 1 && dia <= 28)
                    {
                        Console.WriteLine("Data válida.");
                    }
                    else
                    {
                        Console.WriteLine("Data inválida.");
                    }
                }
            }


        }
    }
}
