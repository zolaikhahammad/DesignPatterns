using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class ShoppingCart : IShoppingCartVisitor
    {
        public double Vist(Table table)
        {
            return table.GetPrice();
        }

        public double Vist(Chair chair)
        {
            return chair.GetPrice();
        }
    }
}
