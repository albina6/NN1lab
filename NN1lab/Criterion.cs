using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NN1lab
{
    public class Criterion
    {
        private string nameCriterion;
        private FunctionMembership [] alternArray;
       // private int countAlt;
        public Criterion(Criterion criterion)
        {
            this.nameCriterion = criterion.Name;
            this.alternArray = criterion.alternArray;
        }
        public Criterion()
        {
            this.nameCriterion = "";
            //this.countAlt = 0;
            alternArray = new FunctionMembership[1];
        }
        public Criterion(string nameCriterion, int countAltern)
        {
            this.nameCriterion = nameCriterion;
            //this.countAlt = countAltern;
            alternArray = new FunctionMembership[countAltern];

        }
        public string Name
        {
            get => nameCriterion;
            set => nameCriterion = value;
        }
        public void AlternArraySet(int count)
        {
           alternArray = new FunctionMembership[count];
        }

        public void AddAltern(FunctionMembership altern,int index)
        {
            alternArray[index] = altern;
        }
        public void InitializationAltern()
        {
            if (nameCriterion != "")
            {
                AlternativeForm altForm;
                for (int i = 0; i < alternArray.Length; i++)
                {
                    altForm = new AlternativeForm();
                    altForm.ShowDialog();
                    //if (altForm.DialogResult==DialogResult.)
                    if (altForm.DialogResult == DialogResult.OK)
                    {
                        this.AddAltern(altForm.GetAltern(), i);
                    }

                    else
                    {
                        MessageBox.Show("Что-то пошло не так.", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //alternArray[i] = altForm.alternative;
                }
            }

            else
            {
                MessageBox.Show("Введите имя критерия .", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

    }
}
