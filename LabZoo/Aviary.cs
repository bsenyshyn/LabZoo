using System;
using System.Collections.Generic;

namespace LabZoo
{
    public abstract class Aviary : Composite
    {
        public int nmax, f;
        public List<Animal> animals = new List<Animal>();
        public Aviary(int m) : base()
        {
            nmax = m;
            f = 0;
        }

        public Aviary Successor;
        public abstract void AddAnimal(Animal animal);
        public abstract void RemoveAnimal(Animal animal);
    }
}