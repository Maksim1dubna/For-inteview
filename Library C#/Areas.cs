using System;
namespace Library_for_interview
{
    public static class Areas
    {
        public static double AreaCircle(double r)
        {
            double S = r * Math.PI;
            return S;
        }

        public static double AreaTriangle(double a, double b, double c)
        {
            double S;
            if (a + b > c && a + c > b && b + c > a)
            {
                double p = 0.5 * (a + b + c);
                S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                    Console.WriteLine("Прямоугольник");
                else
                    Console.WriteLine("Не прямоугольник");
                return S;
            }
            else
            {
                Console.WriteLine("Треугольника такого типа не существует");
                return 0;
            }
        }
    }
}
