using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model;

namespace Calculator.ViewModel
{
    class SumatorViewModel : MainViewModel
    {
        private int _first;
        public int First
        {
            get => _first;

            set
            {
                Console.WriteLine("robit");
                _first = value;
                OnPropertyChanged(nameof(First));
            }
        }

        private int _second;
        public int Second
        {
            get => _second;

            set
            {
                Console.WriteLine("robit");
                _second = value;
                OnPropertyChanged(nameof(Second));
            }
        }










    }
}
