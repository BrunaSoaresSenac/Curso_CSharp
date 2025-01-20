using System.ComponentModel.Design;

namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA+ladoB))
            {
                Console.WriteLine("Os valores informados formam um triângulo.");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("É um triângulo equilátero.");
                }
                else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("É um triângulo isósceles.");
                }
                else
                {
                    Console.WriteLine("É um triângulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triângulo.");
            }
        }
    }
}
