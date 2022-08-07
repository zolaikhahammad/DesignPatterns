using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Iterator:IIterator
    {
        private string[] names;
        private int index;
        public Iterator(string[] n)
        {
            names = n;
        }

        public bool HasNext()
        {
            return index < this.names.Length;
        }

        public object Next()
        {
            if (HasNext())
            {
                return this.names[index++];
            }
            else
            {
                return null;
            }
        }
    }
}
