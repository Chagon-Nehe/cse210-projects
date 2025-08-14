using System;

namespace Shapes
{
    public class Shape
    {
        private string _color;

        public Shape(string color)
        {
            _color = color;
        }
        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }
        public virtual double CalculateArea()
        {
            throw new NotImplementedException("This method should be overridden in derived classes.");
        }
    }
}