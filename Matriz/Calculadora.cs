using System;


namespace Matriz
{
    internal class Calculadora
    {

        public static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public static string ObterStatusIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 25)
            {
                return "Peso normal";
            }
            else if (imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc < 35)
            {
                return "Obesidade grau I";
            }
            else if (imc < 40)
            {
                return "Obesidade grau II";
            }
            else
            {
                return "Obesidade grau III";
            }
        }

        public static string ObterRecomendacao(double imc)
        {
            if (imc < 18.5)
            {
                return "Você está abaixo do peso. Consulte um nutricionista para orientação.";
            }
            else if (imc < 25)
            {
                return "Você está dentro da faixa de peso normal. Continue mantendo hábitos saudáveis.";
            }
            else if (imc < 30)
            {
                return "Você está com sobrepeso. Procure um profissional para auxiliar na adoção de uma dieta equilibrada e atividades físicas.";
            }
            else if (imc < 35)
            {
                return "Você está com obesidade grau I. É importante buscar orientação médica para controle do peso.";
            }
            else if (imc < 40)
            {
                return "Você está com obesidade grau II. Consulte um médico para acompanhamento e tratamento.";
            }
            else
            {
                return "Você está com obesidade grau III. É fundamental buscar auxílio médico para cuidar da saúde.";
            }
        }
    }


}

