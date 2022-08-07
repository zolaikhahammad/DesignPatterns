using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    public abstract class Algorithm
    {
        public abstract void Initialize();
        public abstract void Sorting();
        public abstract void Print();
        public void Sort()
        {
            Initialize();
            Sorting();
            Print();
        }
    }
}
