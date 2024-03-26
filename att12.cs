using System;

class Program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Digite um número inteiro:");
        int numero = int.Parse(Console.ReadLine());

        while (numero <= 0)
        {
            Console.WriteLine("Número inválido");
            numero = int.Parse(Console.ReadLine());

        }

        double logaritmo = Math.Log(numero);
        Console.WriteLine("O logaritmo de " + numero + "=" + logaritmo);
    }
}