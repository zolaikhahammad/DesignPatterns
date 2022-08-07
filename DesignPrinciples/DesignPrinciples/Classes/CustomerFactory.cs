using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class CustomerFactory
    {
        private Database database;
        public CustomerFactory()
        {
            database = new Database();
        }
        public AbstractCustomer GetCustomer(string name)
        {
            if (check(name))
                return new RealCustomer(name);
            else
                return new NullCustomer();
        }

        private bool check(string name)
        {
            return database.CheckCustomerExists(name);
        }
    }
}
