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
    public partial class AlternativeForm : Form
    {

        private TextBox[] arrayTB;
        private FunctionMembership alternative;
        public AlternativeForm()
        {
            InitializeComponent();

            arrayTB = new TextBox[] { aTB, bTB, cTB, dTB };
            for (int i = 0; i < arrayTB.Length; i++)
            {
                arrayTB[i].Text = "0";
                arrayTB[i].Enabled = false;
            }
            //okButton.Enabled = false;
        }

        public AlternativeForm(string name)
        {
            InitializeComponent();
            this.Text += "Критерий " + name;
        }

        private void NewAlt()
        {
            double a, b, c,d;
            string name = nameAltTB.ToString();
            a = Convert.ToDouble(aTB.Text);
            b = Convert.ToDouble(bTB.Text);
            c = Convert.ToDouble(cTB.Text);
            d = Convert.ToDouble(dTB.Text);
            if (FuncCB.SelectedItem.ToString() == "Треугольная")
            {
                alternative = new TriangleFunc(name, a, b, c);
                okButton.Enabled = true;
            }
            else /*if(FuncCB.SelectedItem.ToString() == "Трапецеидальная")*/
            {
                alternative = new TrapezeFunc(name, a, b, c, d);
            }

//                Треугольная
//                Трапецеидальная
//Z - образная
//S - образная

        }

        public FunctionMembership GetAltern()
        {
            return alternative;
        }

        private void OK_Click(object sender, EventArgs e)
        {

                NewAlt();
                Close();
                //this.Dispose();                

                //Console.WriteLine("Возникло исключение!");

            
        }

       
        private void TriangleSelected()
        {
            aTB.Enabled = true;
            bTB.Enabled = true;
            cTB.Enabled = true;
        }
        private void FuncCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //мб и не нужно,еще не поняла

            //aTB.Text = "";
            //bTB.Text = "";
            //cTB.Text = "";
            //dTB.Text = "";
            if (FuncCB.SelectedItem.ToString() == "Треугольная")
            {
                TriangleSelected();
            }
            else { }


           
        }

        private void FuncCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (FuncCB.SelectedItem.ToString() == "Треугольная")
            {
                aTB.Enabled = true;
                bTB.Enabled = true;
                cTB.Enabled = true;
                okButton.Enabled = true;
            }
            else /*if(FuncCB.SelectedItem.ToString() == "Трапецеидальная")*/
            {
                aTB.Enabled = true;
                bTB.Enabled = true;
                cTB.Enabled = true;
                dTB.Enabled = true;
                okButton.Enabled = true;
            }
        }
    }
}
