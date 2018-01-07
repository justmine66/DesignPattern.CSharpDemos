using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    public class DataAccessWithReflection
    {
        private static readonly string AssemblyName = "抽象工厂模式";
        private static readonly string db = "SqlServer";

        public static IFactory CreateFactory()
        {
            string className = AssemblyName + "." + db + "Factory";
            return Assembly.Load(AssemblyName).CreateInstance(className) as IFactory;
        }
    }
}
