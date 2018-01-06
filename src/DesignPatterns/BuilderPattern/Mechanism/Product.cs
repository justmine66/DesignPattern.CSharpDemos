using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BuilderPattern.Mechanism
{
    /// <summary>
    /// 产品类，由多个部件组成
    /// </summary>
    public class Product
    {
        public Product()
        {
            this.parts = new List<string>();
        }

        readonly IList<string> parts;

        /// <summary>
        /// 添加产品部件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        /// <summary>
        /// 列举所有的产品部件
        /// </summary>
        public void Show()
        {
            Console.WriteLine("产品 创建-----");
            foreach (var part in this.parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
