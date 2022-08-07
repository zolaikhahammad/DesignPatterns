using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Add : IStrategyPattern
    {
        public void Operation(int x, int y)
        {
            Console.WriteLine(x+y);
        }
    }
}
