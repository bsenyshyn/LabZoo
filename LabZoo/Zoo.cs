using System.Collections.Generic;
using System.Linq;
using System;

namespace LabZoo
{
    public class Zoo
    {
        public List<Animal> animals;        
        public List<Aviary> aviaries;
        public List<Zone> areas = new List<Zone>();
        public bool night;

        public Zoo()
        {
            animals = new List<Animal>();
            aviaries = new List<Aviary>();        
            night = false;
        }
        
        public void AddField(Zone f)
        {
            areas.Add(f);
            f.zoo = this;
            foreach (Composite c in f.Composites())
            {
                if (c is Zone)
                    AddField((Zone) c);
                else
                    aviaries.Add((Aviary) c);
            }
        }        

        public void AddAnimal(string n, int w)
        {     
            if(aviaries.Count > 0)
            {
                God god = new God();
                Animal animal = god.Create(n, w);

                for (int j = 0; j < aviaries.Count - 1; j++)
                    aviaries[j].Successor = aviaries[j + 1];
                aviaries[0].AddAnimal(animal);
                animals.Add(animal);
            }
            else
                throw new NoPlaceException("I'm sorry. Provide more space for animals!");
        }

        
        public void Night()
        {
            foreach (Animal animal in animals)
                animal.Sleep();
            night = true;
        }

        public void Day()
        {
            foreach (Animal animal in animals)
                animal.Wake();
            night = false;
        }

        public void Voice()
        {
            foreach (Animal a in animals)
                Console.WriteLine(a.Voice());
        }
        
        public double SumWeight()
        {
            double sum = 0;
            foreach (Animal animal in animals)
                sum += animal._weight;
            return sum;
        }

        public double AverageWeight()
        {
            return SumWeight() / animals.Count();
        }
    }
}