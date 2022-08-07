using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Task
    {
        private int id;
        public Task(int _id)
        {
            this.id = _id;
        }
        public void SolveProblem()
        {
            Console.WriteLine("Solving the problem "+ id);
        }

    }
}
