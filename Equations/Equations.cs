using System;
using System.Collections.Generic;
using System.Text;

namespace Equations
{
    public abstract class BaseEquations
    {
        public BaseEquations()
        {

        }
        public BaseEquations(double a1, double b1, double c1)
        {
            c1 = c;
            b1 = b;
            a1 = a;
        }

        public abstract void RootsEquation();
        public abstract void Print();

        protected bool NORoots = false;
        protected double x1;
        protected double x2;
        protected double a;
        protected double b;
        protected double c;
    }

    public class LinearEquations : BaseEquations
    {
        public LinearEquations()
        {

        }
        public LinearEquations(double b1, double c1) //: BaseEquations(a1, b1, c1)
        {
            b = b1;
            c = c1;
        }


        public override void RootsEquation()
        {
            if (b == 0)
            {
                NORoots = true;
                Console.WriteLine("b = 0 это не линейное уравнение");
                //                throw "b = 0 это не линейное уравнение";
                return;
            }
            x1 = -c / b;
            //            throw new NotImplementedException();
        }
        public override void Print()
        {
            Console.WriteLine(b);
            Console.WriteLine(c > 0 ? "*x + " : "*x ");
            Console.WriteLine(c);
            Console.WriteLine(" = 0");
            if (NORoots)
            {
                Console.WriteLine("Корней нет");
            }
            else
            {
                Console.WriteLine(" Корень x = ");
                Console.WriteLine(x1);
            }
            //            throw new NotImplementedException();
        }
    }

    public class QuadraticEquations : BaseEquations
    {
        public QuadraticEquations()
        {

        }

        public QuadraticEquations(double a1, double b1, double c1) //:BaseEquations(a1, b1, c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        public override void Print()
        {
            Console.WriteLine(a);
            Console.WriteLine(b > 0 ? "*x^2 + " : "*x^2 ");
            Console.WriteLine(b);
            Console.WriteLine(c > 0 ? "*x + " : "*x ");
            Console.WriteLine(c);
            Console.WriteLine(" = 0");
            if (NORoots)
            {
                Console.WriteLine("Корней нет");
            }
            else
            {
                Console.WriteLine(" Корни: x1 = ");
                Console.WriteLine(x1);
                Console.WriteLine(", x2 = ");
                Console.WriteLine(x2);
            }
        }
        public override void RootsEquation()
        {
            if (a == 0)
            {
                Console.WriteLine("a = 0 это не квадратное уравнение");
                //                throw "a = 0 это не квадратное уравнение";
                return;
            }

            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                NORoots = true;
                return;
            }
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);

        }

    }
}
