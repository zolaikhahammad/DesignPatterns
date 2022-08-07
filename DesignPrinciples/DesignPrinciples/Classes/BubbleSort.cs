using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples
{
    public class BubbleSort : Algorithm
    {
        private int[] numbers;
        public BubbleSort(int[] n)
        {
            numbers = n;
        }
        public override void Initialize()
        {
            Console.WriteLine("Initialize BubbleSort");
        }

        public override void Print()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Print BubbleSort  " + numbers[i]);
            }
        }

        public override void Sorting()
        {
            int n = numbers.Length;
            int temp;
            while (n != 0)
            {
                temp = 0;
                for(int i = 1; i < n; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        int swap = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = swap;
                        temp = i;
                    }
                }
                n = temp;
            }

        }
    }
}
