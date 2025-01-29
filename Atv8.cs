using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      double num1 = double.Parse(Console.ReadLine());
      
      double absoluto = Math.Abs (num1);
		Console.WriteLine("O valor absoluto deste número é: " + absoluto);
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	}
