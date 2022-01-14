using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Trojka<T>
    {
        public T A
        {
            get;
            set;
        }

        public T B
        {
            get;
            set;
        }

        public T C
        {
            get;
            set;
        }

        public Trojka(T a, T b, T c)
        {
            A = a;
            B = b;
            C = c;
        }

        override public string ToString()
        {
            string napis = $"({A}, {B}, {C})";
            return napis;
        }

        public void Sort()
        {
            List<T> list = new List<T>();
            list.Add(A);
            list.Add(B);
            list.Add(C);
            list.Sort();
            A = list[0];
            B = list[1];
            C = list[2];
        }

        public T this[int nr]
        {
            get
            {
                if (nr == 0)
                {
                    return A;
                }
                else if (nr == 1)
                {
                    return B;
                }
                else if (nr == 2)
                {
                    return C;
                }
                return default;
            }
            set
            {
                if (nr == 0)
                {
                    A = value;
                }
                else if (nr == 1)
                {
                    B = value;
                }
                else if (nr == 2)
                {
                    C = value;
                }

            }
        }
    }
}
