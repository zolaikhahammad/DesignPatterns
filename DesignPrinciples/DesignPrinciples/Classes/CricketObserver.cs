using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class CricketObserver : ICricketObserver
    {
        int w;
        int r;
        int o;
        private ICricketSubject cricketSubject;

        public CricketObserver(ICricketSubject _cricketSubject)
        {
            cricketSubject = _cricketSubject;
            cricketSubject.AddObserver(this);
        }

        public void Update(int wicket, int runs, int overs)
        {
            w = wicket;
            r = runs;
            o = overs;
            ShowData();
        }
        public void ShowData()
        {
            Console.WriteLine(w +" "+r+" "+o);
        }
    }
}
