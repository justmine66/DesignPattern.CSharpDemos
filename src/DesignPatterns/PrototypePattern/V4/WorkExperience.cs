using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypePattern.v4
{
    /// <summary>
    /// 工作经历类
    /// </summary>
    public class WorkExperience : ICloneable
    {
        public string WorkDate { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
