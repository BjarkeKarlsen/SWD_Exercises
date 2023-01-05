using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TemplateMethodPattern.TemplateMethodPattern
{
    public class ConcreteClass2 : AbstractClass
    {
        protected override void RequiredOperation1() {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation1");
        }

        protected override void RequiredOperation2() {
            Console.WriteLine("ConcreteClass2 says: Implemented Operation2");
        }

        protected override void Hook1() {
            Console.WriteLine("ConcreteClass2 says: Overriden Hook1");
            useHook1 = false;
        }
    }
}
