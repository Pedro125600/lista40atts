namespace att34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno:");
            double nota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de faltas do aluno:");
            int faltas = int.Parse(Console.ReadLine());

            if (nota >= 9.0)
            {
           
                if (faltas > 20)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    Console.WriteLine("A");
                }
            }
            else if (nota >= 7.5)
            {
            
                if (faltas > 20)
                {
                    Console.WriteLine("C");
                }
                else
                {
                    Console.WriteLine("B");
                }
            }
            else if (nota >= 5.0)
            {
            
                if (faltas > 20)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("C");
                }
            }
            else if (nota >= 4.0)
            {
       
                if (faltas > 20)
                {
                    Console.WriteLine("E");
                }
                else
                {
                    Console.WriteLine("D");
                }
            }
            else
            {
                if (faltas > 20)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine("E");

                }
            }

        }
    }
}
