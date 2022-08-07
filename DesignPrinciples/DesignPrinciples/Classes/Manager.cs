using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Manager:IStrategyPattern
    {
        private IStrategyPattern strategyPattern;

        public void Operation(int x, int y)
        {
            strategyPattern.Operation(x, y);
        }

        public void SetStrategy(IStrategyPattern _strategyPattern)
        {
            this.strategyPattern = _strategyPattern;
        }
    }
}
