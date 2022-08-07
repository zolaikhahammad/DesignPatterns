using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Table:IShoppingItems
    {
        string name;
        private double price;
        public Table(string _n,double _p)
        {
            name = _n;
            price = _p;
        }
        public void SetName(string _n)
        {
            name = _n;
        }
        public string GetName()
        {
            return name;
        }
        public void SetPrice(double _p)
        {
            price=_p;
        }
        public double GetPrice()
        {
            return price;
        }
        public  double Accept(IShoppingCartVisitor shoppingCartVisitor)
        {
            return shoppingCartVisitor.Vist(this);
        }
    }
}
