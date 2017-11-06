using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Leaf : Component
    {
        //the only leaf in an office building based composite will become an individual
        //office in the end and that is what this class describes

        public int OfficeNum;
        public string PersonName, PersonTitle;

        public Leaf SetLeaf(int num, string name, string title)
        {
            Leaf newLeaf = new Leaf();

            newLeaf.OfficeNum = num;
            newLeaf.PersonName = name;
            newLeaf.PersonTitle = title;

            return newLeaf;
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override Component GetChild(int index)
        {
            throw new NotImplementedException();
        }

        public override string Operation()
        {
            string DESC = " \n" + OfficeNum + "\n  -" + PersonName + ", " + PersonTitle + "\n";

            return DESC;
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
