using System;

namespace LabZoo
{
    public class Giraffe : Herbs
    {
        public Giraffe(string name, int weight) : base(name, weight)
        {
            
        }

        public override string Voice()
        {
            if (!_sleep)
                return ("Woooo! I'm giraffe " + _name);
            else
                return ("Piss off, I'm " + _name +  " and I'm sleeping.");
        }
    }
}