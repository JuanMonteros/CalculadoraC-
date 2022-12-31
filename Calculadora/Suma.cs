using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Suma
    {
        private int numeroA;
        private int numeroB;

        public int NumeroA { get => numeroA; set => numeroA = value; }
        public int NumeroB { get => numeroB; set => numeroB = value; }

        public Suma(int _numA,int _numB)
        {
            numeroA = _numA;
            numeroB = _numB;

        }
        public int Resultado() => numeroA + numeroB;
    }
}
