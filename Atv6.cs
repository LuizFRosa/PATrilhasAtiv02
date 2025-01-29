using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
      double raiz = Math.Sqrt (num1);
		Console.WriteLine("A Raiz deste número é: " + raiz);
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	}
