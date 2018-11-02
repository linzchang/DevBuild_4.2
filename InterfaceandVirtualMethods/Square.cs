using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandVirtualMethods
{
    class Square : Shape, IShape
    {
        #region Data Members
        private float _side;
        #endregion

        #region Properties
        public float Side
        {
            set
            {
                _side = value;
            }
            get
            {
                return _side;
            }
        }
        #endregion

        #region Constructors
        public Square()
        {
            _side = 0;
        }

        public Square(float side)
        {
            _side = side;
        }
        #endregion

        #region Methods
        public override void Draw()
        {
            Console.WriteLine("Hi, I am a square!");
        }

        public float GetArea()
        {
            return Side * Side;
        }
        #endregion
    }
}
