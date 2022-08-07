using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public abstract class AbstractCustomer
    {
        protected string customeName;
        public abstract bool IsNull();
        public abstract string GetCustomer();

    }
}
