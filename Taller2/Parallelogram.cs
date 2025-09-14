using System;

namespace Geometry
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("La altura H debe ser un número positivo.");
                }
                _h = value;
            }
        }
        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }
        public override double GetArea()
        {
            return B * H;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        private void ValidateH()
        {
            if (H <= 0)
            {
                throw new ArgumentException("La altura H debe ser un número positivo.");
            }
        }
    }
}
