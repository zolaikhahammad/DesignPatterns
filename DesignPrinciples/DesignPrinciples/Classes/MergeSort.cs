using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class MergeSort:ISorter //: Sorter
    {
        //public MergeSort()
        //{
        //    sortType = Enum.SortType.MERGESORT;
        //}
        public void Sort()
        {
            Console.WriteLine("Sorting from merge sort");
        }
    }
}
