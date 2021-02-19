using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTeste01
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor1;
            double valor2;
            double total;



            Console.Write("Digite o valor 1: ");

            valor1 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Digite o valor 2:");

            valor2 = Convert.ToDouble( Console.ReadLine() );
            total = valor1 + valor2;


            Console.Write("Resultado dasoma é: " + total);

            Console.ReadKey();


        }
    }
}
