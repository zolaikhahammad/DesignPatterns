using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public interface IShoppingCartVisitor
    {
         double Vist(Table table);
        double Vist(Chair chair);
    }
}
