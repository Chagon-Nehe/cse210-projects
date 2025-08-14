using System;
namespace Shapes
{
    public class Square : Shape
    {
        private double _sideLength;
        public Square(string color, double sideLength) : base(color)
        {
            _sideLength = sideLength;
        }
        public double GetSideLength()
        {
            return _sideLength;
        }
        public void SetSideLength(double sideLength)
        {
            _sideLength = sideLength;
        }
        public override double CalculateArea()
        {
            return _sideLength * _sideLength;
        }
    }    
}