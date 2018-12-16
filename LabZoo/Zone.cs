using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabZoo
{
    public class Zone : Composite
    {
        public Zoo parent;
        private List<Composite> components = new List<Composite>();
        public List<Composite> Composites()
        {
            return components;
        }

        public Zone() : base()
        {
        }

        public override void Add(Composite component)
        {
            components.Add(component);
            component.zoo = this.zoo;
            if (zoo != null)
                if (!zoo.areas.Contains(component) && component is Zone)
                    zoo.AddField((Zone)component);
        }

        public override void Remove(Composite component)
        {
            components.Remove(component);
        }
    }
}
