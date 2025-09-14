using System;

namespace Geometry
{
    public class Kite : Rhombus
    {
        private double _b;

        public new double B
        {
            get => _b;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El lado B debe ser un número positivo.");
                }
                _b = value;
            }
        }
        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            B = b;
        }
        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        private new void ValidateB()
        {
            if (B <= 0)
            {
                throw new ArgumentException("El lado B debe ser un número positivo.");
            }
        }
    }
}