using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v2
{
    public class VisitorPatternV2Client
    {
        public void Main()
        {
            var objectStructure = new ObjectStructure();
            objectStructure.Attatch(new Man());
            objectStructure.Attatch(new Woman());

            objectStructure.Display(new Success());
            objectStructure.Display(new Failure());
            objectStructure.Display(new Amativeness());

            Console.Read();
        }
    }
}
