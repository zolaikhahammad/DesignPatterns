using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class Algorithm
    {
        private BlockingQueue<ICommand> commands;
        public Algorithm()
        {
            commands = new BlockingQueue<ICommand>();
        }
        public void Produce()
        {
            try
            {
                for(int i = 0; i <= 10; i++)
                {
                    commands.Enqueue(new TaskSolver(new Task(i+1)));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Consume()
        {
            try
            {
                for(int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(1000);
                    commands.Dequeue().Execute();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
