using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN1lab
{
    public class FunctionMembership//функция принадлежности,
                            //нужно 4 подкласса
    {
       // private string nameAlt;
        private double Y;
        //private FunctionMembership fun;
        public string Name { get; set; }
        
        public virtual double GetY(double x)
        {
           // fun.GetY(x);
            return 100.0;
        }
        
        public FunctionMembership()
        {

        }
        public FunctionMembership(string nameAlt,double a,double b, double c)
        {
           //this.nameAlt = nameAlt;
            //TriangleFunc fun = new TriangleFunc(nameAlt, a, b, c);
           // Y=triangle.GetY
            
        }

        public FunctionMembership(string name) { }
            //скорее всего нужно будет создать конструктор внутри if (s)
                                    //else if(z)

    }
}
