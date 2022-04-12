using System;
using System.Drawing;
using System.Windows.Forms;


namespace NN1lab
{
    public class CriterionForm: FlowLayoutPanel//(FlowLayoutPanel critPanel)
    {
        private Criterion criterion;
        private Label nameCritL;
        public TextBox nameCritTB;
        private Label countAltL;
        public NumericUpDown countAltNUD;
        public Button initAltB;
        //private PictureBox pictureBox;
        public Criterion GetCriterion()
        {
            return criterion;
        }
        public CriterionForm() 
        {
            nameCritL = new Label();
            nameCritL.Text = "Введите название критерия";
            nameCritL.Visible=true;
            nameCritTB = new TextBox();
            countAltL = new Label();
            countAltL.Text = "Введите колличество альтернатив";
            countAltL.AutoSize = true;
            countAltNUD = new NumericUpDown();
            countAltNUD.Minimum = 2;
            countAltNUD.Increment = 1;
            initAltB = new Button();
            initAltB.Text = "Задать альтернативы";
            initAltB.AutoSize = true;
            
            //pictureBox = new PictureBox();


            this.Controls.Add(nameCritL);
            this.Controls.Add(nameCritTB);
            this.Controls.Add(countAltL);
            this.Controls.Add(countAltNUD);
            this.Controls.Add(initAltB);
            //this.Controls.Add(pictureBox);

            this.FlowDirection= FlowDirection.TopDown;
            this.WrapContents = false;
            this.AutoSize = true;
            //infoCrit.AutoScroll = true;
            //infoCrit.Dock = DockStyle.Left;
            this.Padding = new Padding(5);

            initAltB.Click += new EventHandler(initAltClick);


        }

        //private void nameText

        private void initAltClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            CriterionForm controlParent = (CriterionForm) button.Parent;
            int countAltern = (int)controlParent.countAltNUD.Value;
            string name = controlParent.nameCritTB.Text;
            criterion=new Criterion(name, countAltern);
            criterion.InitializationAltern();


            //for(int i = 0; i < countAltern; i++)
            //{
            //    AlternativeForm al = new AlternativeForm(name);


            //    if (al.ShowDialog() ==DialogResult.OK)
            //    {
            //        criterion.AddAltern(al.GetAltern(), i);
            //    }

            //    else
            //    {
            //        MessageBox.Show("Что-то пошло не так.", "Ошибка",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }


            //}
            
           
           
            // string nameCrit= controlParent.
            //var index = baseCritPanel.Controls.IndexOf(sender as Control);

        }


    }
}
