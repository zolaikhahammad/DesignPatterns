using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Interfaces
{
    public interface ICricketObserver
    {
        void Update(int wicket, int runs, int overs);
    }
}
