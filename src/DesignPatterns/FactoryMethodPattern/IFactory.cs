using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern
{
    public interface IFactory
    {
        Operation CreateOperation();
    }
}
