﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public interface IField
    {
        int Position { get; set; }
        string Mark { get; set; }
    }
}
