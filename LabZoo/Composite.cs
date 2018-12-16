namespace LabZoo
{
    public abstract class Composite
    {
        public Zoo zoo;
        public Composite()
        {

        }

        public virtual void Add(Composite composite) { }
        public virtual void Remove(Composite composite) { }
    }
}