using System;

namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double nota_final, n1, n2, n3, n4;
            string resultado;

            Console.Write("Digite a primeira nota do aluno: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota do aluno: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4) / 4;

            if (nota_final >= 70)
            {
                resultado = "Aprovado";
                if (nota_final >= 95)
                {
                    resultado = "Aprovado com louvor";
                }
            }
            else if (nota_final >= 45)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }

            Console.WriteLine("Nota do aluno: {0} - Resultado: {1} ", nota_final, resultado);
        }
    }
}
