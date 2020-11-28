using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6. Sabendo que uma milha marítima equivale a um mil, oitocentos e cinqüenta e dois metros
e que um quilômetro possui mil metros, fazer um programa para converter milhas marítimas em
quilômetros. */
            Conversor con = new Conversor();

            Console.WriteLine("Digite um valor, em milhas: ");
            con.setMilha(double.Parse(Console.ReadLine()));

            con.calcularKm();
            Console.WriteLine("O valor em quilômetros é {0} km",con.getKm());

            Console.ReadKey();
        }
    }
}
