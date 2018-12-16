using System;

namespace LabZoo
{
    public class Wolf : Meater
    {
        public Wolf(string name, int weight) : base(name, weight)
        {
            
        }

        public override string Voice()
        {
            if (!_sleep)
                return ("Wooof! I'm wolf " + _name);
            else
                return ("Piss off, I'm " + _name +  " and I'm sleeping.");
        }
    }
}