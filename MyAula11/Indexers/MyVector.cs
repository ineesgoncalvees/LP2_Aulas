using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public struct MyVector
    {
        public float X { get; set; }
        public float Y { get; set; }

        public MyVector(float x, float y)
        {
            X = x;
            Y = y;
        }


        public float this[int index]
        {
            get
            {
                if (index == 0) { return X; }
                else if (index == 1) { return Y; }
                else { throw new IndexOutOfRangeException(); }
            }
            set
            {
                if (index == 0)
                    X = value;

                else if (index == 1)
                    Y = value;

                else { throw new IndexOutOfRangeException(); }
            }
        }

        public float this[string index] {
            get {
                index = index.ToLower();
                if (index == "0" || index == "a" || index == "x") { return X; }

                else if (index == "1" || index == "b" || index == "y") { return Y; }

                else { throw new IndexOutOfRangeException(); }
            }

            set
            {
                index = index.ToLower();
                if (index == "0" || index == "a" || index == "x")
                    X = value;

                else if (index == "1" || index == "b" || index == "y")
                    Y = value;

                else { throw new IndexOutOfRangeException(); }
            }
        }
    }
}
