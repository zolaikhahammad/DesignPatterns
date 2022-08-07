using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class SorterManager
    {
        /// <summary>
        /// it met the requirements but what if we want to implement quick
        /// sort algo and another algo after some time we need to modify the 
        /// enum class and then sort manager so we will violate the open closd principle
        /// for that we use strategy pattern, we can get the rid of enums
        /// we will implement interface instead of abstract
        /// </summary>
        /// <param name="sorter"></param>
        //public void Sort(Sorter sorter)
        //{
        //    if (sorter.sortType == Enum.SortType.INSERTIONSORT)
        //        DoInsertionSort(sorter);
        //    if (sorter.sortType == Enum.SortType.MERGESORT)
        //        DoMergeSort(sorter);

        //}
        //public void DoInsertionSort(Sorter sorter)
        //{
        //    sorter.Sort();
        //}
        //public void DoMergeSort(Sorter sorter)
        //{
        //    sorter.Sort();
        //}

        public void Sort(ISorter sorter)
        {
            sorter.Sort();
        }
    }
}
