namespace LabZoo
{
    public class AviaryBear : Aviary
    {
        public AviaryBear(int m) : base(m)
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
        }

        public override void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }
    }
}