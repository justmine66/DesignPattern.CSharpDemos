using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern.Mechanism
{
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> _items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public int Count { get { return _items.Count; } }
    }
}
