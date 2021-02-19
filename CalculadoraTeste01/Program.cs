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
//você pode declarar mais de uma variavel do mesmo tipo de uma vez só
            double valor1,valor2,total;
            
            Console.Write("Digite o valor 1: ");

            valor1 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Digite o valor 2:");

            valor2 = Convert.ToDouble( Console.ReadLine() );
            total = valor1 + valor2;

//você pode mostrar o resultado sem usar +, o resultado pode aparecer em qualquer lugar da frase, ele vai substituir o {0}
            Console.Write("Resultado dasoma é: {0} ",total);
//como agora (na próxima linha), o resultado pode aparecer no começo
            Console.Write("{0} é o resultado ",total);
            Console.ReadKey();


        }
    }
}
