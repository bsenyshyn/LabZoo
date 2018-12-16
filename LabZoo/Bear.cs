using System;

namespace LabZoo
{
    public class Bear : Meater
    {
        public Bear(string name, int weight) : base(name, weight)
        {
            
        }

        public override string Voice()
        {
            if (!_sleep)
                return ("Rarrr! I'm bear " + _name);
            else
                return ("Piss off, I'm " + _name +  " and I'm sleeping.");
        }
    }
}