using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern.Mechanism
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _aggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public override object Next()
        {
            _current++;
            if (_current < _aggregate.Count)
            {
                return _aggregate[_current];
            }

            return null;
        }
    }
}
