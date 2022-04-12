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
        //private List<CriterionForm> critFormList;
        private List<Criterion> criterionList;
        private int countCrit = 1;

        public Form1()
        {
            InitializeComponent();
            criterionList = new List<Criterion>();
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
            FlowLayoutPanel critPanel= new FlowLayoutPanel();
            critPanel.FlowDirection = FlowDirection.LeftToRight;
            //groupBox.Dock = DockStyle.Left;
            critPanel.Margin = new Padding(5);
            //groupBox.Location = new Point(50, addB.Location.Y);
            critPanel.Height = 270;
            critPanel.Width = baseCritPanel.Width-30;
            critPanel.Visible = true;
            //critPanel.Text = Convert.ToString(countCrit) + " критерий";
            //countCrit++;
            
           // addB.Location =new Point(130, groupBox.Bottom );
            baseCritPanel.Controls.Add(critPanel);
            Criterion criterion = new Criterion();
           // criterionList.Add(criterion);
            ////listCriterionGB.Add(groupBox);
            criterionGroup(critPanel);
            
        }
       // private void loc
       private void initAltClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Control controlParent = button.Parent;
            controlParent.BackColor = Color.Green;
           // string nameCrit= controlParent.
            //var index = baseCritPanel.Controls.IndexOf(sender as Control);
            


            
        }
        private void criterionGroup(FlowLayoutPanel critPanel)
        {
            CriterionForm infoCrit = new CriterionForm();
            Criterion crit= new Criterion()
            criterionList.Add(infoCrit.GetCriterion());
            /*//FlowLayoutPanel infoCrit = new FlowLayoutPanel();
            //Label nameCritL = new Label();
            //nameCritL.Text = "Введите название критерия";
            //TextBox nameCritTB = new TextBox();
            //Label countAltL = new Label();
            //countAltL.Text = "Введите колличество альтернатив";
            //countAltL.AutoSize = true;
            //NumericUpDown countAlt = new NumericUpDown();
            //countAlt.Minimum = 2;
            //Button initAltB = new Button();
            //initAltB.Text = "Задать альтернативы";
            //initAltB.AutoSize = true;
            //initAltB.Click += new EventHandler(initAltClick);






            //infoCrit.Controls.Add(nameCritL);
            //infoCrit.Controls.Add(nameCritTB);
            //infoCrit.Controls.Add(countAltL);
            //infoCrit.Controls.Add(countAlt);
            //infoCrit.Controls.Add(initAltB);

            //infoCrit.FlowDirection = FlowDirection.TopDown;
            //infoCrit.WrapContents = false;
            //infoCrit.AutoSize = true;
            ////infoCrit.AutoScroll = true;
            ////infoCrit.Dock = DockStyle.Left;
            //infoCrit.Padding = new Padding(5);
            //PictureBox pictureBox = new PictureBox();
            ////pictureBox_Paint();*/

            critPanel.Controls.Add(infoCrit);
            //string name = infoCrit.nameCritTB.Text;

        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paintGraf(GroupBox groupBox)
        {
            Chart chart = new Chart();

        }

        private void PaintGraf(Panel panel, Criterion criterion)
        {

        }
    }
}
