﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Interfaces
{
    public interface IService<T>
    {
        void Create(T t);
        bool Delete(T t);
        int Update(T t);
        T[] FindAll();
    }
}
