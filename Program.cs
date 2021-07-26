using System;

namespace VSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            string s1 = Console.ReadLine();
            double valor1 = Convert.ToDouble(s1);

            Console.WriteLine("Digite um valor:");
            string s2 = Console.ReadLine();
            double valor2 = Convert.ToDouble(s2);

            Console.WriteLine("Digite um valor:");
            string s3 = Console.ReadLine();
            double valor3 = Convert.ToDouble(s3);

            if (valor1 < (valor2 + valor3) && valor2 < (valor1 + valor3) && valor3 < (valor1 + valor2))
            {
                Console.WriteLine("É um triângulo");
            }
            else
            {
                Console.WriteLine("NÃO é um triângulo");
            }
        }
    }
}
