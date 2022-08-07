using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Interfaces
{
    public interface IObserver
    {
        void Update(int pressure,int temprature, int humidity);
    }
}
