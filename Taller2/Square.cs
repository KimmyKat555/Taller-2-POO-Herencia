using System;

namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El lado A debe ser un número positivo.");
                }
                _a = value;
            }
        }
        public Square(string name, double a) : base(name)
        {
            A = a;
        }
        public override double GetArea()
        {
            return A * A;
        }
        public override double GetPerimeter()
        {
            return 4 * A;
        }
        private void ValidateA()
        {
            if (A <= 0)
            {
                throw new ArgumentException("El lado A debe ser un número positivo.");
            }
        }
    }
}