using System;

namespace LabZoo
{
    public class Creating
    {
        public Animal Create(string n, int w)
        {
            Random rnd = new Random();
            int i = rnd.Next(5);
            if (i == 4)            
                return new Giraffe(n, w);            
            else if (i % 2 == 0)
                return new Bear(n, w);
            else
                return new Wolf(n, w);
        }
    }
}