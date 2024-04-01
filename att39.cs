namespace att39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário atual do funcionário:");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tempo de serviço do funcionário em anos:");
            int tempoServico = int.Parse(Console.ReadLine());


            double NovoSalario = 0, bonus;

            if (tempoServico >= 1 && tempoServico <= 3)
            {
                bonus = 100.00;
            }
            else if (tempoServico >= 4 && tempoServico <= 6)
            {
                bonus = 200.00;
            }
            else if (tempoServico >= 7 && tempoServico <= 10)
            {
                bonus = 300.00;
            }
            else if (tempoServico > 10)
            {
                bonus = 500.00;
            }
            else
            {
                bonus = 0;
            }

            if (salario <= 500.00)
            {
                NovoSalario = (salario * 1.25) + bonus;
            }
            else if (salario <= 1000.00)
            {
                NovoSalario = (salario * 1.20) + bonus;
            }
            else if (salario <= 1500.00)
            {
                NovoSalario = (salario * 1.15) + bonus;
            }
            else if (salario <= 2000.00)
            {
                NovoSalario = (salario * 1.10) + bonus;
            }
            else
            {
                Console.WriteLine("O funcionário não tem direito a aumento.");
            }

            Console.WriteLine("O novo salario do funcionario e de " + NovoSalario);

        }
    }
}
