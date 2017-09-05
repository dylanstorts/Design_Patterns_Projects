using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorLibrary
{
    

    /// The 'Aggregate' that inherits a list of strings thus hiding the the makeup of the iterator

    public abstract class Aggregate : List<string>
    {
        public abstract Iterator CreateIterator();
    }

    /// The 'ConcreteAggregate' class

    public class ConcreteAggregate : Aggregate
    {
        private List<string> aggList = new List<string>();
        
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        //public int Count()
        //{
        //    return aggList.Count;
        //}

        //public string Get(int index)
        //{
        //    return aggList.ElementAt(index);
        //}

        //public void Set(string newItem)
        //{
        //    aggList.Add(newItem);
        //}
    }

    /// The 'Iterator' interface

    public abstract class Iterator
    {
        abstract public void First();
        abstract public void Next();
        abstract public bool IsDone();
        abstract public string CurrentItem();
    }
    
    /// The 'ConcreteIterator' class

    public class ConcreteIterator : Iterator
    {
        private int current;
        private int step = 1;
        private ConcreteAggregate agg;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.agg = aggregate; 
        }

        public override string CurrentItem()
        {
            //throw new NotImplementedException();
            if (IsDone())
                return agg[current];
            else
                throw new Exception();
        }

        public override void First()
        {
            //throw new NotImplementedException();
            current = 0;
        }

        public override bool IsDone()
        {
            //throw new NotImplementedException();
            return  !( current >= agg.Count );
        }

        public override void Next()
        {
                current = current + step;
        }

    }
}

