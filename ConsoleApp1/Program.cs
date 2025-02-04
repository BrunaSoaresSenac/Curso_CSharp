using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salario;
            double aumento;

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToInt32(Console.ReadLine());
            aumento = Convert.ToDouble(Console.ReadLine());

            if (salario > 2500)
            {
                aumento = salario * 1.05;
            }
            else if (salario > 1250)
            {
                aumento = salario * 1.10;
            }
            else
            {
                aumento = salario * 1.15;
            }
            Console.WriteLine("O seu novo salário será de R$ {0}", aumento);
        }
    }
}
