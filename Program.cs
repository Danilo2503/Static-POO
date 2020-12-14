using System;

namespace Static_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.RealParaDolar(52));
            Console.WriteLine(Conversor.DolarParaReal(52));

            Console.WriteLine(Conversor.RealParaEuro(52));
            Console.WriteLine(Conversor.EuroParaReal(52));
        }
    }
}
