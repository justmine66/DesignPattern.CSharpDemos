using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.IteratorPattern.Mechanism
{
    public class ConcreteIteratorDesc : Iterator
    {
        private ConcreteAggregate _aggerate;
        private int _current = 0;

        public ConcreteIteratorDesc(ConcreteAggregate aggregate)
        {
            _aggerate = aggregate;
            _current = aggregate.Count - 1;
        }

        public override object CurrentItem()
        {
            return _aggerate[_current];
        }

        public override object First()
        {
            return _aggerate[_aggerate.Count - 1];
        }

        public override bool IsDone()
        {
            return _current < 0;
        }

        public override object Next()
        {
            _current--;
            if (_current > 0)
            {
                return _aggerate[_current];
            }

            return null;
        }
    }
}
