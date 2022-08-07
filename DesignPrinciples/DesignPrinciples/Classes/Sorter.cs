using DesignPrinciples.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public abstract class Sorter
    {
        public SortType sortType;
        public abstract void Sort();
    }
}
