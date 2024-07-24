using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simples");
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação (+, -, *, /): ");
            char operacao = Console.ReadKey().KeyChar;
            Console.WriteLine(); 
using System;



    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Calcular");
                Console.WriteLine("2. Sair");

                char escolha = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (escolha)
                {
                    case '1':
                        Calcular();
                        break;
                    case '2':
                        Console.WriteLine("Saindo do programa. Até logo!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void Calcular()
        {
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação (+, -, *, /): ");
            char operacao = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double resultado = 0.0;

            switch (operacao)
            {
                case '+':
                    resultado = valor1 + valor2;
                    break;
                case '-':
                    resultado = valor1 - valor2;
                    break;
                case '*':
                    resultado = valor1 * valor2;
                    break;
                case '/':
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida. Escolha entre +, -, *, ou /.");
                    return;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }

