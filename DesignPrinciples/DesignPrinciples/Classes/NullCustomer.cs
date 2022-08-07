using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class NullCustomer : AbstractCustomer
    {
        public override string GetCustomer()
        {
            return "No customer Exist";
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}
