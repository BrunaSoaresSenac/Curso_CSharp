namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double nota_final;
            string resultado;

            Console.Write("Digite a nota final do aluno: ");
            nota_final = Convert.ToDouble(Console.ReadLine());

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
