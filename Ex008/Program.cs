namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aviso;
            double velocidade, multa;

            Console.Write("Digite a velocidade: ");
            velocidade = Convert.ToInt32(Console.ReadLine());

            multa = (velocidade - 80) * 7;
            multa = Convert.ToInt32(Console.ReadLine());

            if (velocidade > 81)
            {
                Console.Write("Você foi multado! O valor da multa é de R$ {0}", multa);
            }
            else
            {
                Console.Write("Velocidade dentro do permitido");
            }
        }
    }
}
