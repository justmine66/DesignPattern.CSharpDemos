using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPattern.v4
{
    /// <summary>
    /// IUser接口
    /// </summary>
    public interface IUser
    {
        void Insert(User user);
        User GetUser(int? id);
    }
}
