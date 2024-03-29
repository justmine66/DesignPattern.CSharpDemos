﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypePattern.v4
{
    /// <summary>
    /// 简历
    /// </summary>
    public class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        //提供克隆方法调用私有的构造函数，一遍克隆工作经历的数据
        private Resume(WorkExperience work)
        {
            this.work = work.Clone() as WorkExperience;
        }

        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        /// <summary>
        /// 设置工作经历
        /// </summary>
        /// <param name="timeArea"></param>
        /// <param name="company"></param>
        public void SetWorkExprience(string timeArea, string company)
        {
            this.work.WorkDate = timeArea;
            this.work.Company = company;
        }


        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", this.name, this.sex, this.age);
            Console.WriteLine("工作经历：{0} {1}", this.work.WorkDate, this.work.Company);
        }

        public object Clone()
        {
            var copy = new Resume(this.work);
            copy.name = this.name;
            copy.age = this.age;
            copy.sex  = this.sex;
            return copy;
        }
    }
}
