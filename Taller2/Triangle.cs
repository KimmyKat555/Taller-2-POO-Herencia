using System;

namespace Geometry
{
    public class Triangle : Rectangle
    {
        private double _c;

        private double _h;

        public double C
        {
            get => _c;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("El lado C debe ser un número positivo.");
                }
                _c = value;
            }
        }
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
        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }
        public override double GetArea()
        {
            return (B * H) / 2;
        }
        public override double GetPerimeter()
        {
            return A + B + C;
        }
        private void ValidateC()
        {
            if (C <= 0)
            {
                throw new ArgumentException("El lado C debe ser un número positivo.");
            }
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