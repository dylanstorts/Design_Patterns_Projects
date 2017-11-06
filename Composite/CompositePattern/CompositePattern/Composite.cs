using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite : Component
    {
        public List<Component> children = new List<Component>();

        public int ID;
        public string Type;

        public Composite(int iD, string type)
        {
            ID = iD;
            Type = type;
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override Component GetChild(int index)
        {
            return children.ElementAt(index);
        }

        public override string Operation()
        {
            string childrenString = this.Type + " " + this.ID + "\n    -";

            foreach(Component item in children)
            {

                childrenString += "\n     -" + item.Operation();
            }

            return childrenString;
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }
}
