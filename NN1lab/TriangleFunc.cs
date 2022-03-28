using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN1lab
{
    class TriangleFunc : FunctionMembership
    {
        private double a,b,c;

        public TriangleFunc(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double GetY(double x)
        {
            double y;
            if (a <= x && x <= b)
            {
                y = 1 - ((b - x) / (b - a));
            }
            else if (b <= x && x <= c)
            {
                y = 1 - ((x - c) / (c - b));
            }
            else
                y = 0.0;
            return y;
        }

        public double A
        {
            get => a;
            set => a = value;
        }

        public double B
        {
            get => b;
            set => b = value;
        }

        public double C
        {
            get => c;
            set => c = value;
        }
    }
}
