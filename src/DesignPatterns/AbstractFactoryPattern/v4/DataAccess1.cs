using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    public class DataAccess1
    {
        private static readonly string db = "SqlServer";

        public static IFactory CreateFactory()
        {
            IFactory factory = default(IFactory);

            //可以使用依赖注入来解决switch分支的问题
            switch (db)
            {
                case "SqlServer":
                    factory = new SqlServerFactory();
                    break;
                case "Acess":
                    factory = new AccessFactory();
                    break;
            }

            return factory;
        }
    }
}
