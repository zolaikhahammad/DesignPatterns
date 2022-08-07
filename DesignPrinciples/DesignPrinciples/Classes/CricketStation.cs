using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class CricketStation:ICricketSubject
    {
        int w;
        int r;
        int o;
        public void SetWickets(int _w)
        {
            w = _w;
            NotifyAllObserver();
        }
        public void SetRuns(int _w)
        {
            r = _w;
            NotifyAllObserver();
        }
        public void SetOvers(int _w)
        {
            o = _w;
            NotifyAllObserver();
        }
        private List<ICricketObserver> cricketObservers;

        public CricketStation()
        {
            cricketObservers = new List<ICricketObserver>();
        }
        public void AddObserver(ICricketObserver cricketObserver)
        {
            cricketObservers.Add(cricketObserver);
        }

        public void NotifyAllObserver()
        {
            foreach(var item in cricketObservers)
            {
                item.Update(w,r,o);
            }
                    
        }

        public void RemoveObserver(ICricketObserver cricketObserver)
        {
            cricketObservers.Remove(cricketObserver);
        }
    }
}
