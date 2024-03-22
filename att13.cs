using System;

class Program
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Digite um ano para verificar se é bissexto: ");
      int ano = int.Parse(Console.ReadLine());

      bool bissexto = (ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0);

      string res = bissexto ? "é bissexto." : "não é bissexto.";

      Console.WriteLine(res);

}