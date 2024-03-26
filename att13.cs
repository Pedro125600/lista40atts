using System;

class Program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Digite as notas das três provas:");

      Console.Write("primeira prova: ");
      double n1 = double.Parse(Console.ReadLine());

      Console.Write("segunda prova: ");
      double n2 = double.Parse(Console.ReadLine());

      Console.Write("terceira prova: ");
      double n3 = double.Parse(Console.ReadLine());

      double media = (n1 + n2 + (n3 * 2)) / 4;

      Console.WriteLine("Média do aluno: " + media);

      if (media >= 60)
      {
          Console.WriteLine("Aluno Aprovado!");
      }
      else
      {
          Console.WriteLine("Aluno Reprovado!");
      }
    }
}
