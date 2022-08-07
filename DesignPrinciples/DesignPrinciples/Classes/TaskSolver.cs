using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class TaskSolver : ICommand
    {
        private Task task;

        public TaskSolver(Task t)
        {
            task = t;
        }
        public void Execute()
        {
            task.SolveProblem();
        }
    }
}
