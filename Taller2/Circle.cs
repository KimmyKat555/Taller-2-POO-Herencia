using System;

namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El radio R debe ser un número positivo.");
                }
                _r = value;
            }
        }
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }
        private void ValidateR()
        {
            if (R <= 0)
            {
                throw new ArgumentException("El radio R debe ser un número positivo.");
            }
        }
    }
}

