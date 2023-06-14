using System;
using System.Globalization;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de IMC");

            Console.Write("Digite o seu peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a sua altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = Calculadora.CalcularIMC(peso, altura);
            Console.WriteLine("O seu IMC é: " + imc.ToString("F2"));

            string status = Calculadora.ObterStatusIMC(imc);
            Console.WriteLine("Status: " + status);

            string recomendacao = Calculadora.ObterRecomendacao(imc);
            Console.WriteLine("Recomendação: " + recomendacao);

            Console.ReadLine();
        }
    }





}

