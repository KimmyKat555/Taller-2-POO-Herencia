using System;

namespace Geometry
{
    public abstract class GeometricFigure
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public GeometricFigure(string name)
        {
            _name = name;
        }
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return String.Format("{0,-15} => Area: {1,15:F4}   Perimeter: {2,15:F4}",
                                 Name,
                                 GetArea(),
                                 GetPerimeter());
        }
    }
}