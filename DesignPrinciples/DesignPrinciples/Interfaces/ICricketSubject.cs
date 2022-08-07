using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Interfaces
{
    public interface ICricketSubject
    {
        void AddObserver(ICricketObserver cricketObserver);
        void RemoveObserver(ICricketObserver cricketObserver);
        void NotifyAllObserver();
    }
}
