namespace LabZoo
{
    public class AviaryWolf : Aviary
    {
        public AviaryWolf(int max) : base(max)
        {
        }

        public override void AddAnimal(Animal animal)
        {
            if (nmax > f && animal is Bear)
            {
                f++;
                animals.Add(animal);
            }
            else if (Successor != null)
                Successor.AddAnimal(animal);
            else
                throw new NoPlaceException("I'm sorry. Provide more space for animals!");
        }

        public override void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }
    }
}