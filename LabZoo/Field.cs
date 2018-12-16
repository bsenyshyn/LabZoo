using System.Collections.Generic;

namespace LabZoo
{
    public class Field : Composite
    {
        private List<Composite> components = new List<Composite>();

        public Field() : base()
        {
        }

        public override void Add(Composite component)
        {
            components.Add(component);
        }

        public override void Remove(Composite component)
        {
            components.Remove(component);
        }
    }
}