using System;

	  class Program
	{
		  public static void Main()
		{
		Console.Write("Digite um número: ");
      int num1 = int.Parse(Console.ReadLine());
      
      	Console.Write("Digite mais um número: ");
      int num2 = int.Parse(Console.ReadLine());
      
      int subtracao = num2 - num1;
		Console.WriteLine("A Subtração destes números é: " + subtracao);
      
        Console.WriteLine("Pressione qualquer tecla para encerrar...");
        Console.ReadKey();
		}
	
