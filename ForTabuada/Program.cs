using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Digite um número da tabuada:");


            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }
            Console.ReadLine();

        }
    }
}