using System;

	  class Program
	{
		  public static void Main()
		{
			  Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
        Console.Write("Digite mais um número: ");
      int num2 = int.Parse(Console.ReadLine());
      
      int soma = num1 + num2;
			  Console.WriteLine("A soma dos números é: " + soma);
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	}
