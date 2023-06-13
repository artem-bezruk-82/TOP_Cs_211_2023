using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace material_01_task1
{
    public class Square
    {
        private static int _minSideLength = 1;
        public int _side;
        public int Side 
        {
            get { return _side; }
            set 
            {
                if (value < _minSideLength)
                {
                    throw new ArgumentOutOfRangeException(paramName: nameof(Side), actualValue: value,
                        message: $"Argument is less than {_minSideLength}");
                }
                _side = value;
            } 
        }

        public Square(int side)
        {
            Side = side;
        }

        public Square():this(_minSideLength)
        {
            
        }

        public int GetArea() 
        {
            return (int)Math.Pow(Side, 2);
        }

        public override string ToString()
        {
            return $"Shape: Square; Side: {Side}; Area: {GetArea()};";
        }
    }
}
