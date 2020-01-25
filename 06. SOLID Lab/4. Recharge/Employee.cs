﻿namespace P04.Recharge
{
    using System;

    public class Employee : Worker
    {
        public Employee(string id)
            : base(id)
        {
        }

        public override void Recharge()
        {
            throw new InvalidOperationException($"{this.GetType().Name} cannot recharge.");
        }

        public override void Sleep()
        {
            // sleep...
        }  
    }
}
