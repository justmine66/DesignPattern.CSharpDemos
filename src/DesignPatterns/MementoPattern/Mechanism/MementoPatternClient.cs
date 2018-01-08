using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MementoPattern.Mechanism
{
    public class MementoPatternClient
    {
        public void Main()
        {
            Originator originator = new Originator();
            originator.State = "On";
            originator.Show();

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "Off";
            originator.Show();

            originator.SerMemento(caretaker.Memento);
            originator.Show();
        }
    }
}
