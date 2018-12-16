using System;

namespace LabZoo
{
    public class God
    {
        public Animal Create(string name, int weight)
        {
            Random random = new Random();
            int i = random.Next(5); //making 20% per number
            if (i == 4)            
                return new Giraffe(name, weight);            
            else if (i % 2 == 0)
                return new Bear(name, weight);
            else
                return new Wolf(name, weight);
        }
    }
}