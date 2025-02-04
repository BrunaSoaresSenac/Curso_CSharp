using System;

namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidade, multa;

            Console.Write("Digite a velocidade: ");
            velocidade = Convert.ToDouble(Console.ReadLine());

            if (velocidade > 81)
            {
                multa = (velocidade - 80) * 7;
                Console.Write("Você foi multado! O valor da multa é de R$ {0}", multa);
            }
            else
            {
                Console.Write("Velocidade dentro do permitido");
            }
        }
    }
}
