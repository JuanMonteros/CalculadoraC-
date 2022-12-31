using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suma sum = new Suma(10, 5);
            int res=sum.Resultado();
            Console.WriteLine(res);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
