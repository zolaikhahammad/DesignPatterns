using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class InsertionSort:ISorter //: Sorter
    {
        //public InsertionSort()
        //{
        //    sortType = Enum.SortType.INSERTIONSORT;
        //}
        public void Sort()
        {
            Console.WriteLine("Sorting from insertion sort");
        }
    }
}
