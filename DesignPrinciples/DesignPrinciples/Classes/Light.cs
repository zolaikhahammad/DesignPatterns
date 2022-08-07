using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Light
    {
        /// <summary>
        /// Receiver Class
        /// </summary>
        public void TurnOn()
        {
            Console.WriteLine("Lights are on..");
        }
        public void TurnOff()
        {
            Console.WriteLine("Lights are off");
        }

    }
}
