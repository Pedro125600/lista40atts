using System;

class Program
{
    public static void Main(string[] args)
    {
  Console.Write("Digite a altura em metros: ");
  double altura = double.Parse(Console.ReadLine());

  Console.Write("Digite o sexo (F/M): ");
  char sexo = Char.Parse(Console.ReadLine());

  double pesoIdeal = sexo == 'M' ? (72.7 * altura) - 58 : (62.1 * altura) - 44.7;

  Console.WriteLine("O peso ideal :" + pesoIdeal);

      Cosole.ReadLine();
}