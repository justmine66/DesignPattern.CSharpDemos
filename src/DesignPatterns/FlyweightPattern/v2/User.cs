﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FlyweightPattern.v2
{
    public class User
    {
        string _name;
        public User(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
