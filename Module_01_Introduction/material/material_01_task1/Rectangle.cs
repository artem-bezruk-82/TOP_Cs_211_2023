using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace material_01_task1
{
    public class Rectangle
    {
        private static int _minSideLength = 1;
        private int _width;
        public int Width 
        { 
            get { return _width; }
            set 
            {
                _width = GetSideValue(propertyName: nameof(Width), value:value, startRange: _minSideLength);
            } 
        }

        private int _height;
        public int Height
        {
            get { return _height; }
            set
            {
                _height = GetSideValue(propertyName: nameof(Height), value: value, startRange: _minSideLength);
            }
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle() : this(_minSideLength, _minSideLength) { }


        public int GetArea() 
        {
            return _width * _height;
        }


        private int GetSideValue(string propertyName, int value, 
            int startRange = int.MinValue, int endRange = int.MaxValue) 
        {
            if (value < startRange || value > endRange) 
            {
                throw new ArgumentOutOfRangeException(paramName: propertyName, actualValue: value,
                    message: $"Argument is out of {startRange}...{endRange} range");
            }
            return value;
        }

        public override string ToString()
        {
            return $"Shape: Rectangle; Width: {Width}; Height: {Height}; Area: {GetArea()};";
        }
    }
}
