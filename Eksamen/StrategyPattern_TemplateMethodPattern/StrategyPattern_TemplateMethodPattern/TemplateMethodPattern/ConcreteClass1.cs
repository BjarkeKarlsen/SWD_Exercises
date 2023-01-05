using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TemplateMethodPattern.TemplateMethodPattern
{
    public class ConcreteClass1 : AbstractClass
    {
        protected override void RequiredOperation1() {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperation2() {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }
    }
}
