using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;


namespace NN1lab
{
    public partial class Form1 : Form
    {
        //private List<GroupBox> listCriterionGB;
        private int countCrit = 1;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void lawsB_Click(object sender, EventArgs e)//пока проверка функции
        {

            //AlternativeForm cr = new AlternativeForm();
            //cr.Show();


            //double a, b, c, d;
            //TriangleFunc func = new TriangleFunc("simple", 1, 3, 7);
            //a=func.GetY(1.0);
            //b = func.GetY(3.0);
            //c = func.GetY(5.0);//0.5
            //d = func.GetY(8);//0
            //int f=0;
            //FunctionMembership fq = new FunctionMembership();
            //fq = func;
            //func = new TriangleFunc("sfd", 2, 6, 7);

        }

        private void addCriterionB_Click(object sender, EventArgs e)
        {
            GroupBox groupBox= new GroupBox();
            //groupBox.Dock = DockStyle.Left;
            groupBox.Margin = new Padding(5);
            //groupBox.Location = new Point(50, addB.Location.Y);
            groupBox.Height = 250;
            groupBox.Width = criterionPanel.Width-30;
            groupBox.Visible = true;
            groupBox.Text = Convert.ToString(countCrit) + " критерий";
           // addB.Location =new Point(130, groupBox.Bottom );
            criterionPanel.Controls.Add(groupBox);
            ////listCriterionGB.Add(groupBox);
            criterionGroup(groupBox);
        }

        private void criterionGroup(GroupBox groupBox)
        {
            GroupBox infoCrit = new GroupBox();

            Label nameCritL = new Label();
            nameCritL.Text = "Введите название критерия";
            
            //nameCritL.Font = new Font("Calibri", 10);

            TextBox nameCritTB = new TextBox();

            Label countAltL = new Label();
            countAltL.Text = "Введите колличество альтернатив";
            NumericUpDown countAlt = new NumericUpDown();
            countAlt.Minimum = 2;






            infoCrit.Controls.Add(nameCritL);
            infoCrit.Controls.Add(nameCritTB);
            infoCrit.Controls.Add(countAltL);
            infoCrit.Controls.Add(countAlt);

            infoCrit.Dock = DockStyle.Left;
            infoCrit.Visible = true;
            PictureBox pictureBox = new PictureBox();
            //pictureBox_Paint();

            groupBox.Controls.Add(infoCrit);
            

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paintGraf(GroupBox groupBox)
        {
            Chart chart = new Chart();

        }
        
    }
}
