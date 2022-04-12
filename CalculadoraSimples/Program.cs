using System;

namespace CalculadoraSimples
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("Informe dois números para calcular e depois escolha a operação desejada");
      Console.WriteLine("Digite o primeiro número:");
      double num1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo número:");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine();

      Console.WriteLine("Escolha a opção desejada:");
      Console.WriteLine("1 - Somar");
      Console.WriteLine("2 - Subtrair");
      Console.WriteLine("3 - Multiplicar");
      Console.WriteLine("4 - Dividir");
      Console.WriteLine("5 - Sair");

      Console.WriteLine();
      short opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: Soma(num1, num2); break;
        case 2: Subtracao(num1, num2); break;
        case 3: Multiplicacao(num1, num2); break;
        case 4: Divisao(num1, num2); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }

    }

    static void Soma(double num1, double num2)
    {
      double resultado = num1 + num2;
      Console.WriteLine($"O resultado da soma é {resultado}");
      Console.ReadKey();
      Menu(); 
    }

    static void Subtracao(double num1, double num2)
    {
      double resultado = num1 - num2;
      Console.WriteLine($"O resultado da subtração é {resultado}");
      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao(double num1, double num2)
    {
      Console.WriteLine($"O resultado da multiplicação é {num1 * num2}");
      Console.ReadKey();
      Menu();
    }

    static void Divisao(double num1, double num2)
    {
      Console.WriteLine($"O resultado da divisão é {num1 / num2}");
      Console.ReadKey();
      Menu();
    }


  }
}
