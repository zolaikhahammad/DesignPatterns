using DesignPrinciples.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Interfaces
{
    public interface IShoppingItems
    {
        double Accept(IShoppingCartVisitor shoppingCartVisitor);
    }
}
