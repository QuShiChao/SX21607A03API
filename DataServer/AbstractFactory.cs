﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServer
{
    public abstract class AbstractFactory<T>
    {
        public abstract Opetate<T> createDal(string dalName);
    }
}
