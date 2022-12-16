﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.cs
{
    public interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
}
