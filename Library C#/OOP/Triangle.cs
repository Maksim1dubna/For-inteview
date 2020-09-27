using System;

namespace AreaLibrary_OOP
{
    public class Triangle : IProcessArea
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException("Треугольника такого типа не существует");
            }
        }

        public bool IsRightTriangle()
        {
            if (Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double ProcessArea()
        {
            double p = 0.5 * (A + B + C);

            return Math.Sqrt((p * (p - A) * (p - B) * (p - C)));
        }
    }
}
