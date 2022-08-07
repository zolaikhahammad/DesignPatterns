using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    public class InsertionSort1 : Algorithm
    {
        private int[] numbers;
        public InsertionSort1(int[] n)
        {
            numbers = n;
        }
        public override void Initialize()
        {
            Console.WriteLine("Initialize InsertionSort1");
        }

        public override void Print()
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Print Insertion Sort " + numbers[i]);
            }
        }

        public override void Sorting()
        {
            int temp;
            int j;
            for (int i = 1; i < numbers.Length; i++)
            {
                temp = numbers[i];
                j = i;
                while (j > 0 && numbers[j - 1] > temp)
                {
                    numbers[j] = numbers[j - 1];
                    j = j - 1;
                }
                numbers[j] = temp;
            }
        }
    }
}
