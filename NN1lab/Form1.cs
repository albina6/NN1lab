using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NN1lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lawsB_Click(object sender, EventArgs e)//пока проверка функции
        {
            double a, b, c, d;
            FunctionMembership func = new FunctionMembership("simple", 1, 3, 7);
            a=func.GetY(1.0);
            b = func.GetY(3.0);
            c = func.GetY(5.0);//0.5
            d = func.GetY(1.0);//8
            int f=0;
        }
    }
}
