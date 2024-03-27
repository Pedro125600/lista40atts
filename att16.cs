using System;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Digite um número de 1 a 12 para representar o mes:");
      int numero = int.Parse(Console.ReadLine());

      switch (numero)
      {
          case 1:
              Console.WriteLine("Janeiro");
              break;
          case 2:
              Console.WriteLine("Fevereiro");
              break;
          case 3:
              Console.WriteLine("Março");
              break;
          case 4:
              Console.WriteLine("Abril");
              break;
          case 5:
             Console.WriteLine("Maio");
              break;
          case 6:
              Console.WriteLine("Junho");
              break;
          case 7:
              Console.WriteLine("Julho");
              break;
          case 8:
              Console.WriteLine("agosto");
              break;
          case 9:
              Console.WriteLine("setembro");
              break;
          case 10:
              Console.WriteLine("outubro");
              break;
          case 11:
              Console.WriteLine("novembro");
              break;
          case 12:
              Console.WriteLine("dezembro");
              break;
          default:
              Console.WriteLine("Número inválido");
              break;
      }

    
    }
}
