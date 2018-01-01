using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactoryPattern
{
    /// <summary>
    /// 摘要：
    ///     运算类工厂
    /// 备注：
    ///     使用简单工厂模式创建运算类的工厂
    /// </summary>
    public class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation operation = default(Operation);

            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "*":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;
            }

            return operation;
        }
    }
}
