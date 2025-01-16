namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite a primeira nota:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média entre {0} e {1} é: {2}", num1, num2, (num1+num2)/2);



            double n1, n2, media;

            Console.Write("Digite a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1+n2)/2;

            Console.WriteLine("Média: {0}", media);
        }
    }
}
