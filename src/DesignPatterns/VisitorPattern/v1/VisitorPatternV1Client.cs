using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.VisitorPattern.v1
{
    public class VisitorPatternV1Client
    {
        public void Main()
        {
            IList<AbstractPerson> persons = new List<AbstractPerson>();

            AbstractPerson man1 = new Man();
            man1.Action = "成功";
            persons.Add(man1);

            AbstractPerson man2 = new Man();
            man2.Action = "失败";
            persons.Add(man2);

            AbstractPerson man3 = new Man();
            man3.Action = "恋爱";
            persons.Add(man3);

            AbstractPerson woman1 = new Woman();
            woman1.Action = "成功";
            persons.Add(woman1);

            AbstractPerson woman2 = new Woman();
            woman2.Action = "失败";
            persons.Add(woman2);

            AbstractPerson woman3 = new Woman();
            woman3.Action = "恋爱";
            persons.Add(woman3);

            foreach (var person in persons)
            {
                person.GetConclusion();
            }

            Console.Read();
        }
    }
}
