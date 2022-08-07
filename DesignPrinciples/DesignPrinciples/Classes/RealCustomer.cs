using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            customeName = name;
        }
        public override string GetCustomer()
        {
            return customeName;
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}
