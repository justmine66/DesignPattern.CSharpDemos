using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibilityPattern.FunctionalChain
{
     public abstract class Handler
    {
        protected String Name;

        protected Handler Successor;

        public Handler(String name)
        {
            this.Name = name;
        }

        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }

        public abstract void handleRequest(Client request);
    }
}
