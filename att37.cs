namespace att37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora da chegada");
            int horaChegada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os minutos chegada");
            int minutosChegada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora da saida");
            int horaSaida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os minutos saida");
            int minutosSaida = int.Parse(Console.ReadLine());

            int horasEstacionamento = horaSaida - horaChegada;
            int minutosEstacinamento = minutosSaida - minutosChegada;

            double preco;

            if (minutosEstacinamento > 60)
            {
                horasEstacionamento = horasEstacionamento + 1;
            }

            if (minutosEstacinamento < 0)
            {
                minutosEstacinamento =  minutosEstacinamento + 60;
                horasEstacionamento--;
            }


            if (horasEstacionamento <= 2)
            {
                preco = horasEstacionamento * 1.00;
            }

            else if (horasEstacionamento <= 4)
            {
                preco = horasEstacionamento * 1.40;

            }

            else
            {
                preco = horasEstacionamento * 2.00;

            }

            Console.WriteLine("O preco do estacionamento e " + preco);
        }
    }
}



    
    

