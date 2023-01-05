using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern_TemplateMethodPattern.TemplateMethodPattern
{
    public abstract class AbstractClass
    {
        protected  bool useHook1 { get; set; }
        // The template method defines the skeleton of an algorithm.
        public void TemplateMethod() {
            this.BaseOperation1();
            this.RequiredOperation1();
            this.Hook1();
            this.BaseOperation2();
            if (useHook1)
            {
                this.RequiredOperation2();
            }
            this.Hook2();
        }

        // These operations already have implementations.
        protected void BaseOperation1() {
            Console.WriteLine("This is Base Operation 1");
        }

        protected void BaseOperation2() {
            Console.WriteLine("This is Base Operation 2");
        }

        // These operations have to be implemented in subclasses.
        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();


        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1()
        {
            useHook1 = true;
        }

        protected virtual void Hook2() { }

    }
}
