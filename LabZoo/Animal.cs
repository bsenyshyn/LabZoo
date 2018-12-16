using System;

namespace LabZoo
{
    public abstract class Animal
    {
        Guid id;
        public string _name;
        public int _weight;
        public bool _sleep = false;

        public Animal(string name, int weight)
        {
            id = Guid.NewGuid();
            _name = name;
            _weight = weight;
        }

        public abstract string Voice();

        public void Sleep()
        {
            _sleep = true;
        }

        public void Wake()
        {
            _sleep = false;
        }
    }
}