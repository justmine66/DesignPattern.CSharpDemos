using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    public class PersonClient
    {
        public void Main()
        {
            var pen = new Pen();
            var graphics = new Graphics();
            var personThinBuilder = new PersonThinBuilder(graphics, pen);
            var personDirector = new PersonDirector(personThinBuilder);
            personDirector.CreatePerson();
        }
    }
}
