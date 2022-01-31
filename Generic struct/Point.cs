using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_struct
{
    struct Point<T>
    {
        private T xPos;
        private T yPos;

        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        public override string ToString() => $"[{X}, {Y}]";

        public void ResetPoint()
        {
            X = default(T);
            Y = default(T);
        }
    }
}
