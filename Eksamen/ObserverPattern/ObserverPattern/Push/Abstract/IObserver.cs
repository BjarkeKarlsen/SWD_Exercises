using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Push.Abstract
{
    public interface IObserver
    {
        public void Update(SubjectData data);
    }
}
