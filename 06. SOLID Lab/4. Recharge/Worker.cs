using _4._Recharge.Interfaces;
using P04.Recharge.Interfaces;
using System;

namespace P04.Recharge
{
    public abstract class Worker : ISleeper, IWorker
    {
        private string id;
        private int workingHours;

        public Worker(string id)
        {
            this.id = id;
        }

        public virtual void Work(int hours)
        {
            this.workingHours += hours;
        }

        public abstract void Sleep();

        public abstract void Recharge();

    }
}