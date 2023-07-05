using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace material_03_task2
{
    public struct Address
    {
        private int _postalIndex;
        public int PostalIndex 
        { 
            get { return _postalIndex; }
            set 
            {
                if (value > 99999 && value <= 999999)
                    _postalIndex = value;
                else
                    throw new ArgumentOutOfRangeException(paramName: nameof(PostalIndex), actualValue: value, 
                        message: $"{nameof(PostalIndex)} must consist of 6 digits" );
            } 
        }
        public string City { get; set; }
        public string Street { get; set; }
        private int _building;
        public int Building 
        {
            get { return _building; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Building), actualValue: value, 
                        message:$"{nameof(Building)} less than zero");
                else
                    _building = value;
            } 
        }

        public override string ToString()
        {
            return $"{PostalIndex}, {City}, {Street}, {Building}";
        }
    }
}
