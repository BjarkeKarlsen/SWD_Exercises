﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Pull.Abstract
{
    public interface IObserver
    {
        public void Update();
    }
}
