using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN1lab
{
    class Criterion
    {
        private string nameCriterion;
        private FunctionMembership [] alternArray;
        private int countAlt;
        
        public Criterion(string nameCriterion, int countAltern)
        {
            this.nameCriterion = nameCriterion;
            this.countAlt = countAlt;
            alternArray = new FunctionMembership[countAltern];

        }
        
        public void InitializationAltern()
        {
            
        }

    }
}
