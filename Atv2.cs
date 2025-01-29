using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
      int dobro = num1 * 2;
		Console.WriteLine("O dobro deste número é: " + dobro);
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	}
