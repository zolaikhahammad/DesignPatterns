using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class TurnOnCommand : ICommand
    {
        private Light light;
        public TurnOnCommand(Light _l)
        {
            this.light = _l;
        }
        public void Execute()
        {
            light.TurnOn();
        }
    }
}
