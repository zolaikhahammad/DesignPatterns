using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class NamesRepository
    {
        private string[] names = { "James", "Sara", "Json" };
        public IIterator GetIterator()
        {
            return new Iterator(names);
        }
    }
}
