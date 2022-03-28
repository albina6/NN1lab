using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN1lab
{
    class FunctionMembership//функция принадлежности,
                            //нужно 4 подкласса
    {
        private string nameAlt;
        public double Y;
        //private FunctionMembership fun;

        public virtual double GetY(double x)
        {
           // fun.GetY(x);
            return 0.0;
        }
        public FunctionMembership()
        {

        }
        public FunctionMembership(string nameAlt,double a,double b, double c)
        {
           // this.nameAlt = nameAlt;
            //TriangleFunc fun = new TriangleFunc(nameAlt, a, b, c);
           // Y=triangle.GetY
            
        }

        public FunctionMembership(string name) { }
            //скорее всего нужно будет создать конструктор внутри if (s)
                                    //else if(z)

    }
}
