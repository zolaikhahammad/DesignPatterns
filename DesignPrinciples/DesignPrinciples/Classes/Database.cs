using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Database
    {
        public List<string> customers;
        public Database()
        {
            customers = new List<string>();
            customers.Add("joe");
            customers.Add("zolaikha");

        }
        public bool CheckCustomerExists(string name)
        {
            return customers.Any(x=>x==name);
        }
    }
}
