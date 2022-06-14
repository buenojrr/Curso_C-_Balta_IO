using System;

namespace Calculator
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
      Console.WriteLine("Wellcome to Calculator App");
      Console.WriteLine("----------------------------");
      Console.WriteLine("Choose the operation: ");
      Console.WriteLine("1 - Addition");
      Console.WriteLine("2 - Subtraction");
      Console.WriteLine("3 - Multiplication");
      Console.WriteLine("4 - Division");
      Console.WriteLine("5 - Exit");
      Console.WriteLine("----------------------------");
      string operation = Console.ReadLine();


      switch (operation)
      {
        case "1":
          Addition();
          break;
        case "2":
          Subtraction();
          break;
        case "3":
          Multiplication();
          break;
        case "4":
          Division();
          break;
        case "5":
          System.Environment.Exit(0);
          break;

      }
    }

    static void Addition()
    {
      Console.Clear();

      Console.WriteLine("Addition");

      Console.WriteLine("Type first value: ");
      int valor1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Type second value: ");
      int valor2 = int.Parse(Console.ReadLine());

      Console.WriteLine($"Result: {valor1 + valor2}");
      Console.ReadKey();

      Menu();

    }


    static void Subtraction()
    {
      Console.Clear();
      Console.WriteLine("Subtraction");

      Console.WriteLine("Type first value: ");
      int valor1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Type second value: ");
      int valor2 = int.Parse(Console.ReadLine());

      Console.WriteLine($"Result: {valor1 - valor2}");
      Console.ReadKey();
      Menu();

    }


    static void Multiplication()
    {
      Console.Clear();
      Console.WriteLine("Multiplication");

      Console.WriteLine("Type first value: ");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Type second value: ");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine($"Result: {valor1 * valor2}");
      Console.ReadKey();
      Menu();

    }

    static void Division()
    {
      Console.Clear();
      Console.WriteLine("Division");

      Console.WriteLine("Type first value: ");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Type second value: ");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine($"Result: {valor1 / valor2}");
      Console.ReadKey();
      Menu();

    }
  }
}
