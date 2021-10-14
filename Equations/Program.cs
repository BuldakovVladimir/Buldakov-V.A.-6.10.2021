using System;

namespace Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BaseEquations sas = new LinearEquations(2, 3);
            sas.RootsEquation();
            sas.Print();
            BaseEquations sas1 = new QuadraticEquations(1, 1, -6);
            sas1.RootsEquation();

            sas1.Print();
        }
    }
}
