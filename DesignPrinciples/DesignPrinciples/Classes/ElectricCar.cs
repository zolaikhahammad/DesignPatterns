using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class ElectricCar: IElectricVehicle
    {

        public void CharegBatteries()
        {
            Console.WriteLine("Adding Battery in Electric Car");
        }

        public void Speed()
        {
            Console.WriteLine("Adding Speed in Electric Car");
        }
    }
}
