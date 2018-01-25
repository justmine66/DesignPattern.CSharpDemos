using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CompositePattern.Mechanism
{
    public class CompositePatternClient
    {
        public void Main()
        {
            var root = new Composite("root");
            root.Add(new Leaf("Leaf a"));
            root.Add(new Leaf("Leaf 6"));

            var branch = new Composite("branch");
            branch.Add(new Leaf("branch Leaf xa"));
            branch.Add(new Leaf("branch Leaf x6"));

            var branch1 = new Composite("branch");
            branch1.Add(new Leaf("branch Leaf xa"));
            branch1.Add(new Leaf("branch Leaf x6"));

            root.Add(branch);
            root.Add(branch1);

            root.Display(2);

            Console.Read();
        }
    }
}
