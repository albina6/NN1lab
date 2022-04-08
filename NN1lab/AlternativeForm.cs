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
        public AlternativeForm()
        {
            InitializeComponent();
            aTB.Enabled = false;
            bTB.Enabled = false;
            cTB.Enabled = false;
            dTB.Enabled = false;
            okButton.Enabled = false;
        }

        private void OK_Click(object sender, EventArgs e)
        {

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
    }
}
