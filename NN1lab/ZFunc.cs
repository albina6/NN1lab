using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN1lab
{
    class ZFunc : FunctionMembership
    {
        private double a, b;
        private const double Pi= 3.14;

        public ZFunc(double a, double b)
        {
            if (a <= b)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                this.a = b;
                this.b = a;
            }
        }
        public double GetY(double x)
        {
            double y;
            if (x < a)
            {
                y = 1.0;
            }
            else if (a <= x && x <= b)
            {
                y = 0.5 + 0.5 * (Math.Cos(((x - a) / (b - a)) * Pi));
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
    }
}
