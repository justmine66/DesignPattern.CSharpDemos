using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v2
{
    public class ObjectStructure
    {
        IList<AbstractPerson> persons = new List<AbstractPerson>();

        public void Attatch(AbstractPerson person)
        {
            persons.Add(person);
        }

        public void Detatch(AbstractPerson person)
        {
            persons.Remove(person);
        }

        public void Display(AbstractAction visttor)
        {
            foreach (var item in persons)
            {
                item.Accept(visttor);
            }
        }
    }
}
