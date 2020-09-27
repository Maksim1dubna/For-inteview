using System;

namespace AreaLibrary_OOP
{
    public class Circle : IProcessArea
    {
        private double _radius;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Радиус не может быть меньше 0");
                }

                _radius = value;
            }
        }

        public double ProcessArea()
        {
            return Radius * Math.PI;
        }
    }
}
