using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
      int metade = num1 / 2;
		Console.WriteLine("A Metade deste número é: " + metade);
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	}
