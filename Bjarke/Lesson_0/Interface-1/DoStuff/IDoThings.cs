﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff
{
    public interface IDoThings
    {
        void DoNothing();
        int DoSomething(int number);
        string DoSomething(string input);
    }
}
