using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Car : INormalVehicle
    {
        public void AddFuel()
        {
            Console.WriteLine("Adding Fuel");
        }

        public void Speed()
        {
            Console.WriteLine("Adding Speed");
        }
    }
}
