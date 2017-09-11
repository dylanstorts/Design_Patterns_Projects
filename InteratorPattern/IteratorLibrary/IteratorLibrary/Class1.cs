using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorLibrary
{
    

    /// The 'Aggregate' that inherits a list of strings thus hiding the the makeup of the iterator

    public abstract class Aggregate : List<string> {}

    public enum IteratorType {completeIterator, aIterator, bIterator, cIterator }
    
    /// The 'ConcreteAggregate' class

    public class ConcreteAggregate : Aggregate
    {
        
        public Iterator CreateIterator(IteratorType iter)
        {
            //return new CompleteIterator(this);
            
            switch (iter)
            {
                case IteratorType.completeIterator:
                    return new CompleteIterator(this);
                    
                case IteratorType.aIterator:
                    return new AIterator(this);
                    
                case IteratorType.bIterator:
                    return new BIterator(this);
                    
                case IteratorType.cIterator:
                    return new CIterator(this);
                    
                default: return new CompleteIterator(this);
            }
            
        }
    }

    /// The 'Iterator' interface

    public abstract class Iterator
    {
        abstract public void First();
        abstract public void Next();
        abstract public bool IsDone();
        abstract public string CurrentItem();
    }
    
    /// The Concrete Iterator that goes over all elements

    public class CompleteIterator : Iterator
    {
        private int current;
        private int step = 1;
        private ConcreteAggregate agg;

        public CompleteIterator(ConcreteAggregate aggregate)
        {
            this.agg = aggregate; 
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return agg[current];
            else
                throw new Exception();
        }

        public override void First()
        {
            current = 0;
        }

        public override bool IsDone()
        {
            return  ( current >= agg.Count );
        }

        public override void Next()
        {
            current += step;
        }

    }

    public class AIterator : Iterator
    {
        private int current;
        private int step = 1;
        private ConcreteAggregate agg;

        public AIterator(ConcreteAggregate aggregate)
        {
            this.agg = aggregate;
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return agg[current];
            else
                throw new Exception();
        }

        public override void First()
        {
            while(agg[current][0] != 'A')
            {
                current += step;
            }
        }

        public override bool IsDone()
        {
            return (current >= agg.Count - 1);
        }

        public override void Next()
        {
            current += step;
            
            while (agg[current][0] != 'A' && !IsDone() )
            {
            current += step;

            }
        }
    }

    public class BIterator : Iterator
    {
        private int current;
        private int step = 1;
        private ConcreteAggregate agg;

        public BIterator(ConcreteAggregate aggregate)
        {
            this.agg = aggregate;
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return agg[current];
            else
                throw new Exception();
        }

        public override void First()
        {
            while (agg[current][0] != 'B')
            {
                current += step;
            }
        }

        public override bool IsDone()
        {
            return (current >= agg.Count - 1);
        }

        public override void Next()
        {
            current += step;

            while (agg[current][0] != 'B' && !IsDone())
            {
                current += step;

            }
        }
    }

    public class CIterator : Iterator
    {
        private int current;
        private int step = 1;
        private ConcreteAggregate agg;

        public CIterator(ConcreteAggregate aggregate)
        {
            this.agg = aggregate;
        }

        public override string CurrentItem()
        {
            if (!IsDone())
                return agg[current];
            else
                throw new Exception();
        }

        public override void First()
        {
            while (agg[current][0] != 'C')
            {
                current += step;
            }
        }

        public override bool IsDone()
        {
            return (current >= agg.Count - 1);
        }

        public override void Next()
        {
            current += step;

            while (agg[current][0] != 'C' && !IsDone())
            {
                current += step;

            }
        }
    }
}

