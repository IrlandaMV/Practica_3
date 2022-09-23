using System;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroLados;
            double tamanoLado, perimetro;
            Console.WriteLine("Dame el numero de lados");
            numeroLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame la medida de uno de los lados");
            tamanoLado = Convert.ToDouble(Console.ReadLine());

            perimetro = numeroLados * tamanoLado;

            Console.WriteLine("El perimetro es:{0}", perimetro);

        }
    }
}
