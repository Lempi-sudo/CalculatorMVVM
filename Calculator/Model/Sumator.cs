using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Calculator.Model
{
    class Sumator
    {
        public int First { get; set; }
        public int Second { get; set; }
        private int _summa = 0;

        public int Summa
        {
            get => _summa;
        }

        public Sumator()
        {
            
        }

        public void CalculateAmount()
        {
            _summa = First + Second;
        }


    }
}
