using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      double num1 = double.Parse(Console.ReadLine());
      
      	Console.Write("Digite mais um número: ");
      double num2 = double.Parse(Console.ReadLine());
      
      double dobro = num1 * num1;
		Console.WriteLine("O dobro deste número é: " + dobro);
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	}
