using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN1lab
{
    class triangleFunction : functionMembership
    {
        private int a,b,c;

        public triangleFunction(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double triangeY(double x)
        {
            double y = 0.0;
            if (a <= x && x <= b)
            {
                y = 1 - ((b - x) / (b - a));
            }
            else if (b <= x && x <= c)
            {
                y = 1 - ((x - c) / (c - b));
            }
            else
                y = 0;
            return y;
        }
    }
}
