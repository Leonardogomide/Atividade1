using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificador de Número Par ou Ímpar");
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }

