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

            double resultado = 0.0;

            if (operacao == '+')
            {
                resultado = valor1 + valor2;
            }
            else if (operacao == '-')
            {
                resultado = valor1 - valor2;
            }
            else if (operacao == '*')
            {
                resultado = valor1 * valor2;
            }
            else if (operacao == '/')
            {
                if (valor2 != 0)
                {
                    resultado = valor1 / valor2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Operação inválida. Escolha entre +, -, *, ou /.");
                return;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }

