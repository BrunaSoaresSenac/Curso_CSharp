namespace Calculosalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aumento, salario;

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

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
